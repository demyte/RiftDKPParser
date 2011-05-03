using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace RiftLogParser
{
	public class Parser
	{
		private FileStream _logFile;
		private FileStream _raidFile;
		private DateTime _raidStartTime;
		private DateTime _raidEndTime;
		private readonly List<LogEntry> entries = new List<LogEntry>();
		public BindingList<RaidMember> Members = new BindingList<RaidMember>();
		public BindingList<LootItem> LootItems = new BindingList<LootItem>();
		private readonly fmParser _parentForm;

		public Parser(fmParser mainForm)
		{
			_parentForm = mainForm;			
		}

		public void Parse()
		{

			_logFile = File.OpenRead(_parentForm.txtLogfile.Text);
			_raidFile = File.OpenRead(_parentForm.txtDumpFile.Text);
			_raidStartTime = DateTime.Parse(_parentForm.dtStart.Text);
			_raidEndTime = DateTime.Parse(_parentForm.dtEnd.Text);
			_parentForm.dataLoot.DataSource = LootItems;

			// Get all the members found in the raid.xml
			ParseMembersFromRaidXML();

			string line;

			var reader = new StreamReader(_logFile);

			while ((line = reader.ReadLine()) != null)
			{
				var entry = new LogEntry(line);
				entry.Parse();

				if (EntryIsValid(entry)) continue;

				switch (entry.Type)
				{
					case EventType.Loot:
						ParseLootInformation(entry);
						break;

					case EventType.Join:
					case EventType.JoinByLogger:
						ParseJoinInformation(entry);
						break;

					case EventType.Leave:
					case EventType.LeaveByLogger:
						ParseLeaveInformation(entry);
						break;
				}
				
				entries.Add(entry);				
			}

			_logFile.Close();
			_raidFile.Close();

			CalculateRaidDurationForMembers();
		}

		private bool EntryIsValid(LogEntry entry)
		{
			var startTimeOk = entry.EventTime.Ticks > _raidStartTime.Ticks;
			var endTimeOk = entry.EventTime.Ticks < _raidEndTime.Ticks;
			var IsDuplicate = (entries.Exists(e => e.Entry == entry.Entry));
			var IsValid = entry.Type != EventType.Invalid;

			return !startTimeOk || !endTimeOk || IsDuplicate || !IsValid;
		}

		private void ParseLeaveInformation(LogEntry entry)
		{
			var memberName = "";

			if (entry.Type == EventType.LeaveByLogger)
			{
				memberName = Settings.Get("LogUser");
			} else {
				var pos = entry.EventText.IndexOf("]");
				memberName = entry.EventText.Substring(1, pos - 1);
			}

			if (!MemberExists(memberName))
				Members.Add(new RaidMember(memberName));

			var member = GetMember(memberName);

			member.Leaves.Add(entry.EventTime);
		}

		private void ParseJoinInformation(LogEntry entry)
		{
			var memberName = "";
			if (entry.Type == EventType.JoinByLogger)
			{
				memberName = Settings.Get("LogUser");
			}
			else
			{
				var pos = entry.EventText.IndexOf("]");
				memberName = entry.EventText.Substring(1, pos - 1);
			}

			if (!MemberExists(memberName))
				Members.Add(new RaidMember(memberName));

			var member = GetMember(memberName);

			member.Joins.Add(entry.EventTime);
		}

		private RaidMember GetMember(string memberName)
		{
			return (from m in Members
			        where m.Name == memberName
			        select m).FirstOrDefault();
		}

		private bool MemberExists(string memberName)
		{		
			 return GetMember(memberName) != null;
		}

		private void ParseLootInformation(LogEntry entry)
		{
			var lootItem = new LootItem(entry);	

			if (lootItem.Name != null)
				LootItems.Add(lootItem);
		}

		private void CalculateRaidDurationForMembers()
		{
			Members.Each(m => m.CalculateDuration(_raidStartTime, _raidEndTime));
		}

		private void ParseMembersFromRaidXML()
		{
			var reader = new StreamReader(_raidFile);
			var raidInfo = XElement.Parse(reader.ReadToEnd());

			var raidMembers = raidInfo
								.Descendants("Member")
								.Select(m => new RaidMember(m.Descendants("Name").First().Value));

			foreach (var member in raidMembers.Where(member => !MemberExists(member.Name)))
			{
				Members.Add(member);
			}				
		}

		public string GetRawEntries()
		{
			return entries.Aggregate("", (current, logEntry) => current + (logEntry.Entry + "\r\n"));
		}

		public string GetUploadData()
		{
			var memberData = Members.Aggregate("", (current, raidMember) => current + (raidMember.ShowExportData() + "\r\n"));
			var lootData = LootItems.Aggregate("", (current, LootItem) => current + (LootItem.ShowExportData() + "\r\n"));
			return "ATTENDANCE\r\n" + memberData + "\r\nLOOT\r\n" + lootData;
		}
	}
}