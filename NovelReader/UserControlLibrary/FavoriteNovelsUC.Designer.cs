namespace NovelReader.UserControlLibrary
{
    partial class FavoriteNovelsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoriteNovelsUC));
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.noItempanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.noItempanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Komoda", 27.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(30, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 46);
            this.label3.TabIndex = 16;
            this.label3.Text = "Add novels to your favorite";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(745, 545);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // noItempanel
            // 
            this.noItempanel.Controls.Add(this.label3);
            this.noItempanel.Controls.Add(this.label1);
            this.noItempanel.Controls.Add(this.pictureBox2);
            this.noItempanel.Location = new System.Drawing.Point(10, 64);
            this.noItempanel.Name = "noItempanel";
            this.noItempanel.Size = new System.Drawing.Size(745, 545);
            this.noItempanel.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Komoda", 50.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 76);
            this.label1.TabIndex = 15;
            this.label1.Text = "no novel found";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaVScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.gunaVScrollBar1.HighlightOnWheel = true;
            this.gunaVScrollBar1.LargeChange = 2;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(764, 64);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.MouseWheelBarPartitions = 1;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.gunaVScrollBar1.Size = new System.Drawing.Size(10, 545);
            this.gunaVScrollBar1.TabIndex = 32;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(194)))), ((int)(((byte)(228)))));
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(194)))), ((int)(((byte)(228)))));
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(194)))), ((int)(((byte)(228)))));
            this.gunaVScrollBar1.ThumbSize = 100;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(753, 545);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSearch.BorderThickness = 2;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnSearch.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(613, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSearch.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSearch.ShadowDecoration.Depth = 20;
            this.btnSearch.ShadowDecoration.Enabled = true;
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnSearch.Size = new System.Drawing.Size(150, 44);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.Color.Empty;
            this.txtSearch.BorderThickness = 0;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.Location = new System.Drawing.Point(12, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtSearch.PlaceholderText = "Search Light Novel in your favorites";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(177)))));
            this.txtSearch.ShadowDecoration.Depth = 20;
            this.txtSearch.ShadowDecoration.Enabled = true;
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 3);
            this.txtSearch.Size = new System.Drawing.Size(595, 44);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // FavoriteNovelsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.noItempanel);
            this.DoubleBuffered = true;
            this.Name = "FavoriteNovelsUC";
            this.Size = new System.Drawing.Size(774, 621);
            this.Load += new System.EventHandler(this.FavoriteNovelsUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.noItempanel.ResumeLayout(false);
            this.noItempanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel noItempanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}
