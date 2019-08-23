namespace FSKETCH_V2
{
    partial class select
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
            this.GradientPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.female_btn = new System.Windows.Forms.Button();
            this.male_btn = new System.Windows.Forms.Button();
            this.close_lbl = new System.Windows.Forms.Label();
            this.female_sketch = new System.Windows.Forms.PictureBox();
            this.male_sketch = new System.Windows.Forms.PictureBox();
            this.min_lbl = new System.Windows.Forms.Label();
            this.GradientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.female_sketch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.male_sketch)).BeginInit();
            this.SuspendLayout();
            // 
            // GradientPanel
            // 
            this.GradientPanel.Controls.Add(this.min_lbl);
            this.GradientPanel.Controls.Add(this.label1);
            this.GradientPanel.Controls.Add(this.female_btn);
            this.GradientPanel.Controls.Add(this.male_btn);
            this.GradientPanel.Controls.Add(this.close_lbl);
            this.GradientPanel.Controls.Add(this.female_sketch);
            this.GradientPanel.Controls.Add(this.male_sketch);
            this.GradientPanel.Location = new System.Drawing.Point(0, 3);
            this.GradientPanel.Name = "GradientPanel";
            this.GradientPanel.Size = new System.Drawing.Size(508, 366);
            this.GradientPanel.TabIndex = 0;
            this.GradientPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GradientPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Face Sketch";
            // 
            // female_btn
            // 
            this.female_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.female_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.female_btn.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_btn.ForeColor = System.Drawing.Color.White;
            this.female_btn.Location = new System.Drawing.Point(270, 218);
            this.female_btn.Name = "female_btn";
            this.female_btn.Size = new System.Drawing.Size(120, 32);
            this.female_btn.TabIndex = 4;
            this.female_btn.Text = "Female";
            this.female_btn.UseVisualStyleBackColor = false;
            this.female_btn.Click += new System.EventHandler(this.female_btn_Click);
            // 
            // male_btn
            // 
            this.male_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.male_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.male_btn.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_btn.ForeColor = System.Drawing.Color.White;
            this.male_btn.Location = new System.Drawing.Point(95, 218);
            this.male_btn.Name = "male_btn";
            this.male_btn.Size = new System.Drawing.Size(120, 32);
            this.male_btn.TabIndex = 3;
            this.male_btn.Text = "Male";
            this.male_btn.UseVisualStyleBackColor = false;
            this.male_btn.Click += new System.EventHandler(this.male_btn_Click);
            // 
            // close_lbl
            // 
            this.close_lbl.AutoSize = true;
            this.close_lbl.BackColor = System.Drawing.Color.Transparent;
            this.close_lbl.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_lbl.ForeColor = System.Drawing.Color.White;
            this.close_lbl.Location = new System.Drawing.Point(466, 14);
            this.close_lbl.Name = "close_lbl";
            this.close_lbl.Size = new System.Drawing.Size(25, 25);
            this.close_lbl.TabIndex = 2;
            this.close_lbl.Text = "X";
            this.close_lbl.Click += new System.EventHandler(this.close_lbl_Click);
            // 
            // female_sketch
            // 
            this.female_sketch.Image = global::FSKETCH_V2.Properties.Resources.female1;
            this.female_sketch.Location = new System.Drawing.Point(270, 91);
            this.female_sketch.Name = "female_sketch";
            this.female_sketch.Size = new System.Drawing.Size(120, 120);
            this.female_sketch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.female_sketch.TabIndex = 1;
            this.female_sketch.TabStop = false;
            // 
            // male_sketch
            // 
            this.male_sketch.Image = global::FSKETCH_V2.Properties.Resources.male;
            this.male_sketch.Location = new System.Drawing.Point(95, 91);
            this.male_sketch.Name = "male_sketch";
            this.male_sketch.Size = new System.Drawing.Size(120, 120);
            this.male_sketch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.male_sketch.TabIndex = 0;
            this.male_sketch.TabStop = false;
            // 
            // min_lbl
            // 
            this.min_lbl.AutoSize = true;
            this.min_lbl.BackColor = System.Drawing.Color.Transparent;
            this.min_lbl.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_lbl.ForeColor = System.Drawing.Color.White;
            this.min_lbl.Location = new System.Drawing.Point(435, 3);
            this.min_lbl.Name = "min_lbl";
            this.min_lbl.Size = new System.Drawing.Size(24, 36);
            this.min_lbl.TabIndex = 6;
            this.min_lbl.Text = "-";
            this.min_lbl.Click += new System.EventHandler(this.min_lbl_Click);
            // 
            // select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(509, 372);
            this.Controls.Add(this.GradientPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "select";
            this.GradientPanel.ResumeLayout(false);
            this.GradientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.female_sketch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.male_sketch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GradientPanel;
        private System.Windows.Forms.PictureBox female_sketch;
        private System.Windows.Forms.PictureBox male_sketch;
        private System.Windows.Forms.Label close_lbl;
        private System.Windows.Forms.Button male_btn;
        private System.Windows.Forms.Button female_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label min_lbl;


    }
}