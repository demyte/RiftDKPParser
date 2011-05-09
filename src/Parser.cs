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
		private readonly fmParser _parentForm;
		public List<LogEntry> entries = new List<LogEntry>();
		public BindingList<RaidMember> Members = new BindingList<RaidMember>();
		public BindingList<LootItem> LootItems = new BindingList<LootItem>();
		public Raid _raid;

		public Parser(fmParser mainForm)
		{
			_parentForm = mainForm;
		}

		public void Parse()
		{
			_logFile = File.OpenRead(_parentForm.txtLogfile.Text);
			_raidFile = File.OpenRead(_parentForm.txtDumpFile.Text);
			_raid = new Raid(_parentForm.txtRaidName.Text,
							DateTime.Parse(String.Format("{0} {1}", _parentForm.dtRaidDate.Text, _parentForm.dtStart.Text)),
							DateTime.Parse(String.Format("{0} {1}", _parentForm.dtRaidDate.Text, _parentForm.dtStart.Text)),
							DateTime.Parse(String.Format("{0} {1}", _parentForm.dtRaidDate.Text, _parentForm.dtEnd.Text)),
							int.Parse(_parentForm.txtPointsPerHour.Text),
							int.Parse(_parentForm.txtAtStartPoints.Text),
							int.Parse(_parentForm.txtAtEndPoints.Text));

			// Get all the members found in the raid.xml
			ParseMembersFromRaidXML();

			string line;

			var reader = new StreamReader(_logFile);

			while ((line = reader.ReadLine()) != null)
			{
				var entry = new LogEntry(line, _parentForm.dtRaidDate.Text);
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
			var startTimeOk = entry.EventTime.Ticks > _raid.StartTime.Ticks;
			var endTimeOk = entry.EventTime.Ticks < _raid.EndTime.Ticks;
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
			}
			else
			{
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
			Members.Each(m => m.CalculateDuration(_raid.StartTime, _raid.EndTime));
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
			var raidData = _raid.ShowExportedData();
			var memberData = Members.Aggregate("", (current, raidMember) => current + (raidMember.ShowExportData() + "\r\n"));
			var lootData = LootItems.Aggregate("", (current, LootItem) => current + (LootItem.ShowExportData() + "\r\n"));
			return raidData + memberData + lootData;
		}
	}
}