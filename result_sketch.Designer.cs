namespace FSKETCH_V2
{
    partial class result_sketch
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
            this.workplace = new System.Windows.Forms.PictureBox();
            this.eyeholder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.workplace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeholder)).BeginInit();
            this.SuspendLayout();
            // 
            // workplace
            // 
            this.workplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workplace.Location = new System.Drawing.Point(12, 12);
            this.workplace.Name = "workplace";
            this.workplace.Size = new System.Drawing.Size(457, 733);
            this.workplace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.workplace.TabIndex = 0;
            this.workplace.TabStop = false;
            // 
            // eyeholder
            // 
            this.eyeholder.Location = new System.Drawing.Point(111, 295);
            this.eyeholder.Name = "eyeholder";
            this.eyeholder.Size = new System.Drawing.Size(242, 104);
            this.eyeholder.TabIndex = 1;
            this.eyeholder.TabStop = false;
            this.eyeholder.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // result_sketch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(476, 733);
            this.Controls.Add(this.eyeholder);
            this.Controls.Add(this.workplace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "result_sketch";
            this.Text = "result_sketch";
            this.Load += new System.EventHandler(this.result_sketch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workplace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeholder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox workplace;
        public System.Windows.Forms.PictureBox eyeholder;

    }
}