﻿namespace RiftLogParser
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.dtRaidDate = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.txtRaidName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPointsPerHour = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtAtStartPoints = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtAtEndPoints = new System.Windows.Forms.TextBox();
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
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Raid Dump";
			// 
			// txtDumpFile
			// 
			this.txtDumpFile.Location = new System.Drawing.Point(12, 64);
			this.txtDumpFile.Name = "txtDumpFile";
			this.txtDumpFile.Size = new System.Drawing.Size(379, 20);
			this.txtDumpFile.TabIndex = 3;
			// 
			// txtLogfile
			// 
			this.txtLogfile.Location = new System.Drawing.Point(12, 25);
			this.txtLogfile.Name = "txtLogfile";
			this.txtLogfile.Size = new System.Drawing.Size(379, 20);
			this.txtLogfile.TabIndex = 4;			
			// 
			// btnBrowseLogFile
			// 
			this.btnBrowseLogFile.Location = new System.Drawing.Point(397, 22);
			this.btnBrowseLogFile.Name = "btnBrowseLogFile";
			this.btnBrowseLogFile.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseLogFile.TabIndex = 6;
			this.btnBrowseLogFile.Text = "Browse";
			this.btnBrowseLogFile.UseVisualStyleBackColor = true;
			this.btnBrowseLogFile.Click += new System.EventHandler(this.btnBrowseLogFile_Click);
			// 
			// btnBrowseDumpFile
			// 
			this.btnBrowseDumpFile.Location = new System.Drawing.Point(397, 62);
			this.btnBrowseDumpFile.Name = "btnBrowseDumpFile";
			this.btnBrowseDumpFile.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseDumpFile.TabIndex = 7;
			this.btnBrowseDumpFile.Text = "Browse";
			this.btnBrowseDumpFile.UseVisualStyleBackColor = true;
			this.btnBrowseDumpFile.Click += new System.EventHandler(this.btnBrowseDumpFile_Click);
			// 
			// btnParse
			// 
			this.btnParse.Location = new System.Drawing.Point(12, 129);
			this.btnParse.Name = "btnParse";
			this.btnParse.Size = new System.Drawing.Size(75, 23);
			this.btnParse.TabIndex = 8;
			this.btnParse.Text = "Parse Raid";
			this.btnParse.UseVisualStyleBackColor = true;
			this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
			// 
			// txtLogUser
			// 
			this.txtLogUser.Location = new System.Drawing.Point(12, 103);
			this.txtLogUser.Name = "txtLogUser";
			this.txtLogUser.Size = new System.Drawing.Size(182, 20);
			this.txtLogUser.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Log User";
			// 
			// tabResults
			// 
			this.tabResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tabResults.Controls.Add(this.tabMembers);
			this.tabResults.Controls.Add(this.tabLoot);
			this.tabResults.Controls.Add(this.tabUploadOutput);
			this.tabResults.Controls.Add(this.tabRawOutput);
			this.tabResults.Location = new System.Drawing.Point(12, 158);
			this.tabResults.Name = "tabResults";
			this.tabResults.SelectedIndex = 0;
			this.tabResults.Size = new System.Drawing.Size(836, 381);
			this.tabResults.TabIndex = 11;
			this.tabResults.SelectedIndexChanged += new System.EventHandler(this.tabResults_SelectedIndexChanged);
			// 
			// tabMembers
			// 
			this.tabMembers.Controls.Add(this.dataMembers);
			this.tabMembers.Location = new System.Drawing.Point(4, 22);
			this.tabMembers.Name = "tabMembers";
			this.tabMembers.Padding = new System.Windows.Forms.Padding(3);
			this.tabMembers.Size = new System.Drawing.Size(828, 355);
			this.tabMembers.TabIndex = 4;
			this.tabMembers.Text = "Members";
			this.tabMembers.UseVisualStyleBackColor = true;
			// 
			// dataMembers
			// 
			this.dataMembers.AllowUserToOrderColumns = true;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dataMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataMembers.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataMembers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataMembers.Location = new System.Drawing.Point(3, 3);
			this.dataMembers.Name = "dataMembers";
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dataMembers.Size = new System.Drawing.Size(822, 349);
			this.dataMembers.TabIndex = 16;
			// 
			// tabLoot
			// 
			this.tabLoot.Controls.Add(this.dataLoot);
			this.tabLoot.Location = new System.Drawing.Point(4, 22);
			this.tabLoot.Name = "tabLoot";
			this.tabLoot.Size = new System.Drawing.Size(828, 355);
			this.tabLoot.TabIndex = 3;
			this.tabLoot.Text = "Loot";
			this.tabLoot.UseVisualStyleBackColor = true;
			// 
			// dataLoot
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataLoot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.dataLoot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataLoot.DefaultCellStyle = dataGridViewCellStyle11;
			this.dataLoot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataLoot.Location = new System.Drawing.Point(0, 0);
			this.dataLoot.Name = "dataLoot";
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataLoot.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dataLoot.Size = new System.Drawing.Size(828, 355);
			this.dataLoot.TabIndex = 15;
			// 
			// tabUploadOutput
			// 
			this.tabUploadOutput.Controls.Add(this.txtUpload);
			this.tabUploadOutput.Location = new System.Drawing.Point(4, 22);
			this.tabUploadOutput.Name = "tabUploadOutput";
			this.tabUploadOutput.Padding = new System.Windows.Forms.Padding(3);
			this.tabUploadOutput.Size = new System.Drawing.Size(828, 355);
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
			this.txtUpload.Size = new System.Drawing.Size(822, 349);
			this.txtUpload.TabIndex = 13;
			this.txtUpload.WordWrap = false;
			// 
			// tabRawOutput
			// 
			this.tabRawOutput.Controls.Add(this.txtRaw);
			this.tabRawOutput.Location = new System.Drawing.Point(4, 22);
			this.tabRawOutput.Name = "tabRawOutput";
			this.tabRawOutput.Size = new System.Drawing.Size(828, 355);
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
			this.txtRaw.Size = new System.Drawing.Size(828, 355);
			this.txtRaw.TabIndex = 13;
			this.txtRaw.WordWrap = false;
			// 
			// lblStartTime
			// 
			this.lblStartTime.AutoSize = true;
			this.lblStartTime.Location = new System.Drawing.Point(475, 48);
			this.lblStartTime.Name = "lblStartTime";
			this.lblStartTime.Size = new System.Drawing.Size(55, 13);
			this.lblStartTime.TabIndex = 12;
			this.lblStartTime.Text = "Start Time";
			// 
			// lblEndTime
			// 
			this.lblEndTime.AutoSize = true;
			this.lblEndTime.Location = new System.Drawing.Point(666, 48);
			this.lblEndTime.Name = "lblEndTime";
			this.lblEndTime.Size = new System.Drawing.Size(52, 13);
			this.lblEndTime.TabIndex = 15;
			this.lblEndTime.Text = "End Time";
			// 
			// dtStart
			// 
			this.dtStart.CustomFormat = "hh:mm:ss";
			this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtStart.Location = new System.Drawing.Point(475, 62);
			this.dtStart.Name = "dtStart";
			this.dtStart.ShowUpDown = true;
			this.dtStart.Size = new System.Drawing.Size(182, 20);
			this.dtStart.TabIndex = 16;
			// 
			// dtEnd
			// 
			this.dtEnd.CustomFormat = "hh:mm:ss";
			this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtEnd.Location = new System.Drawing.Point(666, 62);
			this.dtEnd.Name = "dtEnd";
			this.dtEnd.ShowUpDown = true;
			this.dtEnd.Size = new System.Drawing.Size(182, 20);
			this.dtEnd.TabIndex = 17;
			// 
			// txtLootChannel
			// 
			this.txtLootChannel.Location = new System.Drawing.Point(200, 103);
			this.txtLootChannel.Name = "txtLootChannel";
			this.txtLootChannel.Size = new System.Drawing.Size(191, 20);
			this.txtLootChannel.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(197, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "Loot Channel";
			// 
			// btnAbout
			// 
			this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnHelp.Location = new System.Drawing.Point(607, 545);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(75, 23);
			this.btnHelp.TabIndex = 22;
			this.btnHelp.Text = "Help";
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// dtRaidDate
			// 
			this.dtRaidDate.CustomFormat = "hh:mm:ss";
			this.dtRaidDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtRaidDate.Location = new System.Drawing.Point(666, 25);
			this.dtRaidDate.Name = "dtRaidDate";
			this.dtRaidDate.ShowUpDown = true;
			this.dtRaidDate.Size = new System.Drawing.Size(182, 20);
			this.dtRaidDate.TabIndex = 26;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(475, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 25;
			this.label5.Text = "Raid Name";
			// 
			// txtRaidName
			// 
			this.txtRaidName.Location = new System.Drawing.Point(475, 25);
			this.txtRaidName.Name = "txtRaidName";
			this.txtRaidName.Size = new System.Drawing.Size(182, 20);
			this.txtRaidName.TabIndex = 24;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(666, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 23;
			this.label6.Text = "Raid Date";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(475, 87);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 13);
			this.label7.TabIndex = 28;
			this.label7.Text = "Points per Hour";
			// 
			// txtPointsPerHour
			// 
			this.txtPointsPerHour.Location = new System.Drawing.Point(475, 103);
			this.txtPointsPerHour.Name = "txtPointsPerHour";
			this.txtPointsPerHour.Size = new System.Drawing.Size(116, 20);
			this.txtPointsPerHour.TabIndex = 27;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(602, 87);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 13);
			this.label8.TabIndex = 30;
			this.label8.Text = "At Start Points";
			// 
			// txtAtStartPoints
			// 
			this.txtAtStartPoints.Location = new System.Drawing.Point(601, 103);
			this.txtAtStartPoints.Name = "txtAtStartPoints";
			this.txtAtStartPoints.Size = new System.Drawing.Size(114, 20);
			this.txtAtStartPoints.TabIndex = 29;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(725, 87);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(71, 13);
			this.label9.TabIndex = 32;
			this.label9.Text = "At End Points";
			// 
			// txtAtEndPoints
			// 
			this.txtAtEndPoints.Location = new System.Drawing.Point(725, 103);
			this.txtAtEndPoints.Name = "txtAtEndPoints";
			this.txtAtEndPoints.Size = new System.Drawing.Size(122, 20);
			this.txtAtEndPoints.TabIndex = 31;
			// 
			// fmParser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(857, 580);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtAtEndPoints);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtAtStartPoints);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtPointsPerHour);
			this.Controls.Add(this.dtRaidDate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtRaidName);
			this.Controls.Add(this.label6);
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
		public System.Windows.Forms.DateTimePicker dtRaidDate;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox txtRaidName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.TextBox txtPointsPerHour;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.TextBox txtAtStartPoints;
		private System.Windows.Forms.Label label9;
		public System.Windows.Forms.TextBox txtAtEndPoints;


	}
}

