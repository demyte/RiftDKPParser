using System;
using System.ComponentModel;

namespace RiftLogParser
{
	public class LootItem : INotifyPropertyChanged
	{
		//	[Player] - [Item] - 000		

		public readonly LogEntry Entry;
					
		private string _name;
		private string _looter;
		private double _paid;
		private string[] _lootDetail;

		public event PropertyChangedEventHandler PropertyChanged;

		// Need this empty constructor for DGV Binding
		public LootItem(){}

		public LootItem(LogEntry logEntry)
		{
			Entry = logEntry;
			_lootDetail = GetLootDetail();
			if (_lootDetail.Length == 3)
			{
				Name = _lootDetail[1].Trim().Trim('[').Trim(']');
				Looter = _lootDetail[0].Trim().Trim('[').Trim(']');		
				Paid = int.Parse(_lootDetail[2].Trim());	
			}		
		}

		private string[] GetLootDetail()
		{
			var eventText = Entry.EventText;
			var pos = eventText.IndexOf(':');

			eventText = eventText.Substring(pos + 2);
			return eventText.Split(new[] {" - "}, 100, StringSplitOptions.RemoveEmptyEntries);
		}

		private void NotifyPropertyChanged(string name)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(name));
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

		public string Looter
		{
			get { return _looter; }
			set
			{
				_looter = value;
				this.NotifyPropertyChanged("Looter");
			}
		}

		public double Paid
		{
			get { return _paid; }
			set { 
				_paid = value;
				this.NotifyPropertyChanged("Paid");
			}
		}

		public string ShowExportData()
		{
			return string.Format("{0},{1},{2}", Name, Looter, Paid);
		}
	}
}