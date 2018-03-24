using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDiscordRPC
{
    public partial class Controls : Form
    {
        public Controls()
        {
            InitializeComponent();
        }

        private void Controls_Load(object sender, EventArgs e)
        {
            DetailText.Text = Properties.Settings.Default.Details;
            StatusText.Text = Properties.Settings.Default.Status;
            StartTime.Text = Properties.Settings.Default.StartTime;
            EndTime.Text = Properties.Settings.Default.EndTime;
            LargeImageKey.Text = Properties.Settings.Default.LargeImageKey;
            LargeImageText.Text = Properties.Settings.Default.LargeImageText;
            SmallImageKey.Text = Properties.Settings.Default.SmallImageText;
            SmallImageText.Text = Properties.Settings.Default.SmallImageText;
        }

        private void ShutdownButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Details = DetailText.Text;
            Properties.Settings.Default.Status = StatusText.Text;
            Properties.Settings.Default.StartTime = StartTime.Text;
            Properties.Settings.Default.EndTime = EndTime.Text;
            Properties.Settings.Default.LargeImageKey = LargeImageKey.Text;
            Properties.Settings.Default.LargeImageText = LargeImageText.Text;
            Properties.Settings.Default.SmallImageKey = SmallImageKey.Text;
            Properties.Settings.Default.SmallImageText = SmallImageText.Text;
            Properties.Settings.Default.Save();
        }

        private void Timestamp5M_Click(object sender, EventArgs e)
        {

        }

        private void Timestamp15M_Click(object sender, EventArgs e)
        {

        }

        private void Timestamp30M_Click(object sender, EventArgs e)
        {

        }

        private void Timestamp1H_Click(object sender, EventArgs e)
        {

        }

        private void TimestampNow_Click(object sender, EventArgs e)
        {
            StartTime.Text = DateTime.Now.ToString();
        }

        private void StatusText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DetailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void EndTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void LargeImageText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SmallImageText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SmallImageKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void LargeImageKey_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
