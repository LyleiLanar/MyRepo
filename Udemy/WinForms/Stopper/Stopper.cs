using System;
using System.Windows.Forms;

namespace Stopper
{
    public partial class Stopper : Form
    {
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public Stopper()
        {
            InitializeComponent();
            BtnStop.Enabled = false;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            this.StartTime = DateTime.Now;
            TxtStartTime.Text = StartTime.ToString("HH:mm:ss.fff");
            TxtEndTime.Text = "-";
            BtnStart.Enabled = false;
            BtnStop.Enabled = true;
            TxtEllapsedTime.Text = "-";
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            this.StopTime = DateTime.Now;
            TxtEndTime.Text = StopTime.ToString("HH:mm:ss.fff");
            BtnStart.Enabled = true;
            BtnStop.Enabled = false;
            TxtEllapsedTime.Text = StopTime.Subtract(StartTime).TotalSeconds.ToString("n3") + " s";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
