using System;
using System.Text.RegularExpressions;

namespace RiftLogParser
{
	public class LogEntry
	{
		private readonly string _lootChannel;
		public string Entry { get; private set; }
		public DateTime EventTime { get; private set; }
		public string EventText { get; private set; }
		public EventType Type { get; private set; }

		public LogEntry(string entry)
		{
			Entry = entry;
			_lootChannel = String.Format("{0}][", Settings.Get("LootChannel"));
		}

		public bool IsValid()
		{
			// In right date time range
			// Has an entry we care about			

			return Type != EventType.Invalid;
		}

		public void Parse()
		{
			Type = EventType.Invalid;					

			EventTime = DateTime.Parse(Entry.Substring(0, 8)).ToLocalTime();
			EventText = Entry.Substring(10);

			if (EventText.EndsWith("has joined the raid"))
			{				
				Type = EventType.Join;
			}

			if (EventText.EndsWith("has left the raid"))
			{				
				Type = EventType.Leave;
			}

			if (EventText == "You've left the raid group!")
			{				
				Type = EventType.LeaveByLogger;
			}

			if (EventText == "You've entered a raid group!")
			{				
				Type = EventType.JoinByLogger;
			}

			if (EventText.Contains(_lootChannel))
			{
				// Will not match anything but in the format
				// [blah] - [blah] - ###
				if (Regex.Match(EventText, @"[^\]:]\[.*?\] - \[.*?\] - \d*").Success)
				{
					Type = EventType.Loot;
				}
			}
		}
	}
}