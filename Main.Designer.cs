﻿// This file is part of iRacingReplayOverlay.
//
// Copyright 2014 Dean Netherton
// https://github.com/vipoo/iRacingReplayOverlay.net
//
// iRacingReplayOverlay is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// iRacingReplayOverlay is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with iRacingReplayOverlay.  If not, see <http://www.gnu.org/licenses/>.

namespace iRacingReplayOverlay
{
    partial class Main
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
            this.SettingsButton = new System.Windows.Forms.Button();
            this.configureGeneralSettingsButton = new System.Windows.Forms.Button();
            this.logMessagesButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCapture = new System.Windows.Forms.TabPage();
            this.EncodeVideoAfterCapture = new System.Windows.Forms.CheckBox();
            this.verifyVideoCaptureButton = new System.Windows.Forms.Button();
            this.configureTrackCamerasLabel = new System.Windows.Forms.Label();
            this.TestOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.WaitingForIRacingLabel = new System.Windows.Forms.Label();
            this.ProcessErrorMessageLabel = new System.Windows.Forms.Label();
            this.CapturingRaceLabel = new System.Windows.Forms.Label();
            this.AnalysingRaceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BeginProcessButton = new System.Windows.Forms.Button();
            this.workingFolderButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.workingFolderTextBox = new System.Windows.Forms.TextBox();
            this.tabTranscoding = new System.Windows.Forms.TabPage();
            this.transcodeProgressBar = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.highlightVideoOnly = new System.Windows.Forms.CheckBox();
            this.VideoDetailLabel = new System.Windows.Forms.Label();
            this.videoBitRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sourceVideoButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sourceVideoTextBox = new System.Windows.Forms.TextBox();
            this.transcodeCancelButton = new System.Windows.Forms.Button();
            this.transcodeVideoButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.changeVersionButton = new System.Windows.Forms.Button();
            this.configurePluginsButton = new System.Windows.Forms.Button();
            this.newVersionMessage = new System.Windows.Forms.Label();
            this.buttonTestNewSettingsDlg = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCapture.SuspendLayout();
            this.tabTranscoding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(200, 13);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(181, 27);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "Configure Track Cameras";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // configureGeneralSettingsButton
            // 
            this.configureGeneralSettingsButton.Location = new System.Drawing.Point(13, 13);
            this.configureGeneralSettingsButton.Name = "configureGeneralSettingsButton";
            this.configureGeneralSettingsButton.Size = new System.Drawing.Size(181, 27);
            this.configureGeneralSettingsButton.TabIndex = 1;
            this.configureGeneralSettingsButton.Text = "Configure General Settings";
            this.configureGeneralSettingsButton.UseVisualStyleBackColor = true;
            this.configureGeneralSettingsButton.Click += new System.EventHandler(this.configureVideoCaptureButton_Click);
            // 
            // logMessagesButton
            // 
            this.logMessagesButton.Location = new System.Drawing.Point(563, 13);
            this.logMessagesButton.Name = "logMessagesButton";
            this.logMessagesButton.Size = new System.Drawing.Size(112, 27);
            this.logMessagesButton.TabIndex = 3;
            this.logMessagesButton.Text = "Log Messages";
            this.logMessagesButton.UseVisualStyleBackColor = true;
            this.logMessagesButton.Click += new System.EventHandler(this.logMessagesButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabCapture);
            this.tabControl1.Controls.Add(this.tabTranscoding);
            this.tabControl1.Location = new System.Drawing.Point(13, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 339);
            this.tabControl1.TabIndex = 5;
            // 
            // tabCapture
            // 
            this.tabCapture.Controls.Add(this.EncodeVideoAfterCapture);
            this.tabCapture.Controls.Add(this.verifyVideoCaptureButton);
            this.tabCapture.Controls.Add(this.configureTrackCamerasLabel);
            this.tabCapture.Controls.Add(this.TestOnlyCheckBox);
            this.tabCapture.Controls.Add(this.WaitingForIRacingLabel);
            this.tabCapture.Controls.Add(this.ProcessErrorMessageLabel);
            this.tabCapture.Controls.Add(this.CapturingRaceLabel);
            this.tabCapture.Controls.Add(this.AnalysingRaceLabel);
            this.tabCapture.Controls.Add(this.label2);
            this.tabCapture.Controls.Add(this.BeginProcessButton);
            this.tabCapture.Controls.Add(this.workingFolderButton);
            this.tabCapture.Controls.Add(this.label5);
            this.tabCapture.Controls.Add(this.workingFolderTextBox);
            this.tabCapture.Location = new System.Drawing.Point(4, 31);
            this.tabCapture.Name = "tabCapture";
            this.tabCapture.Padding = new System.Windows.Forms.Padding(3);
            this.tabCapture.Size = new System.Drawing.Size(746, 304);
            this.tabCapture.TabIndex = 0;
            this.tabCapture.Text = "Race Capture";
            this.tabCapture.UseVisualStyleBackColor = true;
            // 
            // EncodeVideoAfterCapture
            // 
            this.EncodeVideoAfterCapture.AutoSize = true;
            this.EncodeVideoAfterCapture.Location = new System.Drawing.Point(300, 18);
            this.EncodeVideoAfterCapture.Name = "EncodeVideoAfterCapture";
            this.EncodeVideoAfterCapture.Size = new System.Drawing.Size(207, 23);
            this.EncodeVideoAfterCapture.TabIndex = 8;
            this.EncodeVideoAfterCapture.Text = "Encode Video After Capture";
            this.EncodeVideoAfterCapture.UseVisualStyleBackColor = true;
            // 
            // verifyVideoCaptureButton
            // 
            this.verifyVideoCaptureButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyVideoCaptureButton.Location = new System.Drawing.Point(586, 132);
            this.verifyVideoCaptureButton.Margin = new System.Windows.Forms.Padding(4);
            this.verifyVideoCaptureButton.Name = "verifyVideoCaptureButton";
            this.verifyVideoCaptureButton.Size = new System.Drawing.Size(153, 30);
            this.verifyVideoCaptureButton.TabIndex = 17;
            this.verifyVideoCaptureButton.Text = "Verify Video Capture";
            this.verifyVideoCaptureButton.UseVisualStyleBackColor = true;
            this.verifyVideoCaptureButton.Click += new System.EventHandler(this.verifyVideoCaptureButton_Click);
            // 
            // configureTrackCamerasLabel
            // 
            this.configureTrackCamerasLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configureTrackCamerasLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.configureTrackCamerasLabel.Location = new System.Drawing.Point(174, 48);
            this.configureTrackCamerasLabel.Name = "configureTrackCamerasLabel";
            this.configureTrackCamerasLabel.Size = new System.Drawing.Size(279, 30);
            this.configureTrackCamerasLabel.TabIndex = 9;
            this.configureTrackCamerasLabel.Text = "You need to configure the Track Cameras before you can begin to capture this race" +
    ".";
            this.configureTrackCamerasLabel.Visible = false;
            // 
            // TestOnlyCheckBox
            // 
            this.TestOnlyCheckBox.AutoSize = true;
            this.TestOnlyCheckBox.Location = new System.Drawing.Point(174, 18);
            this.TestOnlyCheckBox.Name = "TestOnlyCheckBox";
            this.TestOnlyCheckBox.Size = new System.Drawing.Size(126, 23);
            this.TestOnlyCheckBox.TabIndex = 7;
            this.TestOnlyCheckBox.Text = "Short Test Only";
            this.TestOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // WaitingForIRacingLabel
            // 
            this.WaitingForIRacingLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.WaitingForIRacingLabel.Location = new System.Drawing.Point(174, 44);
            this.WaitingForIRacingLabel.Name = "WaitingForIRacingLabel";
            this.WaitingForIRacingLabel.Size = new System.Drawing.Size(547, 41);
            this.WaitingForIRacingLabel.TabIndex = 11;
            this.WaitingForIRacingLabel.Text = "Waiting for iRacing to start ...";
            // 
            // ProcessErrorMessageLabel
            // 
            this.ProcessErrorMessageLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ProcessErrorMessageLabel.Location = new System.Drawing.Point(174, 44);
            this.ProcessErrorMessageLabel.Name = "ProcessErrorMessageLabel";
            this.ProcessErrorMessageLabel.Size = new System.Drawing.Size(547, 50);
            this.ProcessErrorMessageLabel.TabIndex = 10;
            this.ProcessErrorMessageLabel.Text = "Error ...";
            this.ProcessErrorMessageLabel.Visible = false;
            // 
            // CapturingRaceLabel
            // 
            this.CapturingRaceLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.CapturingRaceLabel.Location = new System.Drawing.Point(174, 48);
            this.CapturingRaceLabel.Name = "CapturingRaceLabel";
            this.CapturingRaceLabel.Size = new System.Drawing.Size(406, 50);
            this.CapturingRaceLabel.TabIndex = 12;
            this.CapturingRaceLabel.Text = "Capturing your replay to video ...";
            this.CapturingRaceLabel.Visible = false;
            // 
            // AnalysingRaceLabel
            // 
            this.AnalysingRaceLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.AnalysingRaceLabel.Location = new System.Drawing.Point(174, 44);
            this.AnalysingRaceLabel.Name = "AnalysingRaceLabel";
            this.AnalysingRaceLabel.Size = new System.Drawing.Size(406, 50);
            this.AnalysingRaceLabel.TabIndex = 13;
            this.AnalysingRaceLabel.Text = "Analysing your race replay ...";
            this.AnalysingRaceLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(594, 55);
            this.label2.TabIndex = 18;
            this.label2.Text = "Load iRacing with your race replay. You may need to press the space bar to remove" +
    " the iRacing overlay.";
            // 
            // BeginProcessButton
            // 
            this.BeginProcessButton.Enabled = false;
            this.BeginProcessButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginProcessButton.Location = new System.Drawing.Point(4, 18);
            this.BeginProcessButton.Margin = new System.Windows.Forms.Padding(4);
            this.BeginProcessButton.Name = "BeginProcessButton";
            this.BeginProcessButton.Size = new System.Drawing.Size(163, 68);
            this.BeginProcessButton.TabIndex = 6;
            this.BeginProcessButton.Text = "Begin Capture";
            this.BeginProcessButton.UseVisualStyleBackColor = true;
            this.BeginProcessButton.Click += new System.EventHandler(this.BeginProcessButton_Click);
            // 
            // workingFolderButton
            // 
            this.workingFolderButton.Location = new System.Drawing.Point(516, 132);
            this.workingFolderButton.Name = "workingFolderButton";
            this.workingFolderButton.Size = new System.Drawing.Size(64, 30);
            this.workingFolderButton.TabIndex = 16;
            this.workingFolderButton.Text = "browse";
            this.workingFolderButton.UseVisualStyleBackColor = true;
            this.workingFolderButton.Click += new System.EventHandler(this.workingFolderButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Video Capture Folder:";
            // 
            // workingFolderTextBox
            // 
            this.workingFolderTextBox.Location = new System.Drawing.Point(156, 134);
            this.workingFolderTextBox.Name = "workingFolderTextBox";
            this.workingFolderTextBox.Size = new System.Drawing.Size(355, 27);
            this.workingFolderTextBox.TabIndex = 15;
            this.workingFolderTextBox.TextChanged += new System.EventHandler(this.workingFolderTextBox_TextChanged);
            // 
            // tabTranscoding
            // 
            this.tabTranscoding.Controls.Add(this.transcodeProgressBar);
            this.tabTranscoding.Controls.Add(this.button2);
            this.tabTranscoding.Controls.Add(this.highlightVideoOnly);
            this.tabTranscoding.Controls.Add(this.VideoDetailLabel);
            this.tabTranscoding.Controls.Add(this.videoBitRate);
            this.tabTranscoding.Controls.Add(this.label1);
            this.tabTranscoding.Controls.Add(this.sourceVideoButton);
            this.tabTranscoding.Controls.Add(this.label3);
            this.tabTranscoding.Controls.Add(this.sourceVideoTextBox);
            this.tabTranscoding.Controls.Add(this.transcodeCancelButton);
            this.tabTranscoding.Controls.Add(this.transcodeVideoButton);
            this.tabTranscoding.Location = new System.Drawing.Point(4, 31);
            this.tabTranscoding.Name = "tabTranscoding";
            this.tabTranscoding.Padding = new System.Windows.Forms.Padding(3);
            this.tabTranscoding.Size = new System.Drawing.Size(746, 304);
            this.tabTranscoding.TabIndex = 1;
            this.tabTranscoding.Text = "Video Encoding";
            this.tabTranscoding.UseVisualStyleBackColor = true;
            // 
            // transcodeProgressBar
            // 
            this.transcodeProgressBar.Location = new System.Drawing.Point(23, 260);
            this.transcodeProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.transcodeProgressBar.Maximum = 10000;
            this.transcodeProgressBar.Name = "transcodeProgressBar";
            this.transcodeProgressBar.Size = new System.Drawing.Size(700, 34);
            this.transcodeProgressBar.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(585, 166);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 30);
            this.button2.TabIndex = 29;
            this.button2.Text = "Verify Video Conversion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // highlightVideoOnly
            // 
            this.highlightVideoOnly.AutoSize = true;
            this.highlightVideoOnly.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.highlightVideoOnly.Checked = true;
            this.highlightVideoOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.highlightVideoOnly.Location = new System.Drawing.Point(429, 55);
            this.highlightVideoOnly.Name = "highlightVideoOnly";
            this.highlightVideoOnly.Size = new System.Drawing.Size(162, 23);
            this.highlightVideoOnly.TabIndex = 25;
            this.highlightVideoOnly.Text = "Highlight Video Only";
            this.highlightVideoOnly.UseVisualStyleBackColor = true;
            // 
            // VideoDetailLabel
            // 
            this.VideoDetailLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.VideoDetailLabel.Location = new System.Drawing.Point(7, 166);
            this.VideoDetailLabel.Name = "VideoDetailLabel";
            this.VideoDetailLabel.Size = new System.Drawing.Size(580, 128);
            this.VideoDetailLabel.TabIndex = 40;
            // 
            // videoBitRate
            // 
            this.videoBitRate.Location = new System.Drawing.Point(565, 21);
            this.videoBitRate.Name = "videoBitRate";
            this.videoBitRate.Size = new System.Drawing.Size(43, 27);
            this.videoBitRate.TabIndex = 22;
            this.videoBitRate.Text = "15";
            this.videoBitRate.TextChanged += new System.EventHandler(this.videoBitRate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Video Bitrate (Mbs):";
            // 
            // sourceVideoButton
            // 
            this.sourceVideoButton.Location = new System.Drawing.Point(674, 134);
            this.sourceVideoButton.Name = "sourceVideoButton";
            this.sourceVideoButton.Size = new System.Drawing.Size(64, 27);
            this.sourceVideoButton.TabIndex = 28;
            this.sourceVideoButton.Text = "browse";
            this.sourceVideoButton.UseVisualStyleBackColor = true;
            this.sourceVideoButton.Click += new System.EventHandler(this.sourceVideoButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Replay Capture:";
            // 
            // sourceVideoTextBox
            // 
            this.sourceVideoTextBox.Location = new System.Drawing.Point(116, 135);
            this.sourceVideoTextBox.Name = "sourceVideoTextBox";
            this.sourceVideoTextBox.Size = new System.Drawing.Size(552, 27);
            this.sourceVideoTextBox.TabIndex = 27;
            this.sourceVideoTextBox.TextChanged += new System.EventHandler(this.sourceVideoTextBox_TextChanged);
            // 
            // transcodeCancelButton
            // 
            this.transcodeCancelButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transcodeCancelButton.Location = new System.Drawing.Point(175, 21);
            this.transcodeCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.transcodeCancelButton.Name = "transcodeCancelButton";
            this.transcodeCancelButton.Size = new System.Drawing.Size(163, 68);
            this.transcodeCancelButton.TabIndex = 20;
            this.transcodeCancelButton.Text = "Cancel Transcoding";
            this.transcodeCancelButton.UseVisualStyleBackColor = true;
            this.transcodeCancelButton.Visible = false;
            this.transcodeCancelButton.Click += new System.EventHandler(this.transcodeCancel_Click);
            // 
            // transcodeVideoButton
            // 
            this.transcodeVideoButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transcodeVideoButton.Location = new System.Drawing.Point(4, 21);
            this.transcodeVideoButton.Margin = new System.Windows.Forms.Padding(4);
            this.transcodeVideoButton.Name = "transcodeVideoButton";
            this.transcodeVideoButton.Size = new System.Drawing.Size(163, 68);
            this.transcodeVideoButton.TabIndex = 19;
            this.transcodeVideoButton.Text = "Transcode Video";
            this.transcodeVideoButton.UseVisualStyleBackColor = true;
            this.transcodeVideoButton.Click += new System.EventHandler(this.TranscodeVideo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(17, 115);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(745, 5);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "About ...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // changeVersionButton
            // 
            this.changeVersionButton.Location = new System.Drawing.Point(631, 46);
            this.changeVersionButton.Name = "changeVersionButton";
            this.changeVersionButton.Size = new System.Drawing.Size(136, 27);
            this.changeVersionButton.TabIndex = 37;
            this.changeVersionButton.Text = "Change Version ...";
            this.changeVersionButton.UseVisualStyleBackColor = true;
            this.changeVersionButton.Click += new System.EventHandler(this.changeVersionButton_Click);
            // 
            // configurePluginsButton
            // 
            this.configurePluginsButton.Location = new System.Drawing.Point(387, 13);
            this.configurePluginsButton.Name = "configurePluginsButton";
            this.configurePluginsButton.Size = new System.Drawing.Size(128, 27);
            this.configurePluginsButton.TabIndex = 38;
            this.configurePluginsButton.Text = "Configure Plugins";
            this.configurePluginsButton.UseVisualStyleBackColor = true;
            this.configurePluginsButton.Visible = false;
            this.configurePluginsButton.Click += new System.EventHandler(this.configurePluginsButton_Click);
            // 
            // newVersionMessage
            // 
            this.newVersionMessage.AutoSize = true;
            this.newVersionMessage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newVersionMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.newVersionMessage.Location = new System.Drawing.Point(466, 51);
            this.newVersionMessage.Name = "newVersionMessage";
            this.newVersionMessage.Size = new System.Drawing.Size(161, 18);
            this.newVersionMessage.TabIndex = 39;
            this.newVersionMessage.Text = "New Version available ->";
            this.newVersionMessage.Visible = false;
            // 
            // buttonTestNewSettingsDlg
            // 
            this.buttonTestNewSettingsDlg.Location = new System.Drawing.Point(12, 42);
            this.buttonTestNewSettingsDlg.Name = "buttonTestNewSettingsDlg";
            this.buttonTestNewSettingsDlg.Size = new System.Drawing.Size(267, 27);
            this.buttonTestNewSettingsDlg.TabIndex = 1;
            this.buttonTestNewSettingsDlg.Text = "Configure General (no effect on settings)";
            this.buttonTestNewSettingsDlg.UseVisualStyleBackColor = true;
            this.buttonTestNewSettingsDlg.Click += new System.EventHandler(this.configureVideoCaptureButton_Click_Test);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 424);
            this.Controls.Add(this.newVersionMessage);
            this.Controls.Add(this.configurePluginsButton);
            this.Controls.Add(this.changeVersionButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.logMessagesButton);
            this.Controls.Add(this.buttonTestNewSettingsDlg);
            this.Controls.Add(this.configureGeneralSettingsButton);
            this.Controls.Add(this.SettingsButton);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "iRacing Replay Director";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCapture.ResumeLayout(false);
            this.tabCapture.PerformLayout();
            this.tabTranscoding.ResumeLayout(false);
            this.tabTranscoding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button configureGeneralSettingsButton;
        private System.Windows.Forms.Button logMessagesButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCapture;
        private System.Windows.Forms.CheckBox TestOnlyCheckBox;
        private System.Windows.Forms.Label WaitingForIRacingLabel;
        private System.Windows.Forms.Label ProcessErrorMessageLabel;
        private System.Windows.Forms.Label CapturingRaceLabel;
        private System.Windows.Forms.Label AnalysingRaceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BeginProcessButton;
        private System.Windows.Forms.Button workingFolderButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox workingFolderTextBox;
        private System.Windows.Forms.TabPage tabTranscoding;
        private System.Windows.Forms.Label VideoDetailLabel;
        private System.Windows.Forms.TextBox videoBitRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sourceVideoButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sourceVideoTextBox;
        private System.Windows.Forms.Button transcodeCancelButton;
        private System.Windows.Forms.ProgressBar transcodeProgressBar;
        private System.Windows.Forms.Button transcodeVideoButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox highlightVideoOnly;
        private System.Windows.Forms.Label configureTrackCamerasLabel;
        private System.Windows.Forms.Button verifyVideoCaptureButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox EncodeVideoAfterCapture;
        private System.Windows.Forms.Button changeVersionButton;
        private System.Windows.Forms.Button configurePluginsButton;
        private System.Windows.Forms.Label newVersionMessage;
        private System.Windows.Forms.Button buttonTestNewSettingsDlg;
    }
}