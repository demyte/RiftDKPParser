using System.IO;
using System.Windows.Forms;

namespace RiftLogParser
{
	public static class ParserHelper
	{

		public static string GetFile(string existingFile)
		{
			if (existingFile == "") existingFile = Directory.GetCurrentDirectory();

			var fileDialog = new OpenFileDialog
			                 	{
			                 		InitialDirectory = new FileInfo(existingFile).DirectoryName,
			                 		Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
			                 		FilterIndex = 2,
			                 		RestoreDirectory = true
			                 	};


			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				return fileDialog.FileName;
			}

			return existingFile;

		}
	}
}