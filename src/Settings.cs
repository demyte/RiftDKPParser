using System.Configuration;
using System.Windows.Forms;

namespace RiftLogParser
{
	public static class Settings
	{
		private static readonly Configuration _config;

		static Settings()
		{
			_config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
		}

		public static void Set(string key, string value)
		{
			_config.AppSettings.Settings[key].Value = value;
			_config.Save();
		}

		public static string Get(string key)
		{
			return _config.AppSettings.Settings[key].Value;
		}

	}
}