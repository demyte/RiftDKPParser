namespace RiftLogParser
{
	partial class fmParser
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDumpFile = new System.Windows.Forms.TextBox();
			this.txtLogfile = new System.Windows.Forms.TextBox();
			this.btnBrowseLogFile = new System.Windows.Forms.Button();
			this.btnBrowseDumpFile = new System.Windows.Forms.Button();
			this.btnParse = new System.Windows.Forms.Button();
			this.txtLogUser = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tabResults = new System.Windows.Forms.TabControl();
			this.tabMembers = new System.Windows.Forms.TabPage();
			this.dataMembers = new System.Windows.Forms.DataGridView();
			this.tabLoot = new System.Windows.Forms.TabPage();
			this.dataLoot = new System.Windows.Forms.DataGridView();
			this.tabUploadOutput = new System.Windows.Forms.TabPage();
			this.txtUpload = new System.Windows.Forms.TextBox();
			this.tabRawOutput = new System.Windows.Forms.TabPage();
			this.txtRaw = new System.Windows.Forms.TextBox();
			this.lblStartTime = new System.Windows.Forms.Label();
			this.lblEndTime = new System.Windows.Forms.Label();
			this.dtStart = new System.Windows.Forms.DateTimePicker();
			this.dtEnd = new System.Windows.Forms.DateTimePicker();
			this.txtLootChannel = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAbout = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnHelp = new System.Windows.Forms.Button();
			this.tabResults.SuspendLayout();
			this.tabMembers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataMembers)).BeginInit();
			this.tabLoot.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataLoot)).BeginInit();
			this.tabUploadOutput.SuspendLayout();
			this.tabRawOutput.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Rift Log";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Raid Dump";
			// 
			// txtDumpFile
			// 
			this.txtDumpFile.Location = new System.Drawing.Point(12, 68);
			this.txtDumpFile.Name = "txtDumpFile";
			this.txtDumpFile.Size = new System.Drawing.Size(379, 20);
			this.txtDumpFile.TabIndex = 3;
			// 
			// txtLogfile
			// 
			this.txtLogfile.Location = new System.Drawing.Point(12, 29);
			this.txtLogfile.Name = "txtLogfile";
			this.txtLogfile.Size = new System.Drawing.Size(379, 20);
			this.txtLogfile.TabIndex = 4;
			// 
			// btnBrowseLogFile
			// 
			this.btnBrowseLogFile.Location = new System.Drawing.Point(397, 27);
			this.btnBrowseLogFile.Name = "btnBrowseLogFile";
			this.btnBrowseLogFile.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseLogFile.TabIndex = 6;
			this.btnBrowseLogFile.Text = "Browse";
			this.btnBrowseLogFile.UseVisualStyleBackColor = true;
			this.btnBrowseLogFile.Click += new System.EventHandler(this.btnBrowseLogFile_Click);
			// 
			// btnBrowseDumpFile
			// 
			this.btnBrowseDumpFile.Location = new System.Drawing.Point(397, 66);
			this.btnBrowseDumpFile.Name = "btnBrowseDumpFile";
			this.btnBrowseDumpFile.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseDumpFile.TabIndex = 7;
			this.btnBrowseDumpFile.Text = "Browse";
			this.btnBrowseDumpFile.UseVisualStyleBackColor = true;
			this.btnBrowseDumpFile.Click += new System.EventHandler(this.btnBrowseDumpFile_Click);
			// 
			// btnParse
			// 
			this.btnParse.Location = new System.Drawing.Point(12, 94);
			this.btnParse.Name = "btnParse";
			this.btnParse.Size = new System.Drawing.Size(75, 23);
			this.btnParse.TabIndex = 8;
			this.btnParse.Text = "Parse Raid";
			this.btnParse.UseVisualStyleBackColor = true;
			this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
			// 
			// txtLogUser
			// 
			this.txtLogUser.Location = new System.Drawing.Point(478, 68);
			this.txtLogUser.Name = "txtLogUser";
			this.txtLogUser.Size = new System.Drawing.Size(182, 20);
			this.txtLogUser.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(478, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Log User";
			// 
			// tabResults
			// 
			this.tabResults.Controls.Add(this.tabMembers);
			this.tabResults.Controls.Add(this.tabLoot);
			this.tabResults.Controls.Add(this.tabUploadOutput);
			this.tabResults.Controls.Add(this.tabRawOutput);
			this.tabResults.Location = new System.Drawing.Point(12, 123);
			this.tabResults.Name = "tabResults";
			this.tabResults.SelectedIndex = 0;
			this.tabResults.Size = new System.Drawing.Size(836, 416);
			this.tabResults.TabIndex = 11;
			this.tabResults.SelectedIndexChanged += new System.EventHandler(this.tabResults_SelectedIndexChanged);
			// 
			// tabMembers
			// 
			this.tabMembers.Controls.Add(this.dataMembers);
			this.tabMembers.Location = new System.Drawing.Point(4, 22);
			this.tabMembers.Name = "tabMembers";
			this.tabMembers.Padding = new System.Windows.Forms.Padding(3);
			this.tabMembers.Size = new System.Drawing.Size(828, 390);
			this.tabMembers.TabIndex = 4;
			this.tabMembers.Text = "Members";
			this.tabMembers.UseVisualStyleBackColor = true;
			// 
			// dataMembers
			// 
			this.dataMembers.AllowUserToOrderColumns = true;
			this.dataMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataMembers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataMembers.Location = new System.Drawing.Point(3, 3);
			this.dataMembers.Name = "dataMembers";
			this.dataMembers.Size = new System.Drawing.Size(822, 384);
			this.dataMembers.TabIndex = 16;
			// 
			// tabLoot
			// 
			this.tabLoot.Controls.Add(this.dataLoot);
			this.tabLoot.Location = new System.Drawing.Point(4, 22);
			this.tabLoot.Name = "tabLoot";
			this.tabLoot.Size = new System.Drawing.Size(828, 419);
			this.tabLoot.TabIndex = 3;
			this.tabLoot.Text = "Loot";
			this.tabLoot.UseVisualStyleBackColor = true;
			// 
			// dataLoot
			// 
			this.dataLoot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataLoot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataLoot.Location = new System.Drawing.Point(0, 0);
			this.dataLoot.Name = "dataLoot";
			this.dataLoot.Size = new System.Drawing.Size(837, 419);
			this.dataLoot.TabIndex = 15;
			// 
			// tabUploadOutput
			// 
			this.tabUploadOutput.Controls.Add(this.txtUpload);
			this.tabUploadOutput.Location = new System.Drawing.Point(4, 22);
			this.tabUploadOutput.Name = "tabUploadOutput";
			this.tabUploadOutput.Padding = new System.Windows.Forms.Padding(3);
			this.tabUploadOutput.Size = new System.Drawing.Size(828, 419);
			this.tabUploadOutput.TabIndex = 1;
			this.tabUploadOutput.Text = "Upload This";
			this.tabUploadOutput.UseVisualStyleBackColor = true;
			// 
			// txtUpload
			// 
			this.txtUpload.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtUpload.Location = new System.Drawing.Point(3, 3);
			this.txtUpload.Multiline = true;
			this.txtUpload.Name = "txtUpload";
			this.txtUpload.ReadOnly = true;
			this.txtUpload.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtUpload.Size = new System.Drawing.Size(831, 413);
			this.txtUpload.TabIndex = 13;
			this.txtUpload.WordWrap = false;
			// 
			// tabRawOutput
			// 
			this.tabRawOutput.Controls.Add(this.txtRaw);
			this.tabRawOutput.Location = new System.Drawing.Point(4, 22);
			this.tabRawOutput.Name = "tabRawOutput";
			this.tabRawOutput.Size = new System.Drawing.Size(828, 419);
			this.tabRawOutput.TabIndex = 2;
			this.tabRawOutput.Text = "Raw Output";
			this.tabRawOutput.UseVisualStyleBackColor = true;
			// 
			// txtRaw
			// 
			this.txtRaw.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtRaw.Location = new System.Drawing.Point(0, 0);
			this.txtRaw.Multiline = true;
			this.txtRaw.Name = "txtRaw";
			this.txtRaw.ReadOnly = true;
			this.txtRaw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtRaw.Size = new System.Drawing.Size(837, 419);
			this.txtRaw.TabIndex = 13;
			this.txtRaw.WordWrap = false;
			// 
			// lblStartTime
			// 
			this.lblStartTime.AutoSize = true;
			this.lblStartTime.Location = new System.Drawing.Point(478, 14);
			this.lblStartTime.Name = "lblStartTime";
			this.lblStartTime.Size = new System.Drawing.Size(55, 13);
			this.lblStartTime.TabIndex = 12;
			this.lblStartTime.Text = "Start Time";
			// 
			// lblEndTime
			// 
			this.lblEndTime.AutoSize = true;
			this.lblEndTime.Location = new System.Drawing.Point(668, 14);
			this.lblEndTime.Name = "lblEndTime";
			this.lblEndTime.Size = new System.Drawing.Size(52, 13);
			this.lblEndTime.TabIndex = 15;
			this.lblEndTime.Text = "End Time";
			// 
			// dtStart
			// 
			this.dtStart.CustomFormat = "hh:mm:ss";
			this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtStart.Location = new System.Drawing.Point(478, 30);
			this.dtStart.Name = "dtStart";
			this.dtStart.ShowUpDown = true;
			this.dtStart.Size = new System.Drawing.Size(182, 20);
			this.dtStart.TabIndex = 16;
			// 
			// dtEnd
			// 
			this.dtEnd.CustomFormat = "hh:mm:ss";
			this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtEnd.Location = new System.Drawing.Point(666, 30);
			this.dtEnd.Name = "dtEnd";
			this.dtEnd.ShowUpDown = true;
			this.dtEnd.Size = new System.Drawing.Size(182, 20);
			this.dtEnd.TabIndex = 17;
			// 
			// txtLootChannel
			// 
			this.txtLootChannel.Location = new System.Drawing.Point(666, 68);
			this.txtLootChannel.Name = "txtLootChannel";
			this.txtLootChannel.Size = new System.Drawing.Size(182, 20);
			this.txtLootChannel.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(666, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "Loot Channel";
			// 
			// btnAbout
			// 
			this.btnAbout.Location = new System.Drawing.Point(688, 545);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(75, 23);
			this.btnAbout.TabIndex = 20;
			this.btnAbout.Text = "About";
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(769, 545);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 21;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnHelp
			// 
			this.btnHelp.Location = new System.Drawing.Point(607, 545);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(75, 23);
			this.btnHelp.TabIndex = 22;
			this.btnHelp.Text = "Help";
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// fmParser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(857, 580);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.txtLootChannel);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtEnd);
			this.Controls.Add(this.dtStart);
			this.Controls.Add(this.lblEndTime);
			this.Controls.Add(this.lblStartTime);
			this.Controls.Add(this.tabResults);
			this.Controls.Add(this.txtLogUser);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnParse);
			this.Controls.Add(this.btnBrowseDumpFile);
			this.Controls.Add(this.btnBrowseLogFile);
			this.Controls.Add(this.txtLogfile);
			this.Controls.Add(this.txtDumpFile);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "fmParser";
			this.Text = "Rift DKP Parser";
			this.tabResults.ResumeLayout(false);
			this.tabMembers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataMembers)).EndInit();
			this.tabLoot.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataLoot)).EndInit();
			this.tabUploadOutput.ResumeLayout(false);
			this.tabUploadOutput.PerformLayout();
			this.tabRawOutput.ResumeLayout(false);
			this.tabRawOutput.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox txtDumpFile;
		public System.Windows.Forms.TextBox txtLogfile;
		private System.Windows.Forms.Button btnBrowseLogFile;
		private System.Windows.Forms.Button btnBrowseDumpFile;
		private System.Windows.Forms.Button btnParse;
		private System.Windows.Forms.TextBox txtLogUser;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TabControl tabResults;
		private System.Windows.Forms.TabPage tabUploadOutput;
		private System.Windows.Forms.TabPage tabRawOutput;
		private System.Windows.Forms.TextBox txtRaw;
		private System.Windows.Forms.TextBox txtUpload;
		private System.Windows.Forms.Label lblStartTime;
		private System.Windows.Forms.Label lblEndTime;
		public System.Windows.Forms.DateTimePicker dtStart;
		public System.Windows.Forms.DateTimePicker dtEnd;
		private System.Windows.Forms.TabPage tabLoot;
		public System.Windows.Forms.DataGridView dataLoot;
		private System.Windows.Forms.TabPage tabMembers;
		public System.Windows.Forms.DataGridView dataMembers;
		private System.Windows.Forms.TextBox txtLootChannel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnHelp;


	}
}

