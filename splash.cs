using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FSKETCH_V2
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();

            splashpic.Controls.Add(lbl1);
            lbl1.BackColor = Color.Transparent;
        }
        int step = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl1.ForeColor = Color.White;
            switch (step)
            {
                case 0:
                    this.Enabled = false;
                    timer1.Interval = 2000;
                    break;
                case 1:
                    lbl1.Text = "Initializing Modules.....100%";
                    break;
                case 2:
                    lbl1.Text = "Initializing UI.....100%";
                    break;
                case 3:
                    lbl1.Text = "Initializing Components.....100%";
                    break;
                case 4:
                    this.Close();
                    break;
            }
            this.Enabled = false;
            step++;
            if (step == 4)
            {
                timer1.Stop();
                select sl = new select();
                this.Hide();
                sl.Show();
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            timer1.Start();
        }

        private void splashpic_Click(object sender, EventArgs e)
        {

        }

    }
}