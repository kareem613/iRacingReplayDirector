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
            this.transcodeVideoButton = new System.Windows.Forms.Button();
            this.transcodeProgressBar = new System.Windows.Forms.ProgressBar();
            this.transcodeCancelButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sourceVideoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.workingFolderTextBox = new System.Windows.Forms.TextBox();
            this.sourceVideoButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.workingFolderButton = new System.Windows.Forms.Button();
            this.errorSourceVideoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.videoBitRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.audioBitRate = new System.Windows.Forms.ComboBox();
            this.BeginProcessButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AnalysingRaceLabel = new System.Windows.Forms.Label();
            this.CapturingRaceLabel = new System.Windows.Forms.Label();
            this.ProcessErrorMessageLabel = new System.Windows.Forms.Label();
            this.WaitingForIRacingLabel = new System.Windows.Forms.Label();
            this.VideoDetailLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.configureVideoCaptureButton = new System.Windows.Forms.Button();
            this.logMessagesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // transcodeVideoButton
            // 
            this.transcodeVideoButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transcodeVideoButton.Location = new System.Drawing.Point(28, 288);
            this.transcodeVideoButton.Margin = new System.Windows.Forms.Padding(4);
            this.transcodeVideoButton.Name = "transcodeVideoButton";
            this.transcodeVideoButton.Size = new System.Drawing.Size(163, 64);
            this.transcodeVideoButton.TabIndex = 0;
            this.transcodeVideoButton.Text = "Transcode Video";
            this.transcodeVideoButton.UseVisualStyleBackColor = true;
            this.transcodeVideoButton.Click += new System.EventHandler(this.TranscodeVideo_Click);
            // 
            // transcodeProgressBar
            // 
            this.transcodeProgressBar.Location = new System.Drawing.Point(47, 481);
            this.transcodeProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.transcodeProgressBar.Maximum = 10000;
            this.transcodeProgressBar.Name = "transcodeProgressBar";
            this.transcodeProgressBar.Size = new System.Drawing.Size(611, 32);
            this.transcodeProgressBar.TabIndex = 3;
            // 
            // transcodeCancelButton
            // 
            this.transcodeCancelButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transcodeCancelButton.Location = new System.Drawing.Point(199, 288);
            this.transcodeCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.transcodeCancelButton.Name = "transcodeCancelButton";
            this.transcodeCancelButton.Size = new System.Drawing.Size(163, 64);
            this.transcodeCancelButton.TabIndex = 4;
            this.transcodeCancelButton.Text = "Cancel Transcoding";
            this.transcodeCancelButton.UseVisualStyleBackColor = true;
            this.transcodeCancelButton.Visible = false;
            this.transcodeCancelButton.Click += new System.EventHandler(this.transcodeCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(13, 259);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 4);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // sourceVideoTextBox
            // 
            this.sourceVideoTextBox.Location = new System.Drawing.Point(158, 377);
            this.sourceVideoTextBox.Name = "sourceVideoTextBox";
            this.sourceVideoTextBox.Size = new System.Drawing.Size(464, 26);
            this.sourceVideoTextBox.TabIndex = 7;
            this.sourceVideoTextBox.TextChanged += new System.EventHandler(this.sourceVideoTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Source Video:";
            // 
            // workingFolderTextBox
            // 
            this.workingFolderTextBox.Location = new System.Drawing.Point(134, 80);
            this.workingFolderTextBox.Name = "workingFolderTextBox";
            this.workingFolderTextBox.Size = new System.Drawing.Size(488, 26);
            this.workingFolderTextBox.TabIndex = 13;
            // 
            // sourceVideoButton
            // 
            this.sourceVideoButton.Location = new System.Drawing.Point(628, 377);
            this.sourceVideoButton.Name = "sourceVideoButton";
            this.sourceVideoButton.Size = new System.Drawing.Size(64, 26);
            this.sourceVideoButton.TabIndex = 9;
            this.sourceVideoButton.Text = "browse";
            this.sourceVideoButton.UseVisualStyleBackColor = true;
            this.sourceVideoButton.Click += new System.EventHandler(this.sourceVideoButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Worker Folder:";
            // 
            // workingFolderButton
            // 
            this.workingFolderButton.Location = new System.Drawing.Point(628, 80);
            this.workingFolderButton.Name = "workingFolderButton";
            this.workingFolderButton.Size = new System.Drawing.Size(64, 26);
            this.workingFolderButton.TabIndex = 15;
            this.workingFolderButton.Text = "browse";
            this.workingFolderButton.UseVisualStyleBackColor = true;
            this.workingFolderButton.Click += new System.EventHandler(this.workingFolderButton_Click);
            // 
            // errorSourceVideoLabel
            // 
            this.errorSourceVideoLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorSourceVideoLabel.Location = new System.Drawing.Point(155, 431);
            this.errorSourceVideoLabel.Name = "errorSourceVideoLabel";
            this.errorSourceVideoLabel.Size = new System.Drawing.Size(467, 41);
            this.errorSourceVideoLabel.TabIndex = 16;
            this.errorSourceVideoLabel.Text = "*Unable to transcode this video, as there is no associated captured game data (cs" +
    "v file name based on the name of the source input video)";
            this.errorSourceVideoLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Video Bitrate (Mbs):";
            // 
            // videoBitRate
            // 
            this.videoBitRate.Location = new System.Drawing.Point(519, 288);
            this.videoBitRate.Name = "videoBitRate";
            this.videoBitRate.Size = new System.Drawing.Size(43, 26);
            this.videoBitRate.TabIndex = 18;
            this.videoBitRate.Text = "15";
            this.videoBitRate.TextChanged += new System.EventHandler(this.videoBitRate_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Audio Bitrate Kbps";
            // 
            // audioBitRate
            // 
            this.audioBitRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audioBitRate.FormattingEnabled = true;
            this.audioBitRate.Location = new System.Drawing.Point(519, 320);
            this.audioBitRate.Name = "audioBitRate";
            this.audioBitRate.Size = new System.Drawing.Size(173, 26);
            this.audioBitRate.TabIndex = 20;
            // 
            // BeginProcessButton
            // 
            this.BeginProcessButton.Enabled = false;
            this.BeginProcessButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginProcessButton.Location = new System.Drawing.Point(31, 171);
            this.BeginProcessButton.Margin = new System.Windows.Forms.Padding(4);
            this.BeginProcessButton.Name = "BeginProcessButton";
            this.BeginProcessButton.Size = new System.Drawing.Size(163, 64);
            this.BeginProcessButton.TabIndex = 21;
            this.BeginProcessButton.Text = "Begin Capture";
            this.BeginProcessButton.UseVisualStyleBackColor = true;
            this.BeginProcessButton.Click += new System.EventHandler(this.BeginProcessButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(594, 52);
            this.label2.TabIndex = 22;
            this.label2.Text = "Load iRacing with your race replay. You may need to press the space bar to remove" +
    " the iRacing overlay.";
            // 
            // AnalysingRaceLabel
            // 
            this.AnalysingRaceLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.AnalysingRaceLabel.Location = new System.Drawing.Point(216, 171);
            this.AnalysingRaceLabel.Name = "AnalysingRaceLabel";
            this.AnalysingRaceLabel.Size = new System.Drawing.Size(323, 64);
            this.AnalysingRaceLabel.TabIndex = 24;
            this.AnalysingRaceLabel.Text = "Analysing your race replay ...";
            this.AnalysingRaceLabel.Visible = false;
            // 
            // CapturingRaceLabel
            // 
            this.CapturingRaceLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.CapturingRaceLabel.Location = new System.Drawing.Point(216, 171);
            this.CapturingRaceLabel.Name = "CapturingRaceLabel";
            this.CapturingRaceLabel.Size = new System.Drawing.Size(323, 64);
            this.CapturingRaceLabel.TabIndex = 25;
            this.CapturingRaceLabel.Text = "Capturing your replay to video ...";
            this.CapturingRaceLabel.Visible = false;
            // 
            // ProcessErrorMessageLabel
            // 
            this.ProcessErrorMessageLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ProcessErrorMessageLabel.Location = new System.Drawing.Point(216, 171);
            this.ProcessErrorMessageLabel.Name = "ProcessErrorMessageLabel";
            this.ProcessErrorMessageLabel.Size = new System.Drawing.Size(467, 47);
            this.ProcessErrorMessageLabel.TabIndex = 26;
            this.ProcessErrorMessageLabel.Text = "Error ...";
            this.ProcessErrorMessageLabel.Visible = false;
            // 
            // WaitingForIRacingLabel
            // 
            this.WaitingForIRacingLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.WaitingForIRacingLabel.Location = new System.Drawing.Point(216, 171);
            this.WaitingForIRacingLabel.Name = "WaitingForIRacingLabel";
            this.WaitingForIRacingLabel.Size = new System.Drawing.Size(323, 64);
            this.WaitingForIRacingLabel.TabIndex = 27;
            this.WaitingForIRacingLabel.Text = "Waiting for iRacing to start ...";
            // 
            // VideoDetailLabel
            // 
            this.VideoDetailLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.VideoDetailLabel.Location = new System.Drawing.Point(158, 406);
            this.VideoDetailLabel.Name = "VideoDetailLabel";
            this.VideoDetailLabel.Size = new System.Drawing.Size(464, 21);
            this.VideoDetailLabel.TabIndex = 28;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(13, 59);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(680, 4);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(210, 12);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(181, 26);
            this.SettingsButton.TabIndex = 30;
            this.SettingsButton.Text = "Configure Track Cameras";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // configureVideoCaptureButton
            // 
            this.configureVideoCaptureButton.Location = new System.Drawing.Point(13, 12);
            this.configureVideoCaptureButton.Name = "configureVideoCaptureButton";
            this.configureVideoCaptureButton.Size = new System.Drawing.Size(181, 26);
            this.configureVideoCaptureButton.TabIndex = 31;
            this.configureVideoCaptureButton.Text = "Configure Video Capture";
            this.configureVideoCaptureButton.UseVisualStyleBackColor = true;
            this.configureVideoCaptureButton.Click += new System.EventHandler(this.configureVideoCaptureButton_Click);
            // 
            // logMessagesButton
            // 
            this.logMessagesButton.Location = new System.Drawing.Point(512, 12);
            this.logMessagesButton.Name = "logMessagesButton";
            this.logMessagesButton.Size = new System.Drawing.Size(181, 26);
            this.logMessagesButton.TabIndex = 32;
            this.logMessagesButton.Text = "Log Messages";
            this.logMessagesButton.UseVisualStyleBackColor = true;
            this.logMessagesButton.Click += new System.EventHandler(this.logMessagesButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 535);
            this.Controls.Add(this.logMessagesButton);
            this.Controls.Add(this.configureVideoCaptureButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.VideoDetailLabel);
            this.Controls.Add(this.WaitingForIRacingLabel);
            this.Controls.Add(this.ProcessErrorMessageLabel);
            this.Controls.Add(this.CapturingRaceLabel);
            this.Controls.Add(this.AnalysingRaceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BeginProcessButton);
            this.Controls.Add(this.audioBitRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.videoBitRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorSourceVideoLabel);
            this.Controls.Add(this.workingFolderButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.workingFolderTextBox);
            this.Controls.Add(this.sourceVideoButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sourceVideoTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.transcodeCancelButton);
            this.Controls.Add(this.transcodeProgressBar);
            this.Controls.Add(this.transcodeVideoButton);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transcodeVideoButton;
        private System.Windows.Forms.ProgressBar transcodeProgressBar;
        private System.Windows.Forms.Button transcodeCancelButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox sourceVideoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox workingFolderTextBox;
        private System.Windows.Forms.Button sourceVideoButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button workingFolderButton;
        private System.Windows.Forms.Label errorSourceVideoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox videoBitRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox audioBitRate;
        private System.Windows.Forms.Button BeginProcessButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AnalysingRaceLabel;
        private System.Windows.Forms.Label CapturingRaceLabel;
        private System.Windows.Forms.Label ProcessErrorMessageLabel;
        private System.Windows.Forms.Label WaitingForIRacingLabel;
        private System.Windows.Forms.Label VideoDetailLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button configureVideoCaptureButton;
        private System.Windows.Forms.Button logMessagesButton;
    }
}