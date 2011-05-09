using System;

namespace RiftLogParser
{
	public class Raid
	{
		public string RaidName { get; set; }
		public DateTime RaidDate { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public int PointsPerHour { get; set; }
		public int AtStartBonus { get; set; }
		public int AtEndBonus { get; set; }
		public double Duration { get; set; }

		public Raid(string raidName, DateTime raidDate, DateTime startTime, DateTime endTime, int pointsPerHour, int atStartBonus, int atEndBonus)
		{
			RaidName = raidName;
			RaidDate = raidDate;
			StartTime = startTime;
			EndTime = endTime;
			PointsPerHour = pointsPerHour;
			AtStartBonus = atStartBonus;
			AtEndBonus = atEndBonus;
			Duration = endTime.Subtract(startTime).TotalSeconds;
		}

		public string ShowExportedData()
		{
			return string.Format("raid,{0},{1},{2},{3},{4},{5}" + "\r\n", RaidName, StartTime.ToString("yyyy-mm-dd hh:mm"), EndTime.ToString("yyyy-mm-dd hh:mm"), PointsPerHour, AtStartBonus, AtEndBonus);
		}
	}
}