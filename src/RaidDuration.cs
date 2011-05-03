using System;
using System.Collections.Generic;

namespace RiftLogParser
{
	public static class RaidDuration
	{
		public static double Calculate(List<DateTime> joins, List<DateTime> leaves, bool atStart, bool atEnd)
		{
			var findNext = "Join";
			var joinCounter = 0;
			var leaveCounter = 0;
			double duration = 0;
			DateTime currentTime = DateTime.Now;

			

			while (findNext != "")
			{
				switch (findNext)
				{
					case "Join":
						if (joins.Count > joinCounter)
						{
							currentTime = joins[joinCounter];
							findNext = "Leave";
							joinCounter++;
						} else
						{
							findNext = "";
						}
						break;

					case "Leave":
						if (leaves.Count > leaveCounter)
						{
							duration += leaves[leaveCounter].Subtract(currentTime).TotalSeconds;
							findNext = "Join";
							leaveCounter++;
						}
						break;
				}

			}

			return duration;
		}
	}
}