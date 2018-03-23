using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Reflection;
using System.Diagnostics;

namespace CustomDiscordRPC
{
    public partial class Startup : Form
    {
        private string LatestVersion;

        public Startup()
        {
            InitializeComponent();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            if (!File.Exists("discord-rpc-w32.dll"))
            {
                MessageBox.Show("DLL 'discord-rpc-w32.dll' Not found!\nPlease download it from this GitHub's releases page:\nhttps://github.com/viral32111/CustomDiscordRPC", "Custom Discord RPC",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/viral32111/CustomDiscordRPC/master/README.md");
            Request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse Response = (HttpWebResponse)Request.GetResponse())
            using (Stream Stream = Response.GetResponseStream())
            using (StreamReader Reader = new StreamReader(Stream))
            {
                LatestVersion = Reader.ReadToEnd().Substring(33, 4);
            }
            
            string CurrentVersion = Assembly.GetEntryAssembly().GetName().Version.ToString().Replace(".", "");

            if (CurrentVersion != LatestVersion)
            {
                Notification.ShowBalloonTip(1000, "Update Avaliable!", "Version: " + LatestVersion + " of Custom Discord RPC is avaliable!\nYou can download it from GitHub.", ToolTipIcon.Info);
            }

            ClientID.Text = Properties.Settings.Default.ClientID;
        }

        private void Notification_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start("https://github.com/viral32111/CustomDiscordRPC");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (ClientID.Text != string.Empty) {
                Controls ControlForm = new Controls();
                ControlForm.Closed += (s, args) => Close();
                ControlForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Please enter a valid Client ID!\n\nThis can be found under App Details on your App's page.\nhttps://discordapp.com/developers/applications/me", "Custom Discord RPC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClientID_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClientID = ClientID.Text;
            Properties.Settings.Default.Save();
        }
    }
}
