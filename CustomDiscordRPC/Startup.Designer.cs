namespace CustomDiscordRPC
{
    partial class Startup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            this.ClientIDLabel = new System.Windows.Forms.Label();
            this.ClientID = new System.Windows.Forms.TextBox();
            this.Notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientIDLabel
            // 
            this.ClientIDLabel.AutoSize = true;
            this.ClientIDLabel.Location = new System.Drawing.Point(11, 12);
            this.ClientIDLabel.Name = "ClientIDLabel";
            this.ClientIDLabel.Size = new System.Drawing.Size(60, 16);
            this.ClientIDLabel.TabIndex = 0;
            this.ClientIDLabel.Text = "Client ID:";
            // 
            // ClientID
            // 
            this.ClientID.Location = new System.Drawing.Point(72, 10);
            this.ClientID.Name = "ClientID";
            this.ClientID.Size = new System.Drawing.Size(442, 22);
            this.ClientID.TabIndex = 1;
            this.ClientID.TextChanged += new System.EventHandler(this.ClientID_TextChanged);
            // 
            // Notification
            // 
            this.Notification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Notification.Icon = ((System.Drawing.Icon)(resources.GetObject("Notification.Icon")));
            this.Notification.Text = "Notification";
            this.Notification.Visible = true;
            this.Notification.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Notification_MouseDoubleClick);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(11, 39);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(505, 29);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start Discord RPC";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 79);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ClientID);
            this.Controls.Add(this.ClientIDLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Startup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Discord RPC";
            this.Load += new System.EventHandler(this.Startup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientIDLabel;
        private System.Windows.Forms.TextBox ClientID;
        private System.Windows.Forms.NotifyIcon Notification;
        private System.Windows.Forms.Button StartButton;
    }
}

