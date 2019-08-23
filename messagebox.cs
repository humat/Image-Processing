using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FSKETCH_V2
{
    public partial class messagebox : Form
    {
        static messagebox newMessageBox;
        public Timer msgTimer;
        static string Button_id;
        int disposeFormTimer; 

        public messagebox()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender;
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            Color startColor = Color.FromArgb(0, 0, 0);
            Color endColor = Color.FromArgb(255, 255, 255);
            using (LinearGradientBrush darkBrush = new LinearGradientBrush(control.ClientRectangle, startColor, endColor, LinearGradientMode.Vertical))
            {
                g.FillRectangle(darkBrush, control.ClientRectangle);
            }
        }
        public static string ShowBox(string txtMessage)
        {
            newMessageBox = new messagebox();
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Button_id;
        }

        public static string ShowBox(string txtMessage, string txtTitle)
        {
            newMessageBox = new messagebox();
           // newMessageBox.lblTitle.Text = txtTitle;
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Button_id;
        }

        private void messagebox_Load(object sender, EventArgs e)
        {
            disposeFormTimer = 10;
            newMessageBox.lblTimer.Text = disposeFormTimer.ToString();
            msgTimer = new Timer();
            msgTimer.Interval = 1000;
            msgTimer.Enabled = true;
            msgTimer.Start();
            msgTimer.Tick += new System.EventHandler(this.timer_tick);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            newMessageBox.msgTimer.Stop();
            newMessageBox.msgTimer.Dispose();
            Button_id = "1";
            newMessageBox.Dispose(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            newMessageBox.msgTimer.Stop();
            newMessageBox.msgTimer.Dispose();
            Button_id = "2";
            newMessageBox.Dispose();
        }
        private void timer_tick(object sender, EventArgs e)
        {
            disposeFormTimer--;

            if (disposeFormTimer >= 0)
            {
                newMessageBox.lblTimer.Text = disposeFormTimer.ToString();
            }
            else
            {
                newMessageBox.msgTimer.Stop();
                newMessageBox.msgTimer.Dispose();
                newMessageBox.Dispose();
            }
        }

        private void close_lbl_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
