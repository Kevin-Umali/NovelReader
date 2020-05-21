namespace NovelReader.UserControlLibrary
{
    partial class NovelCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lbllatestchapter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblrating = new System.Windows.Forms.Label();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoEllipsis = true;
            this.lbltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.lbltitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(0, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(186, 56);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "{Title}";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbllatestchapter
            // 
            this.lbllatestchapter.AutoEllipsis = true;
            this.lbllatestchapter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbllatestchapter.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbllatestchapter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.lbllatestchapter.Location = new System.Drawing.Point(94, 233);
            this.lbllatestchapter.Name = "lbllatestchapter";
            this.lbllatestchapter.Size = new System.Drawing.Size(87, 17);
            this.lbllatestchapter.TabIndex = 2;
            this.lbllatestchapter.Text = "{Chapter}";
            this.lbllatestchapter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.label1.Location = new System.Drawing.Point(3, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Latest Chapter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.label2.Location = new System.Drawing.Point(3, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rating: ";
            // 
            // lblrating
            // 
            this.lblrating.AutoSize = true;
            this.lblrating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblrating.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblrating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.lblrating.Location = new System.Drawing.Point(134, 212);
            this.lblrating.Name = "lblrating";
            this.lblrating.Size = new System.Drawing.Size(53, 17);
            this.lblrating.TabIndex = 4;
            this.lblrating.Text = "{Rating}";
            this.lblrating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.guna2RatingStar1.BorderThickness = 1;
            this.guna2RatingStar1.Enabled = false;
            this.guna2RatingStar1.Location = new System.Drawing.Point(49, 210);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.Size = new System.Drawing.Size(88, 23);
            this.guna2RatingStar1.TabIndex = 35;
            // 
            // NovelCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.Controls.Add(this.lblrating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbllatestchapter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.guna2RatingStar1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.Name = "NovelCard";
            this.Size = new System.Drawing.Size(186, 259);
            this.Load += new System.EventHandler(this.NovelCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lbllatestchapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblrating;
        public System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
    }
}
