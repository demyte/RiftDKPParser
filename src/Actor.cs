namespace RiftLogParser
{
	public class Actor
	{
		public string Name { get; set; }

		public void GetFromStart(string logText)
		{
			var pos = logText.IndexOf("]");
			Name = logText.Substring(1, pos - 1);
		}

		public void GetFromLogUser()
		{
			Name = Settings.Get("LogUser");
		}
	}
}