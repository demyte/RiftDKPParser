using System;

namespace RiftLogParser
{
	public class Raid
	{
		public string RaidName { get; set; }
		public DateTime RaidDate { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public double Duration { get; set; }

		public Raid(string raidName, DateTime raidDate, DateTime startTime, DateTime endTime)
		{
			RaidName = raidName;
			RaidDate = raidDate;
			StartTime = startTime;
			EndTime = endTime;
			Duration = endTime.Subtract(startTime).TotalSeconds;
		}
	}
}