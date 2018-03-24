namespace CustomDiscordRPC
{
    partial class Controls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controls));
            this.StatusLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ShutdownButton = new System.Windows.Forms.Button();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.DetailText = new System.Windows.Forms.TextBox();
            this.DetailLabel = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.TextBox();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.TextBox();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.LargeImageKey = new System.Windows.Forms.TextBox();
            this.LargeImageKeyLabel = new System.Windows.Forms.Label();
            this.LargeImageTextLabel = new System.Windows.Forms.Label();
            this.LargeImageText = new System.Windows.Forms.TextBox();
            this.SmallImageText = new System.Windows.Forms.TextBox();
            this.SmallImageTextLabel = new System.Windows.Forms.Label();
            this.SmallImageKey = new System.Windows.Forms.TextBox();
            this.SmallImageKeyLabel = new System.Windows.Forms.Label();
            this.MainDetailsLabel = new System.Windows.Forms.Label();
            this.TimeDetailsLabel = new System.Windows.Forms.Label();
            this.ImageDetailsLabel = new System.Windows.Forms.Label();
            this.TimestampNow = new System.Windows.Forms.Button();
            this.Timestamp1H = new System.Windows.Forms.Button();
            this.Timestamp30M = new System.Windows.Forms.Button();
            this.Timestamp15M = new System.Windows.Forms.Button();
            this.Timestamp5M = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.Location = new System.Drawing.Point(15, 37);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StatusLabel.Size = new System.Drawing.Size(48, 16);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Status:";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(14, 288);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(247, 34);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Update Status";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ShutdownButton
            // 
            this.ShutdownButton.Location = new System.Drawing.Point(272, 288);
            this.ShutdownButton.Name = "ShutdownButton";
            this.ShutdownButton.Size = new System.Drawing.Size(247, 34);
            this.ShutdownButton.TabIndex = 10;
            this.ShutdownButton.Text = "Shutdown";
            this.ShutdownButton.UseVisualStyleBackColor = true;
            this.ShutdownButton.Click += new System.EventHandler(this.ShutdownButton_Click);
            // 
            // StatusText
            // 
            this.StatusText.Location = new System.Drawing.Point(66, 34);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(453, 22);
            this.StatusText.TabIndex = 1;
            this.StatusText.TextChanged += new System.EventHandler(this.StatusText_TextChanged);
            // 
            // DetailText
            // 
            this.DetailText.Location = new System.Drawing.Point(66, 62);
            this.DetailText.Name = "DetailText";
            this.DetailText.Size = new System.Drawing.Size(453, 22);
            this.DetailText.TabIndex = 2;
            this.DetailText.TextChanged += new System.EventHandler(this.DetailText_TextChanged);
            // 
            // DetailLabel
            // 
            this.DetailLabel.Location = new System.Drawing.Point(15, 65);
            this.DetailLabel.Name = "DetailLabel";
            this.DetailLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DetailLabel.Size = new System.Drawing.Size(48, 16);
            this.DetailLabel.TabIndex = 4;
            this.DetailLabel.Text = "Detail:";
            this.DetailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StartTime
            // 
            this.StartTime.Location = new System.Drawing.Point(66, 123);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(377, 22);
            this.StartTime.TabIndex = 3;
            this.StartTime.TextChanged += new System.EventHandler(this.StartTime_TextChanged);
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.Location = new System.Drawing.Point(15, 126);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartTimeLabel.Size = new System.Drawing.Size(48, 16);
            this.StartTimeLabel.TabIndex = 6;
            this.StartTimeLabel.Text = "Start:";
            this.StartTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EndTime
            // 
            this.EndTime.Location = new System.Drawing.Point(66, 151);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(256, 22);
            this.EndTime.TabIndex = 4;
            this.EndTime.TextChanged += new System.EventHandler(this.EndTime_TextChanged);
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.Location = new System.Drawing.Point(15, 154);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EndTimeLabel.Size = new System.Drawing.Size(48, 16);
            this.EndTimeLabel.TabIndex = 8;
            this.EndTimeLabel.Text = "End:";
            this.EndTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LargeImageKey
            // 
            this.LargeImageKey.Location = new System.Drawing.Point(84, 226);
            this.LargeImageKey.Name = "LargeImageKey";
            this.LargeImageKey.Size = new System.Drawing.Size(115, 22);
            this.LargeImageKey.TabIndex = 5;
            this.LargeImageKey.TextChanged += new System.EventHandler(this.LargeImageKey_TextChanged);
            // 
            // LargeImageKeyLabel
            // 
            this.LargeImageKeyLabel.Location = new System.Drawing.Point(11, 229);
            this.LargeImageKeyLabel.Name = "LargeImageKeyLabel";
            this.LargeImageKeyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LargeImageKeyLabel.Size = new System.Drawing.Size(72, 16);
            this.LargeImageKeyLabel.TabIndex = 10;
            this.LargeImageKeyLabel.Text = "Large Key:";
            this.LargeImageKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LargeImageTextLabel
            // 
            this.LargeImageTextLabel.Location = new System.Drawing.Point(211, 229);
            this.LargeImageTextLabel.Name = "LargeImageTextLabel";
            this.LargeImageTextLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LargeImageTextLabel.Size = new System.Drawing.Size(75, 16);
            this.LargeImageTextLabel.TabIndex = 12;
            this.LargeImageTextLabel.Text = "Large Text:";
            this.LargeImageTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LargeImageText
            // 
            this.LargeImageText.Location = new System.Drawing.Point(288, 226);
            this.LargeImageText.Name = "LargeImageText";
            this.LargeImageText.Size = new System.Drawing.Size(231, 22);
            this.LargeImageText.TabIndex = 6;
            this.LargeImageText.TextChanged += new System.EventHandler(this.LargeImageText_TextChanged);
            // 
            // SmallImageText
            // 
            this.SmallImageText.Location = new System.Drawing.Point(288, 254);
            this.SmallImageText.Name = "SmallImageText";
            this.SmallImageText.Size = new System.Drawing.Size(231, 22);
            this.SmallImageText.TabIndex = 8;
            this.SmallImageText.TextChanged += new System.EventHandler(this.SmallImageText_TextChanged);
            // 
            // SmallImageTextLabel
            // 
            this.SmallImageTextLabel.Location = new System.Drawing.Point(212, 257);
            this.SmallImageTextLabel.Name = "SmallImageTextLabel";
            this.SmallImageTextLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SmallImageTextLabel.Size = new System.Drawing.Size(74, 16);
            this.SmallImageTextLabel.TabIndex = 16;
            this.SmallImageTextLabel.Text = "Small Text:";
            this.SmallImageTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SmallImageKey
            // 
            this.SmallImageKey.Location = new System.Drawing.Point(84, 254);
            this.SmallImageKey.Name = "SmallImageKey";
            this.SmallImageKey.Size = new System.Drawing.Size(115, 22);
            this.SmallImageKey.TabIndex = 7;
            this.SmallImageKey.TextChanged += new System.EventHandler(this.SmallImageKey_TextChanged);
            // 
            // SmallImageKeyLabel
            // 
            this.SmallImageKeyLabel.Location = new System.Drawing.Point(12, 257);
            this.SmallImageKeyLabel.Name = "SmallImageKeyLabel";
            this.SmallImageKeyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SmallImageKeyLabel.Size = new System.Drawing.Size(71, 16);
            this.SmallImageKeyLabel.TabIndex = 14;
            this.SmallImageKeyLabel.Text = "Small Key:";
            this.SmallImageKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainDetailsLabel
            // 
            this.MainDetailsLabel.AutoSize = true;
            this.MainDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainDetailsLabel.Location = new System.Drawing.Point(11, 10);
            this.MainDetailsLabel.Name = "MainDetailsLabel";
            this.MainDetailsLabel.Size = new System.Drawing.Size(143, 16);
            this.MainDetailsLabel.TabIndex = 18;
            this.MainDetailsLabel.Text = "Main Presence Details";
            // 
            // TimeDetailsLabel
            // 
            this.TimeDetailsLabel.AutoSize = true;
            this.TimeDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeDetailsLabel.Location = new System.Drawing.Point(10, 100);
            this.TimeDetailsLabel.Name = "TimeDetailsLabel";
            this.TimeDetailsLabel.Size = new System.Drawing.Size(312, 16);
            this.TimeDetailsLabel.TabIndex = 19;
            this.TimeDetailsLabel.Text = "Time Presence Details (Leave blank to not display)";
            // 
            // ImageDetailsLabel
            // 
            this.ImageDetailsLabel.AutoSize = true;
            this.ImageDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageDetailsLabel.Location = new System.Drawing.Point(9, 205);
            this.ImageDetailsLabel.Name = "ImageDetailsLabel";
            this.ImageDetailsLabel.Size = new System.Drawing.Size(319, 16);
            this.ImageDetailsLabel.TabIndex = 20;
            this.ImageDetailsLabel.Text = "Image Presence Details (Leave blank to not display)";
            // 
            // TimestampNow
            // 
            this.TimestampNow.Location = new System.Drawing.Point(449, 122);
            this.TimestampNow.Name = "TimestampNow";
            this.TimestampNow.Size = new System.Drawing.Size(71, 24);
            this.TimestampNow.TabIndex = 21;
            this.TimestampNow.Text = "Now";
            this.TimestampNow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TimestampNow.UseVisualStyleBackColor = true;
            this.TimestampNow.Click += new System.EventHandler(this.TimestampNow_Click);
            // 
            // Timestamp1H
            // 
            this.Timestamp1H.Location = new System.Drawing.Point(481, 150);
            this.Timestamp1H.Name = "Timestamp1H";
            this.Timestamp1H.Size = new System.Drawing.Size(39, 24);
            this.Timestamp1H.TabIndex = 22;
            this.Timestamp1H.Text = "1h";
            this.Timestamp1H.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Timestamp1H.UseVisualStyleBackColor = true;
            this.Timestamp1H.Click += new System.EventHandler(this.Timestamp1H_Click);
            // 
            // Timestamp30M
            // 
            this.Timestamp30M.Location = new System.Drawing.Point(430, 150);
            this.Timestamp30M.Name = "Timestamp30M";
            this.Timestamp30M.Size = new System.Drawing.Size(46, 24);
            this.Timestamp30M.TabIndex = 23;
            this.Timestamp30M.Text = "30m";
            this.Timestamp30M.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Timestamp30M.UseVisualStyleBackColor = true;
            this.Timestamp30M.Click += new System.EventHandler(this.Timestamp30M_Click);
            // 
            // Timestamp15M
            // 
            this.Timestamp15M.Location = new System.Drawing.Point(379, 150);
            this.Timestamp15M.Name = "Timestamp15M";
            this.Timestamp15M.Size = new System.Drawing.Size(46, 24);
            this.Timestamp15M.TabIndex = 24;
            this.Timestamp15M.Text = "15m";
            this.Timestamp15M.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Timestamp15M.UseVisualStyleBackColor = true;
            this.Timestamp15M.Click += new System.EventHandler(this.Timestamp15M_Click);
            // 
            // Timestamp5M
            // 
            this.Timestamp5M.Location = new System.Drawing.Point(329, 150);
            this.Timestamp5M.Name = "Timestamp5M";
            this.Timestamp5M.Size = new System.Drawing.Size(46, 24);
            this.Timestamp5M.TabIndex = 25;
            this.Timestamp5M.Text = "5m";
            this.Timestamp5M.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Timestamp5M.UseVisualStyleBackColor = true;
            this.Timestamp5M.Click += new System.EventHandler(this.Timestamp5M_Click);
            // 
            // Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 334);
            this.Controls.Add(this.Timestamp5M);
            this.Controls.Add(this.Timestamp15M);
            this.Controls.Add(this.Timestamp30M);
            this.Controls.Add(this.Timestamp1H);
            this.Controls.Add(this.TimestampNow);
            this.Controls.Add(this.ImageDetailsLabel);
            this.Controls.Add(this.TimeDetailsLabel);
            this.Controls.Add(this.MainDetailsLabel);
            this.Controls.Add(this.SmallImageText);
            this.Controls.Add(this.SmallImageTextLabel);
            this.Controls.Add(this.SmallImageKey);
            this.Controls.Add(this.SmallImageKeyLabel);
            this.Controls.Add(this.LargeImageText);
            this.Controls.Add(this.LargeImageTextLabel);
            this.Controls.Add(this.LargeImageKey);
            this.Controls.Add(this.LargeImageKeyLabel);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.DetailText);
            this.Controls.Add(this.DetailLabel);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.ShutdownButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.StatusLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Controls";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Discord RPC";
            this.Load += new System.EventHandler(this.Controls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ShutdownButton;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.TextBox DetailText;
        private System.Windows.Forms.Label DetailLabel;
        private System.Windows.Forms.TextBox StartTime;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.TextBox EndTime;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.TextBox LargeImageKey;
        private System.Windows.Forms.Label LargeImageKeyLabel;
        private System.Windows.Forms.Label LargeImageTextLabel;
        private System.Windows.Forms.TextBox LargeImageText;
        private System.Windows.Forms.TextBox SmallImageText;
        private System.Windows.Forms.Label SmallImageTextLabel;
        private System.Windows.Forms.TextBox SmallImageKey;
        private System.Windows.Forms.Label SmallImageKeyLabel;
        private System.Windows.Forms.Label MainDetailsLabel;
        private System.Windows.Forms.Label TimeDetailsLabel;
        private System.Windows.Forms.Label ImageDetailsLabel;
        private System.Windows.Forms.Button TimestampNow;
        private System.Windows.Forms.Button Timestamp1H;
        private System.Windows.Forms.Button Timestamp30M;
        private System.Windows.Forms.Button Timestamp15M;
        private System.Windows.Forms.Button Timestamp5M;
    }
}