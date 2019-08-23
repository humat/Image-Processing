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
    public partial class select : Form
    {
        public select()
        {
            InitializeComponent();

            GradientPanel.Controls.Add(male_sketch);
            male_sketch.BackColor = Color.Transparent;

            GradientPanel.Controls.Add(female_sketch);
            female_sketch.BackColor = Color.Transparent;
        }

       
        private void GradientPanel_Paint(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender;
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            Color startColor = Color.FromArgb(0, 0, 0);
            Color endColor = Color.FromArgb(255,255,255);
            using (LinearGradientBrush darkBrush = new LinearGradientBrush(control.ClientRectangle, startColor, endColor, LinearGradientMode.Vertical))
            {
                g.FillRectangle(darkBrush, control.ClientRectangle);
            }
        }

        private void close_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void male_btn_Click(object sender, EventArgs e)
        {
            male m = new male();
            m.Show();
            this.Hide();
        }

        private void female_btn_Click(object sender, EventArgs e)
        {
            female fm = new female();
            fm.Show();
            this.Hide();
        }

        private void min_lbl_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       
    }
}
