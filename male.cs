using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace FSKETCH_V2
{

    public partial class male : Form
    {
        private Image Img;
        private Image Img2;
        private Image Img3;
        private Image Img4;
        private Image Img5;
        private Image Img6;
        private Image Img7;
       

       
        int width;
        int height;

        Point lastPoint = Point.Empty;//Point.Empty represents null for a Point object

        bool isMouseDown = new Boolean();//this is used to evaluate whether our mousebutton is down or not
 
        public male()
        {
            InitializeComponent();


            feature_list.Controls.Clear();
            string[] head_images = Directory.GetFiles(@"..\..\lips_male\head_folder", "*.png");

            foreach (string image in head_images)
            {
                PictureBox ph = new PictureBox();
                ph.Image = new Bitmap(image);
                ph.SizeMode = PictureBoxSizeMode.StretchImage;
                ph.Height = 140; ph.Width = 100;
                ph.BorderStyle = BorderStyle.Fixed3D;
                ph.Click += ph_Click;
                feature_list.Controls.Add(ph);
            }

            face_panel.Controls.Add(workplace);
            workplace.Anchor = (AnchorStyles.Top);
            workplace.MouseMove += workplace_MouseMove;
            workplace.MouseDown += workplace_MouseDown;
            workplace.BackColor = Color.Transparent;

            background_panel.Controls.Add(ficon_panel);
            ficon_panel.BackColor = Color.Transparent;

            background_panel.Controls.Add(feature_list);
            feature_list.BackColor = Color.Transparent;

            background_panel.Controls.Add(selected_feature);
            selected_feature.BackColor = Color.Transparent;

            workplace.Controls.Add(eyeholder);
            eyeholder.Anchor = (AnchorStyles.Top);
            eyeholder.Location = new Point(-70, 250);
            eyeholder.MouseMove += eyeholder_MouseMove;
            eyeholder.MouseDown += eyeholder_MouseDown;
            eyeholder.BackColor = Color.Transparent;

            
          workplace.Controls.Add(noseholder);
            noseholder.Location = new Point(140, 310);
            noseholder.MouseMove += noseholder_MouseMove;
            noseholder.MouseDown += noseholder_MouseDown;
            noseholder.BackColor = Color.Transparent;
            noseholder.BringToFront();

            workplace.Controls.Add(lipholder);
            lipholder.Location = new Point(115, 400);
            lipholder.MouseMove += lipholder_MouseMove;
            lipholder.MouseDown += lipholder_MouseDown;
            lipholder.BackColor = Color.Transparent;
            lipholder.BringToFront();

            eyeholder.Controls.Add(eyebrowholder);
            eyebrowholder.Location = new Point(-10, -5);
            eyebrowholder.MouseMove += eyebrowholder_MouseMove;
            eyebrowholder.MouseDown += eyebrowholder_MouseDown;
            eyebrowholder.BackColor = Color.Transparent;
            eyebrowholder.BringToFront();

            workplace.Controls.Add(hairholder);
            hairholder.Location = new Point(-300, -40);
            hairholder.MouseMove += hairholder_MouseMove;
            hairholder.MouseDown += hairholder_MouseDown;
            hairholder.BackColor = Color.Transparent;
         //   hairholder.BringToFront();
 

            workplace.Controls.Add(mholder);
            mholder.Location = new Point(100, 370);
            mholder.MouseMove += mholder_MouseMove;
            mholder.MouseDown += mholder_MouseDown;
            mholder.BackColor = Color.Transparent;
            mholder.BringToFront();

            width = workplace.Width;
            height = workplace.Height;
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        PictureBox workplace = new PictureBox();
        PictureBox head = new PictureBox();
        private void headicon_Click(object sender, EventArgs e)
        {
            edit_panel.Visible = true;
            feature_list.Controls.Clear();
            string[] head_images = Directory.GetFiles(@"..\..\lips_male\head_folder", "*.png");

            foreach (string image in head_images)
            {
                PictureBox ph = new PictureBox();

                ph.Image = new Bitmap(image);
                ph.SizeMode = PictureBoxSizeMode.StretchImage;
                ph.Height = 140; ph.Width = 100;
                ph.BorderStyle = BorderStyle.Fixed3D;
                ph.Click += ph_Click;
                feature_list.Controls.Add(ph);
            }
        }

        private void ph_Click(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            workplace.Size = new Size(432, 617);
            workplace.SizeMode = PictureBoxSizeMode.CenterImage;
            workplace.Image = obj.Image;
            Img = workplace.Image;// for brightness
            head.Height = 50; head.Width = 50;
            head.SizeMode = PictureBoxSizeMode.StretchImage;
            head.Image = obj.Image;
            head.Click += head_Click;
            selected_feature.Controls.Add(head);
        }
        bool head_Clicked = false;
        private void head_Click(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            obj.BorderStyle = BorderStyle.FixedSingle;
            head_Clicked = true;

            eye_Clicked = false;
            eye.BorderStyle = BorderStyle.None;
            eyebrow_Clicked = false;
            eyebrow.BorderStyle = BorderStyle.None;
            nose_Clicked = false;
            nose.BorderStyle = BorderStyle.None;
            lip_Clicked = false;
            lip.BorderStyle = BorderStyle.None;
            hair_Clicked = false;
            hair.BorderStyle = BorderStyle.None;
            
        }

        PictureBox eyeholder = new PictureBox();
        private void eyeicon_Click(object sender, EventArgs e)
        {
            edit_panel.Visible = true;
            feature_list.Controls.Clear();
            string[] eye_images = Directory.GetFiles(@"..\..\eye1_folder", "*.png");

            foreach (string image in eye_images)
            {
                PictureBox pe = new PictureBox();
                pe.Image = new Bitmap(image);
                pe.Height = 120; pe.Width = 120;
                pe.BorderStyle = BorderStyle.Fixed3D;
                pe.SizeMode = PictureBoxSizeMode.StretchImage;
                pe.Click += pe_Click;
                feature_list.Controls.Add(pe);
            }
        }

        PictureBox eye = new PictureBox();
        private void pe_Click(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            eyeholder.Size = new Size(240,120);
            eyeholder.SizeMode = PictureBoxSizeMode.CenterImage;
            eyeholder.Image = obj.Image;
            Img2 = eyeholder.Image;
            eye.Height = 50; eye.Width = 50;
            eye.SizeMode = PictureBoxSizeMode.StretchImage;
            eye.Image = obj.Image;
            eye.Click += eye_Click;
            selected_feature.Controls.Add(eye);
        }
        bool eye_Clicked = false;
        private void eye_Click(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            obj.BorderStyle = BorderStyle.FixedSingle;
            eye_Clicked = true;

            head_Clicked = false;
            head.BorderStyle = BorderStyle.None;
            eyebrow_Clicked = false;
            eyebrow.BorderStyle = BorderStyle.None;
            nose_Clicked = false;
            nose.BorderStyle = BorderStyle.None;
            lip_Clicked = false;
            lip.BorderStyle = BorderStyle.None;
            hair_Clicked = false;
            hair.BorderStyle = BorderStyle.None;
           
        }

        private void eyebrowicon_Click(object sender, EventArgs e)
        {
            feature_list.Controls.Clear();
            string[] eyebrow_images = Directory.GetFiles(@"..\..\eyebrow_folder", "*.png");
            foreach (string image in eyebrow_images)
            {
                PictureBox peb = new PictureBox();
                peb.Image = new Bitmap(image);
                peb.Height = 30; peb.Width = 120;
                peb.BorderStyle = BorderStyle.Fixed3D;
                peb.SizeMode = PictureBoxSizeMode.StretchImage;
                peb.Click += peb_Click;
                feature_list.Controls.Add(peb);
            }

        }

        PictureBox eyebrowholder = new PictureBox();
        PictureBox eyebrow = new PictureBox();

        private void peb_Click(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            eyebrowholder.Image = obj.Image;
            Img3 = eyebrowholder.Image;
            eyebrowholder.Size = new Size(263, 40);
            eyebrow.Height = 50; eyebrow.Width = 50;
            eyebrow.SizeMode = PictureBoxSizeMode.StretchImage;
            eyebrow.Image = obj.Image;
            eyebrow.Click += eyebrow_Click;
            selected_feature.Controls.Add(eyebrow);
        }

        bool eyebrow_Clicked = false;
        private void eyebrow_Click(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            obj.BorderStyle = BorderStyle.FixedSingle;
            eyebrow_Clicked = true;

            head_Clicked = false;
            head.BorderStyle = BorderStyle.None;
            eye_Clicked = false;
            eye.BorderStyle = BorderStyle.None;
            nose_Clicked = false;
            nose.BorderStyle = BorderStyle.None;
            lip_Clicked = false;
            lip.BorderStyle = BorderStyle.None;
            hair_Clicked = false;
            hair.BorderStyle = BorderStyle.None;
            
        }

        private void nose_icon_Click(object sender, EventArgs e)
        {
            feature_list.Controls.Clear();
            string[] nose_images = Directory.GetFiles(@"..\..\nose_folder", "*.png");
            foreach (string image in nose_images)
            {
                PictureBox pn = new PictureBox();
                pn.Image = new Bitmap(image);
                pn.Height = 120; pn.Width = 100;
                pn.BorderStyle = BorderStyle.Fixed3D;
                pn.SizeMode = PictureBoxSizeMode.StretchImage;
                pn.Click += pn_Click;
                feature_list.Controls.Add(pn);
            }
        }
        PictureBox noseholder = new PictureBox();
        PictureBox nose = new PictureBox();
        private void pn_Click(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            noseholder.Image = obj.Image;
            Img4 = noseholder.Image;
            noseholder.Size = new Size(100,100);
            noseholder.SizeMode = PictureBoxSizeMode.CenterImage;
            nose.Height = 50; nose.Width = 50;
            nose.SizeMode = PictureBoxSizeMode.StretchImage;
            nose.Image = obj.Image;
            nose.Click += nose_Click;
            selected_feature.Controls.Add(nose);
        }
        bool nose_Clicked = false;
        private void nose_Click(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            obj.BorderStyle = BorderStyle.FixedSingle;
            nose_Clicked = true;

            head_Clicked = false;
            head.BorderStyle = BorderStyle.None;
            eyebrow_Clicked = false;
            eyebrow.BorderStyle = BorderStyle.None;
            eye_Clicked = false;
            eye.BorderStyle = BorderStyle.None;
            lip_Clicked = false;
            lip.BorderStyle = BorderStyle.None;
            hair_Clicked = false;
            hair.BorderStyle = BorderStyle.None;
            
        }

        PictureBox lipholder = new PictureBox();
        private void lipicon_Click(object sender, EventArgs e)
        {
            feature_list.Controls.Clear();
            string[] lip_images = Directory.GetFiles(@"..\..\lips_male", "*.png");
            foreach (string image in lip_images)
            {
                PictureBox pl = new PictureBox();
                pl.Image = new Bitmap(image);
                pl.Height = 100; pl.Width = 130;
                pl.BorderStyle = BorderStyle.Fixed3D;
                pl.SizeMode = PictureBoxSizeMode.StretchImage;
                pl.Click += pl_Click;
                feature_list.Controls.Add(pl);
            }
        }
        PictureBox lip = new PictureBox();
        private void pl_Click(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            lipholder.Size = new Size(150, 55);
            lipholder.SizeMode = PictureBoxSizeMode.CenterImage;
            lipholder.Image = obj.Image;
            Img5 = lipholder.Image;
            lip.Height = 50; lip.Width = 50;
            lip.SizeMode = PictureBoxSizeMode.StretchImage;
            lip.Image = obj.Image;
            lip.Click += lip_Click;
            selected_feature.Controls.Add(lip);
        }
        bool lip_Clicked = false;
        private void lip_Click(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            obj.BorderStyle = BorderStyle.FixedSingle;
            lip_Clicked = true;

            head_Clicked = false;
            head.BorderStyle = BorderStyle.None;
            eyebrow_Clicked = false;
            eyebrow.BorderStyle = BorderStyle.None;
            nose_Clicked = false;
            nose.BorderStyle = BorderStyle.None;
            eye_Clicked = false;
            eye.BorderStyle = BorderStyle.None;
            hair_Clicked = false;
            hair.BorderStyle = BorderStyle.None;
            
        }
        PictureBox hairholder = new PictureBox();
        PictureBox hair = new PictureBox();
        private void phm_Click(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            hairholder.Image = obj.Image;
            Img6 = hairholder.Image;
            hairholder.SizeMode = PictureBoxSizeMode.CenterImage;
            hairholder.Size = new Size(1000, 500);
            hair.Height = 50; hair.Width = 50;
            hair.SizeMode = PictureBoxSizeMode.StretchImage;
            hair.Image = obj.Image;
            hair.Click += hair_Click;
            selected_feature.Controls.Add(hair);
        }
        bool hair_Clicked = false;
        private void hair_Click(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            obj.BorderStyle = BorderStyle.FixedSingle;
            hair_Clicked = true;

            head_Clicked = false;
            head.BorderStyle = BorderStyle.None;
            eyebrow_Clicked = false;
            eyebrow.BorderStyle = BorderStyle.None;
            nose_Clicked = false;
            nose.BorderStyle = BorderStyle.None;
            lip_Clicked = false;
            lip.BorderStyle = BorderStyle.None;
            eye_Clicked = false;
            eye.BorderStyle = BorderStyle.None;
            
        }

        private void hairicon_Click_1(object sender, EventArgs e)
        {
            feature_list.Controls.Clear();
            string[] hair_images = Directory.GetFiles(@"..\..\male_hair_folder", "*.png");

            foreach (string image in hair_images)
            {
                PictureBox phm = new PictureBox();
                phm.Image = new Bitmap(image);
                phm.Height = 100; phm.Width = 130;
                phm.BorderStyle = BorderStyle.Fixed3D;
                phm.SizeMode = PictureBoxSizeMode.StretchImage;
                phm.Click += phm_Click;
                feature_list.Controls.Add(phm);
            }
        }


      
        //delete sketch 
        private void delete_Click(object sender, EventArgs e)
        {
            if (head_Clicked)
            {
                workplace.Image = null;
                head.Image = null;
                head.BorderStyle = BorderStyle.None;
            }
            if (eye_Clicked)
            {
                eyeholder.Image = null;
                eye.Image = null;
                eye.BorderStyle = BorderStyle.None;
            }
            if (eyebrow_Clicked)
            {
                eyebrowholder.Image = null;
                eyebrow.Image = null;
                eyebrow.BorderStyle = BorderStyle.None;
            }
            if (nose_Clicked)
            {
                noseholder.Image = null;
                nose.Image = null;
                nose.BorderStyle = BorderStyle.None;
            }
            if (lip_Clicked)
            {
                lipholder.Image = null;
                lip.Image = null;
                lip.BorderStyle = BorderStyle.None;
            }
            if (hair_Clicked)
            {
                hairholder.Image = null;
                hair.Image = null;
                hair.BorderStyle = BorderStyle.None;
            }
           
            if (much_Clicked)
            {
                //hholder.Image = null;
            }
        }

        private void new_lbl_Click(object sender, EventArgs e)
        {
            selected_feature.Controls.Clear();
            workplace.Image = null;
            eyeholder.Image = null;
            noseholder.Image = null;
            eyebrowholder.Image = null;
            // hairholder.Image = null;
        }

        private void save_lbl_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(this.face_panel.Width, this.face_panel.Height);
            this.face_panel.DrawToBitmap(bmp, new Rectangle(0, 0, this.face_panel.Width, this.face_panel.Height));
            bmp.Save("C:\\panel.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        int x;
        int y;
       
        private void workplace_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
           

        }

        private void workplace_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                workplace.Left += (e.X - x);
                workplace.Top += (e.Y - y);
            }

        }

        private void eyeholder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
        }

        private void eyeholder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                eyeholder.Left += (e.X - x);
                eyeholder.Top += (e.Y - y);
            }
        }


        private void eyebrowholder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
        }

        private void eyebrowholder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                eyebrowholder.Left += (e.X - x);
                eyebrowholder.Top += (e.Y - y);
            }
        }

        private void noseholder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
        }

        private void noseholder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                noseholder.Left += (e.X - x);
                noseholder.Top += (e.Y - y);
            }
        }

        private void lipholder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
        }

        private void lipholder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lipholder.Left += (e.X - x);
                lipholder.Top += (e.Y - y);
            }
        }

        private void hairholder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
        }

        private void hairholder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                hairholder.Left += (e.X - x);
                hairholder.Top += (e.Y - y);
            }
        }
        private void mholder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
        }

        private void mholder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mholder.Left += (e.X - x);
                mholder.Top += (e.Y - y);
            }
        }

        private void glassholder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
        }

        

        PictureBox mholder = new PictureBox();
        private void moustacheicon_Click(object sender, EventArgs e)
        {
            feature_list.Controls.Clear();
            string[] mustachimg = Directory.GetFiles(@"..\..\Mustache", "*.png");

            foreach (string image in mustachimg)
            {
                PictureBox pms = new PictureBox();
                pms.Image = new Bitmap(image);
                pms.Height = 100; pms.Width = 130;
                pms.BorderStyle = BorderStyle.Fixed3D;
                pms.SizeMode = PictureBoxSizeMode.StretchImage;
                pms.Click += mutch_Click;
                feature_list.Controls.Add(pms);
            }
        }

        PictureBox much = new PictureBox();//mustache click
        private void mutch_Click(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            mholder.Size = new Size(125, 57);
            mholder.SizeMode = PictureBoxSizeMode.CenterImage;
            mholder.Image = obj.Image;         
            Img7 = mholder.Image;
            much.Height = 50; much.Width = 50;
            much.SizeMode = PictureBoxSizeMode.StretchImage;
            much.Image = obj.Image;
            much.Click += much_Click;
            selected_feature.Controls.Add(much);
        }

        bool much_Clicked = false;
        private void much_Click(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            obj.BorderStyle = BorderStyle.FixedSingle;
            much_Clicked = true;

            head_Clicked = false;
            head.BorderStyle = BorderStyle.None;
            eyebrow_Clicked = false;
            eyebrow.BorderStyle = BorderStyle.None;
            nose_Clicked = false;
            nose.BorderStyle = BorderStyle.None;
            lip_Clicked = false;
            lip.BorderStyle = BorderStyle.None;
            hair_Clicked = false;
            hair.BorderStyle = BorderStyle.None;
            eye_Clicked = false;
            eye.BorderStyle = BorderStyle.None;
            
        }

        private void beard_Click(object sender, EventArgs e)
        {
            feature_list.Controls.Clear();
            string[] beard_images = Directory.GetFiles(@"..\..\beard", "*.png");

            foreach (string image in beard_images)
            {
                PictureBox pd = new PictureBox();
                pd.Image = new Bitmap(image);
                pd.Height = 80; pd.Width = 120;
                pd.BorderStyle = BorderStyle.Fixed3D;
                pd.SizeMode = PictureBoxSizeMode.StretchImage;
                pd.Click += pd_Click;
                feature_list.Controls.Add(pd);
            }
        }
        PictureBox bd = new PictureBox();
        private void pd_Click(object sender, EventArgs e)
        {

            PictureBox obj = (PictureBox)sender;
            beardholder.Image = obj.Image;
            bd.Height = 50; bd.Width = 50;
            bd.SizeMode = PictureBoxSizeMode.StretchImage;
            bd.Image = obj.Image;
            //  bd.Click += bd_Click;
            selected_feature.Controls.Add(bd);
        }

        // for closing the application............
        private void close_lbl_Click_1(object sender, EventArgs e)
        {
            string result = messagebox.ShowBox("Do you want to exit?", "Exit");
            if (result.Equals("1"))
            {
                Application.Exit();
            }

            if (result.Equals("2"))
            {
                messagebox mb=new messagebox();
                mb.Hide();
            }
        }
        // for minimizing the application........
        private void min_lbl_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // for fade effect when form opens..........
        private void timer_fade_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                timer_fade.Stop();
            }
        }

        private void male_Load_1(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer_fade.Start();
        }

        private void label3_Click_2(object sender, EventArgs e)
        {
            face_panel.Visible = false;
        }

        //------------------------------------features move---------------------------------------//
       
        private void move_Click(object sender, EventArgs e)
        {
            if (movedirection.Visible == false)
            {
                movedirection.Visible = true;
                background_panel.Controls.Add(movedirection);
            }
            else
            {
                movedirection.Visible = false;
            }
        }

        private void moveright_Click(object sender, EventArgs e)
        {
            if (head_Clicked)
            {
                this.workplace.Left = this.workplace.Left + 5;
            }

            if (eye_Clicked)
            {
                this.eyeholder.Left = this.eyeholder.Left + 5;
            }

            if (eyebrow_Clicked)
            {
                this.eyebrowholder.Left = this.eyebrowholder.Left + 5;
            }
            if (nose_Clicked)
            {
                this.noseholder.Left = this.noseholder.Left + 5;
            }
            if (lip_Clicked)
            {
                this.lipholder.Left = this.lipholder.Left + 5;
            }
            if (hair_Clicked)
            {
                this.hairholder.Left = this.hairholder.Left + 5;
            }
            if (much_Clicked)
            {
                this.mholder.Left = this.mholder.Left + 5;
            }
        }

        private void movedown_Click(object sender, EventArgs e)
        {
            if (head_Clicked)
            {
                this.workplace.Top = this.workplace.Top + 5;
            }
            if (eye_Clicked)
            {
                this.eyeholder.Top = this.eyeholder.Top + 5;
            }
            if (eyebrow_Clicked)
            {
                this.eyebrowholder.Top = this.eyebrowholder.Top + 5;
            }
            if (nose_Clicked)
            {
                this.noseholder.Top = this.noseholder.Top + 5;
            }
            if (lip_Clicked)
            {
                this.lipholder.Top = this.lipholder.Top + 5;
            }
            if (hair_Clicked)
            {
                this.hairholder.Top = this.hairholder.Top + 5;
            }
            if (much_Clicked)
            {
                this.mholder.Top = this.mholder.Top + 5;
            }
        }

        private void moveup_Click(object sender, EventArgs e)
        {
            if (head_Clicked)
            {
                this.workplace.Top = this.workplace.Top - 5;
            }
            if (eye_Clicked)
            {
                this.eyeholder.Top = this.eyeholder.Top - 5;
            }
            if (eyebrow_Clicked)
            {
                this.eyebrowholder.Top = this.eyebrowholder.Top - 5;
            }
            if (nose_Clicked)
            {
                this.noseholder.Top = this.noseholder.Top - 5;
            }
            if (lip_Clicked)
            {
                this.lipholder.Top = this.lipholder.Top - 5;
            }
            if (hair_Clicked)
            {
                this.hairholder.Top = this.hairholder.Top - 5;
            }
            if (much_Clicked)
            {
                this.mholder.Top = this.mholder.Top - 5;
            }
        }

        private void moveleft_Click(object sender, EventArgs e)
        {
            if (head_Clicked)
            {
                this.workplace.Left = this.workplace.Left - 5;
            }
            if (eye_Clicked)
            {
                this.eyeholder.Left = this.eyeholder.Left - 5;
            }
            if (eyebrow_Clicked)
            {
                this.eyebrowholder.Left = this.eyebrowholder.Left - 5;
            }
            if (nose_Clicked)
            {
                this.noseholder.Left = this.noseholder.Left - 5;
            }
            if (lip_Clicked)
            {
                this.lipholder.Left = this.lipholder.Left - 5;
            }
            if (hair_Clicked)
            {
                this.hairholder.Left = this.hairholder.Left - 5;
            }
            if (much_Clicked)
            {
                this.mholder.Left = this.mholder.Left - 5;
            }
        }

        //-------------------------------------feature Brightness------------------------------//

        private void bright_btn_Click(object sender, EventArgs e)
        {
            if (brightness_panel.Visible == false)
            {
                brightness_panel.Visible = true;
                background_panel.Controls.Add(brightness_panel);
            }
            else
            {
                brightness_panel.Visible = false;
            }
        }

        private void brightSlider_Scroll(object sender, EventArgs e)
        {

            lblBrightness.Text = brightSlider.Value.ToString();

            if (head_Clicked)
            {

                float value = brightSlider.Value * 0.01f;
                float[][] colorMatrixElements = {
	                                                new float[] {	1,		0,		0,		0,		0	},
	                                                new float[] {	0,		1,		0,		0,		0	},
	                                                new float[] {	0,		0,		1,		0,		0	},
	                                                new float[] {	0,		0,		0,		1,		0	},
	                                                new float[] {	value,		value,		value,		0,		1	}
                                                };
                ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                ImageAttributes imageAttributes = new ImageAttributes();

                imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                Image _img = Img;

                Graphics _g = default(Graphics);
                Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                _g = Graphics.FromImage(bm_dest);
                _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                workplace.Image = bm_dest;
            }




            if (eye_Clicked)
            {
                float value = brightSlider.Value * 0.01f;
                float[][] colorMatrixElements = {
	                                                new float[] {	1,		0,		0,		0,		0	},
	                                                new float[] {	0,		1,		0,		0,		0	},
	                                                new float[] {	0,		0,		1,		0,		0	},
	                                                new float[] {	0,		0,		0,		1,		0	},
	                                                new float[] {	value,		value,		value,		0,		1	}
                                                };
                ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                ImageAttributes imageAttributes = new ImageAttributes();

                imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                Image _img = Img2;

                Graphics _g = default(Graphics);
                Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                _g = Graphics.FromImage(bm_dest);
                _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                eyeholder.Image = bm_dest;
            }
            if (eyebrow_Clicked)
            {
                float value = brightSlider.Value * 0.01f;
                float[][] colorMatrixElements = {
	                                                new float[] {	1,		0,		0,		0,		0	},
	                                                new float[] {	0,		1,		0,		0,		0	},
	                                                new float[] {	0,		0,		1,		0,		0	},
	                                                new float[] {	0,		0,		0,		1,		0	},
	                                                new float[] {	value,		value,		value,		0,		1	}
                                                };
                ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                ImageAttributes imageAttributes = new ImageAttributes();

                imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                Image _img = Img3;

                Graphics _g = default(Graphics);
                Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                _g = Graphics.FromImage(bm_dest);
                _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                eyebrowholder.Image = bm_dest;
            }
            if (nose_Clicked)
            {
                float value = brightSlider.Value * 0.01f;
                float[][] colorMatrixElements = {
	                                                new float[] {	1,		0,		0,		0,		0	},
	                                                new float[] {	0,		1,		0,		0,		0	},
	                                                new float[] {	0,		0,		1,		0,		0	},
	                                                new float[] {	0,		0,		0,		1,		0	},
	                                                new float[] {	value,		value,		value,		0,		1	}
                                                };
                ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                ImageAttributes imageAttributes = new ImageAttributes();

                imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                Image _img = Img4;

                Graphics _g = default(Graphics);
                Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                _g = Graphics.FromImage(bm_dest);
                _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                noseholder.Image = bm_dest;
            }
            if (lip_Clicked)
            {
                float value = brightSlider.Value * 0.01f;
                float[][] colorMatrixElements = {
	                                                new float[] {	1,		0,		0,		0,		0	},
	                                                new float[] {	0,		1,		0,		0,		0	},
	                                                new float[] {	0,		0,		1,		0,		0	},
	                                                new float[] {	0,		0,		0,		1,		0	},
	                                                new float[] {	value,		value,		value,		0,		1	}
                                                };
                ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                ImageAttributes imageAttributes = new ImageAttributes();

                imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                Image _img = Img5;

                Graphics _g = default(Graphics);
                Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                _g = Graphics.FromImage(bm_dest);
                _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                lipholder.Image = bm_dest;
            }
           
            if (hair_Clicked)
            {
                float value = brightSlider.Value * 0.01f;
                float[][] colorMatrixElements = {
	                                                new float[] {	1,		0,		0,		0,		0	},
	                                                new float[] {	0,		1,		0,		0,		0	},
	                                                new float[] {	0,		0,		1,		0,		0	},
	                                                new float[] {	0,		0,		0,		1,		0	},
	                                                new float[] {	value,		value,		value,		0,		1	}
                                                };
                ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                ImageAttributes imageAttributes = new ImageAttributes();

                imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                Image _img = Img6;

                Graphics _g = default(Graphics);
                Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                _g = Graphics.FromImage(bm_dest);
                _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                hairholder.Image = bm_dest;
            }
            if (much_Clicked)
            {
                float value = brightSlider.Value * 0.01f;
                float[][] colorMatrixElements = {
	                                                new float[] {	1,		0,		0,		0,		0	},
	                                                new float[] {	0,		1,		0,		0,		0	},
	                                                new float[] {	0,		0,		1,		0,		0	},
	                                                new float[] {	0,		0,		0,		1,		0	},
	                                                new float[] {	value,		value,		value,		0,		1	}
                                                };
                ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                ImageAttributes imageAttributes = new ImageAttributes();

                imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                Image _img = Img7;

                Graphics _g = default(Graphics);
                Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                _g = Graphics.FromImage(bm_dest);
                _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                mholder.Image = bm_dest;
            }
        }
        //-----------------------------features Resize------------------------------//
        private void resize_Click(object sender, EventArgs e)
        {

            if (resize_panel.Visible == false)
            {
                resize_panel.Visible = true;
                background_panel.Controls.Add(resize_panel);
            }
            else
            {
                resize_panel.Visible = false;
            }
        }
        //------------------------Capture Image-------------------------------------//
        private void capture_Click(object sender, EventArgs e)
        {
            capture_panel.Visible = true;
            Bitmap bmp = new Bitmap(this.face_panel.Width, this.face_panel.Height);
            this.face_panel.DrawToBitmap(bmp, new Rectangle(0, 0, this.face_panel.Width, this.face_panel.Height));
            capture_pic.Image = bmp;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            capture_pic.Image = null;
            capture_panel.Visible = false;
        }

        //--------------------------- Image Effects -------------------------------//

        private void effects_btn_Click(object sender, EventArgs e)
        {
            if (effects_panel.Visible == false)
            {
                effects_panel.Visible = true;
                background_panel.Controls.Add(effects_panel);
            }
            else
            {
                effects_panel.Visible = false;

            }        
        }
      
        Boolean opened = true;
        void redscale()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = capture_pic.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{.393f, .349f, .272f, 0, 0},
            new float[]{.769f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                capture_pic.Image = bmpInverted;

            }
        }
        void reload()
        {
            if (!opened)
            {
                // MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                if (opened)
                {
                    //file = Image.FromFile(openFileDialog1.FileName);
                    capture_pic.Image = capture_pic.Image;
                    opened = true;
                }
            }
        }
        void winter()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = capture_pic.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{1,0,0,0,0},
                    new float[]{0,1,0,0,0},
                    new float[]{0,0,1,0,0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 1, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                capture_pic.Image = bmpInverted;

            }
        }
        void fog()
        {

            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = capture_pic.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{1+0.3f, 0, 0, 0, 0},
            new float[]{0, 1+0.7f, 0, 0, 0},
            new float[]{0, 0, 1+1.3f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
 
                 * format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                capture_pic.Image = bmpInverted;
            }
        }
        void flash()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = capture_pic.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{1+0.9f, 0, 0, 0, 0},
            new float[]{0, 1+1.5f, 0, 0, 0},
            new float[]{0, 0, 1+1.3f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                capture_pic.Image = bmpInverted;

            }

        }
        void Frozen()
        {

            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = capture_pic.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{1+0.3f, 0, 0, 0, 0},
            new float[]{0, 1+0f, 0, 0, 0},
            new float[]{0, 0, 1+5f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                capture_pic.Image = bmpInverted;

            }

        }
        void filter2()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = capture_pic.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{.393f, .349f+0.5f, .272f, 0, 0},
            new float[]{.769f+0.3f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f+0.5f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                capture_pic.Image = bmpInverted;

            }
        }
        void filter3()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = capture_pic.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{.393f+0.3f, .349f, .272f, 0, 0},
            new float[]{.769f, .686f+0.2f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f+0.9f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                capture_pic.Image = bmpInverted;

            }
        }

        private void suji_Click(object sender, EventArgs e)
        {
            reload();
            filter2(); 
            effects_panel.Hide(); 
        }

        private void spike_Click(object sender, EventArgs e)
        {
            reload();  
            fog();
            effects_panel.Hide();
        }

        private void Sepia_Click(object sender, EventArgs e)
        {
            reload(); 
            redscale(); 
            effects_panel.Hide();
        }

        private void none_Click(object sender, EventArgs e)
        {
            reload();
            effects_panel.Hide();
        }

        private void flashbtn_Click(object sender, EventArgs e)
        {
            reload(); 
            flash();
           effects_panel.Hide();
        }

        private void frobtn_Click(object sender, EventArgs e)
        {
            reload();
            Frozen(); 
            effects_panel.Hide();
        }

        private void dramatic_Click(object sender, EventArgs e)
        {
            reload();
            filter3(); 
             effects_panel.Hide();
        }

        private void artistic_Click(object sender, EventArgs e)
        {
            reload();
            winter();
            effects_panel.Hide();
        }
        // save button on image capture...........
        private void save_btn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfdlg = new SaveFileDialog())
            {
                sfdlg.Title = "Save Dialog";
                sfdlg.Filter = "PNG Images (*.png)|*.png|All files(*.*)|*.*";
                if (sfdlg.ShowDialog(this) == DialogResult.OK)
                {
                    using (Bitmap bmp = new Bitmap(capture_pic.Width, capture_pic.Height))
                    {
                        capture_pic.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                        capture_pic.Image = new Bitmap(capture_pic.Width, capture_pic.Height);
                       capture_pic.Image.Save("E://Untitled.png");
                        bmp.Save(sfdlg.FileName);
                        MessageBox.Show("Saved Successfully.....");

                    }
                }
            }
        }

        // menu strip of the application...........

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog sfdlg = new SaveFileDialog())
            {
                sfdlg.Title = "Save Dialog";
                sfdlg.Filter = "PNG Images (*.png)|*.png|All files(*.*)|*.*";
                if (sfdlg.ShowDialog(this) == DialogResult.OK)
                {
                    using (Bitmap bmp = new Bitmap(capture_pic.Width, capture_pic.Height))
                    {
                        capture_pic.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                        capture_pic.Image = new Bitmap(capture_pic.Width, capture_pic.Height);
                        capture_pic.Image.Save("E://Untitled.png");
                        bmp.Save(sfdlg.FileName);
                        MessageBox.Show("Saved Successfully.....");

                    }
                }
            }
        }
        
        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            selected_feature.Controls.Clear();
            workplace.Image = null;
            eyeholder.Image = null;
            noseholder.Image = null;
            eyebrowholder.Image = null;
            hairholder.Image = null;
            face_panel.Visible = true;
        }
        
        private void erasor_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void brush_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void capture_pic_MouseDown(object sender, MouseEventArgs e)
        {
             lastPoint = e.Location;//we assign the lastPoint to the current mouse position: e.Location ('e' is from the MouseEventArgs passed into the MouseDown event)

            isMouseDown = true;//we set to true because our mouse button is down (clicked)
 
        }

        private void capture_pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)//check to see if the mouse button is down
            {

                if (lastPoint != null)//if our last point is not null, which in this case we have assigned above
                {

                    if (capture_pic.Image == null)//if no available bitmap exists on the picturebox to draw on
                    {
                        //create a new bitmap
                        Bitmap bmp = new Bitmap(capture_pic.Width, capture_pic.Height);

                        capture_pic.Image = bmp; //assign the picturebox.Image property to the bitmap created

                    }

                    using (Graphics g = Graphics.FromImage(capture_pic.Image))
                    {//we need to create a Graphics object to draw on the picture box, its our main tool

                        //when making a Pen object, you can just give it color only or give it color and pen size

                        g.DrawLine(new Pen(Color.Black, 5), lastPoint, e.Location);
                        g.SmoothingMode = SmoothingMode.Default;
                        //this is to give the drawing a more smoother, less sharper look

                    }

                    capture_pic.Invalidate();//refreshes the picturebox

                    lastPoint = e.Location;//keep assigning the lastPoint to the current mouse position

                }
            }
        }

        private void capture_pic_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;

            lastPoint = Point.Empty;

            //set the previous point back to null if the user lets 
        }

        private void width_btn_Click(object sender, EventArgs e)
        {
            if (head_Clicked)
            {
                Size size = workplace.Size;
                size.Width--;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void text_btn_Click(object sender, EventArgs e)
        {
            imgnametext.Show();
        }

        private void imgnametext_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = imgnametext.Text;
        }

        private void imgnametext_Enter_1(object sender, EventArgs e)
        {
            if (imgnametext.Text == "Enter Image Name and details here...")
            {
                imgnametext.Text = "";
                imgnametext.ForeColor = Color.Black;

            }
        }
        
        }

    }

 

       

        
        

      

       

           

    



