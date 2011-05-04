using System;
using System.IO;
using System.Windows.Forms;

namespace RiftLogParser
{
	public partial class fmParser : Form
	{
		private Parser _parser;	

		public fmParser()
		{
			InitializeComponent();						
			LoadConfiguration();			
		}

		private void LoadConfiguration()
		{
			txtLogfile.Text = Settings.Get("LogFileLocation");
			txtDumpFile.Text = Settings.Get("DumpFileLocation");
			txtLogUser.Text = Settings.Get("LogUser");
			txtLootChannel.Text = Settings.Get("LootChannel");
			dtStart.Text = Settings.Get("StartTime");
			dtEnd.Text = Settings.Get("EndTime");
			dtRaidDate.Text = Settings.Get("RaidDate");
			txtRaidName.Text = Settings.Get("RaidName");	
		}

		private void btnBrowseLogFile_Click(object sender, EventArgs e)
		{
			txtLogfile.Text = ParserHelper.GetFile(txtLogfile.Text);
			Settings.Set("LogFileLocation", txtLogfile.Text);		
		}

		private void btnBrowseDumpFile_Click(object sender, EventArgs e)
		{
			txtDumpFile.Text = ParserHelper.GetFile(txtDumpFile.Text);
			Settings.Set("DumpFileLocation", txtDumpFile.Text);	
		}

		private void btnParse_Click(object sender, EventArgs e)
		{
			var clearParsedData = DialogResult.OK;

			if (!ValidateForm()) return;

			Settings.Set("LogUser", txtLogUser.Text);
			Settings.Set("LootChannel", txtLootChannel.Text);
			Settings.Set("StartTime", dtStart.Text);
			Settings.Set("EndTime", dtEnd.Text);
			Settings.Set("DumpFileLocation", txtDumpFile.Text);
			Settings.Set("LogFileLocation", txtLogfile.Text);
			Settings.Set("RaidName", txtRaidName.Text);
			Settings.Set("RaidDate", dtRaidDate.Text);

			if (_parser != null)
			{
				clearParsedData = MessageBox.Show(
									"You already have a raid parsed. If you continue you will lose this parsed data and replace it with the newly parsed data",
									"Replace Existing Data", 
									MessageBoxButtons.OKCancel, 
									MessageBoxIcon.Question, 
									MessageBoxDefaultButton.Button1);
				
			}

			if (clearParsedData != DialogResult.OK) return;

			_parser = new Parser(this);
			_parser.Parse();

			//if (_parser.Members.Count)
			dataLoot.DataSource = _parser.LootItems;
			dataMembers.DataSource = _parser.Members;
			dataLoot.DataSource = _parser.LootItems;
			txtUpload.Text = _parser.GetUploadData();
			
			// For debugging purposes
			txtRaw.Text = _parser.GetRawEntries();
		}

		private bool ValidateForm()
		{
			if (dtStart.Text == "" || dtEnd.Text == "" || txtLogfile.Text == "" ||
			    txtDumpFile.Text == "" || txtLogUser.Text == "" || txtLootChannel.Text == "")
			{
				MessageBox.Show(
					"You have not filled out all fields.  Please do so before parsing.",
					"Form Fields Invalid",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
				return false;
			}
			if (DateTime.Parse(dtStart.Text) > DateTime.Parse(dtEnd.Text))
			{
				MessageBox.Show(
					"Your raid start time must be before your raid end time.",
					"Invalid Raid Times",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
				return false;
			}
			if(!new FileInfo(txtLogfile.Text).Exists)
			{
				MessageBox.Show(
					"Your log file does not exist.",
					"Invalid Log File",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
				return false;
			}
			if (!new FileInfo(txtDumpFile.Text).Exists)
			{
				MessageBox.Show(
					"Your raid dump file does not exist.",
					"Invalid Raid File",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
				return false;
			}
			return true;
		}


		private void tabResults_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabResults.SelectedTab != tabUploadOutput) return;

			if (_parser != null)
				txtUpload.Text = _parser.GetUploadData();
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			var fmAbout = new fmAbout
			              	{
			              		Owner = this
			              	};
			fmAbout.Show();

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
					"This is not the help you are looking for *wave hand*",
					"No Help Here",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			return;
		}
	}
}
