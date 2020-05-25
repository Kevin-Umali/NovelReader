namespace NovelReader.UserControlLibrary.Cards
{
    partial class DownloadCard
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(194)))), ((int)(((byte)(228)))));
            this.label1.Location = new System.Drawing.Point(3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Starting...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.guna2ProgressBar1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.guna2ProgressBar1.ForeColor = System.Drawing.Color.White;
            this.guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(6, 40);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(194)))), ((int)(((byte)(228)))));
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.guna2ProgressBar1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(194)))), ((int)(((byte)(228)))));
            this.guna2ProgressBar1.ShadowDecoration.Enabled = true;
            this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
            this.guna2ProgressBar1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.guna2ProgressBar1.ShowPercentage = true;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(197, 24);
            this.guna2ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.guna2ProgressBar1.TabIndex = 6;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(169, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "STOP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(194)))), ((int)(((byte)(228)))));
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "{Title}";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DownloadCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ProgressBar1);
            this.DoubleBuffered = true;
            this.Name = "DownloadCard";
            this.Size = new System.Drawing.Size(206, 94);
            this.Load += new System.EventHandler(this.DownloadCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
