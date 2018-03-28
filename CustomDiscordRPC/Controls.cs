using System;
using System.Windows.Forms;

namespace CustomDiscordRPC
{
    public partial class Controls : Form
    {
        private DiscordRpc.RichPresence presence;
        DiscordRpc.EventHandlers handlers;

        public Controls()
        {
            InitializeComponent();
        }

        // Ready Callback
        private void ReadyCallback()
        {
            RPCStatusLabel.Text = "Ready";
        }

        // Disconnected Callback
        private void DisconnectedCallback(int errorCode, string message)
        {
            RPCStatusLabel.Text = "Disconnected!";
            MessageBox.Show("Disconnect " + errorCode.ToString() + ": " + message);
        }

        // Error Callback
        private void ErrorCallback(int errorCode, string message)
        {
            RPCStatusLabel.Text = "Error!";
            MessageBox.Show("Error " + errorCode.ToString() + ": " + message);
            Close();
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

            handlers = new DiscordRpc.EventHandlers();
            handlers.readyCallback = ReadyCallback;
            handlers.disconnectedCallback += DisconnectedCallback;
            handlers.errorCallback += ErrorCallback;

            DiscordRpc.RPCInit(Properties.Settings.Default.ClientID, ref handlers, true, null);

            RPCStatusLabel.Text = "Initalized";
        }

        private void ShutdownButton_Click(object sender, EventArgs e)
        {
            RPCStatusLabel.Text = "Shutting Down...";

            DiscordRpc.RPCShutdown();

            Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            presence.details = DetailText.Text;
            presence.state = StatusText.Text;

            presence.largeImageKey = LargeImageKey.Text;
            presence.largeImageText = LargeImageText.Text;
            presence.smallImageKey = SmallImageKey.Text;
            presence.smallImageText = SmallImageText.Text;

            DiscordRpc.RPCUpdate(ref presence);

            // Save it
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

        private void RPCStatusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
