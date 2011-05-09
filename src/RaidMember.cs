using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RiftLogParser
{
	public class RaidMember : INotifyPropertyChanged
	{
		private string _name;
		public List<DateTime> Joins { get; private set; }
		public List<DateTime> Leaves { get; private set; }
		private bool _atStart;
		private bool _atEnd;
		private bool _onBench;
		private double _duration;

		// Need this empty constructor for DGV Binding
		public RaidMember() { }

		public RaidMember(string name)
		{
			Name = name;
			Joins = new List<DateTime>();
			Leaves = new List<DateTime>();
		}


		public string Name
		{
			get { return _name; }
			set
			{
				_name = value;
				this.NotifyPropertyChanged("Name");
			}
		}

		public bool AtStart
		{
			get { return _atStart; }
			set
			{
				_atStart = value;
				this.NotifyPropertyChanged("AtStart");
			}
		}

		
		public bool AtEnd
		{
			get { return _atEnd; }
			set
			{
				_atEnd = value;
				this.NotifyPropertyChanged("AtEnd");
			}
		}

		public bool OnBench
		{
			get { return _onBench; }
			set
			{
				_onBench = value;
				this.NotifyPropertyChanged("OnBench");
			}
		}

		
		public double Duration
		{
			get { return _duration; }
			set
			{
				_duration = value;
				this.NotifyPropertyChanged("Duration");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged(string name)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(name));
		}

		public void CalculateDuration(DateTime start, DateTime end)
		{
			

			if (Joins.Count == 0)
			{
				AtStart = true;
				Joins.Add(start);
				Joins.Sort();
			}

			if (Leaves.Count == 0)
			{
				AtEnd = true;
				Leaves.Add(end);
				Leaves.Sort();
			}

			if (IsLeaveFirst())
			{
				AtStart = true;
				Joins.Add(start);
				Joins.Sort();
			}

			if (IsJoinLast())
			{
				AtEnd = true;
				Leaves.Add(end);
				Leaves.Sort();
			}

			Joins.Sort();
			Leaves.Sort();

			
			Duration = MemberRaidDuration.Calculate(Joins, Leaves, AtStart, AtEnd);	
			}

		private bool IsJoinLast()
		{
			return Joins[Joins.Count - 1] > Leaves[Leaves.Count - 1];
		}

		private bool IsLeaveFirst()
		{
			return Leaves[0] < Joins[0];
		}

		public string ShowExportData()
		{
			return string.Format("attendance,{0},{1},{2},{3},{4}", Name, Duration, AtStart, AtEnd, OnBench);
		}
	}
}