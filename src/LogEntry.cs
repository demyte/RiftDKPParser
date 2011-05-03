using System;

namespace RiftLogParser
{
	public class LogEntry
	{
		private string _lootChannel;
		// KNOWN LOG ENTRIES TO DETECT
		//	You've left the raid group!
		//	You've entered a raid group!
		//	[Player] has joined the raid
		//	[Player] has left the raid
		//	[Player] has looted [Item]!
		//	You received: [Item]

		public string Entry { get; private set;}
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
				Type = EventType.Loot;
			}
		}

//		public string ParsedResult()
//		{
//			var description = "";
//			description += Type + "\t\t";
//			description += EventTime.TimeOfDay + "\t";
//
//			if (!string.IsNullOrEmpty(Actor.Name))
//				description += Actor.Name + "\t";
//
//			if (!string.IsNullOrEmpty(Item.Name))
//				description += Item.Name + "\t";
//
//			return description;
//		}
	}
}