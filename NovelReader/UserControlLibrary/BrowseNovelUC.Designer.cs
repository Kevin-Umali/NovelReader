namespace NovelReader.UserControlLibrary
{
    partial class BrowseNovelUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseNovelUC));
            this.rdoWuxiaWorldSite = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoBoxnovel = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.noItempanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.noItempanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoWuxiaWorldSite
            // 
            this.rdoWuxiaWorldSite.AutoSize = true;
            this.rdoWuxiaWorldSite.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoWuxiaWorldSite.CheckedState.BorderThickness = 0;
            this.rdoWuxiaWorldSite.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoWuxiaWorldSite.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoWuxiaWorldSite.CheckedState.InnerOffset = -4;
            this.rdoWuxiaWorldSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoWuxiaWorldSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoWuxiaWorldSite.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.rdoWuxiaWorldSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.rdoWuxiaWorldSite.Location = new System.Drawing.Point(95, 64);
            this.rdoWuxiaWorldSite.Name = "rdoWuxiaWorldSite";
            this.rdoWuxiaWorldSite.Size = new System.Drawing.Size(119, 21);
            this.rdoWuxiaWorldSite.TabIndex = 18;
            this.rdoWuxiaWorldSite.Tag = "1";
            this.rdoWuxiaWorldSite.Text = "WuxiaWorld.Site";
            this.rdoWuxiaWorldSite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoWuxiaWorldSite.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoWuxiaWorldSite.UncheckedState.BorderThickness = 2;
            this.rdoWuxiaWorldSite.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoWuxiaWorldSite.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoWuxiaWorldSite.UseVisualStyleBackColor = true;
            this.rdoWuxiaWorldSite.CheckedChanged += new System.EventHandler(this.rdoWuxiaWorldSite_CheckedChanged);
            // 
            // rdoBoxnovel
            // 
            this.rdoBoxnovel.AutoSize = true;
            this.rdoBoxnovel.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoBoxnovel.CheckedState.BorderThickness = 0;
            this.rdoBoxnovel.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoBoxnovel.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoBoxnovel.CheckedState.InnerOffset = -4;
            this.rdoBoxnovel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoBoxnovel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoBoxnovel.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.rdoBoxnovel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.rdoBoxnovel.Location = new System.Drawing.Point(12, 64);
            this.rdoBoxnovel.Name = "rdoBoxnovel";
            this.rdoBoxnovel.Size = new System.Drawing.Size(77, 21);
            this.rdoBoxnovel.TabIndex = 16;
            this.rdoBoxnovel.Tag = "0";
            this.rdoBoxnovel.Text = "Boxnovel";
            this.rdoBoxnovel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoBoxnovel.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoBoxnovel.UncheckedState.BorderThickness = 2;
            this.rdoBoxnovel.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoBoxnovel.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoBoxnovel.UseVisualStyleBackColor = true;
            this.rdoBoxnovel.CheckedChanged += new System.EventHandler(this.rdoWuxiaWorldSite_CheckedChanged);
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
            this.btnSearch.TabIndex = 1;
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
            this.txtSearch.PlaceholderText = "Search Light Novel to Read.";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(177)))));
            this.txtSearch.ShadowDecoration.Depth = 20;
            this.txtSearch.ShadowDecoration.Enabled = true;
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 3);
            this.txtSearch.Size = new System.Drawing.Size(595, 44);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblresult
            // 
            this.lblresult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblresult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblresult.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblresult.Location = new System.Drawing.Point(613, 60);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(150, 25);
            this.lblresult.TabIndex = 13;
            this.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 91);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(753, 455);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 546);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 75);
            this.panel1.TabIndex = 20;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.AutoRoundedCorners = true;
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BorderColor = System.Drawing.Color.Empty;
            this.btnPrev.BorderRadius = 21;
            this.btnPrev.CheckedState.Parent = this.btnPrev;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.CustomImages.Parent = this.btnPrev;
            this.btnPrev.FillColor = System.Drawing.Color.White;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnPrev.ForeColor = System.Drawing.Color.Black;
            this.btnPrev.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnPrev.HoverState.Parent = this.btnPrev;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(440, 16);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnPrev.ShadowDecoration.BorderRadius = 21;
            this.btnPrev.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnPrev.ShadowDecoration.Depth = 20;
            this.btnPrev.ShadowDecoration.Enabled = true;
            this.btnPrev.ShadowDecoration.Parent = this.btnPrev;
            this.btnPrev.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnPrev.Size = new System.Drawing.Size(158, 45);
            this.btnPrev.TabIndex = 12;
            this.btnPrev.Text = "Previous Page";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.AutoRoundedCorners = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderColor = System.Drawing.Color.Empty;
            this.btnNext.BorderRadius = 21;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.FillColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageOffset = new System.Drawing.Point(40, 0);
            this.btnNext.Location = new System.Drawing.Point(604, 16);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnNext.ShadowDecoration.BorderRadius = 21;
            this.btnNext.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnNext.ShadowDecoration.Depth = 20;
            this.btnNext.ShadowDecoration.Enabled = true;
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnNext.Size = new System.Drawing.Size(158, 45);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next Page";
            this.btnNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNext.TextOffset = new System.Drawing.Point(20, 0);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaVScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.gunaVScrollBar1.HighlightOnWheel = true;
            this.gunaVScrollBar1.LargeChange = 2;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(764, 91);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.MouseWheelBarPartitions = 1;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.gunaVScrollBar1.Size = new System.Drawing.Size(10, 455);
            this.gunaVScrollBar1.TabIndex = 21;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(194)))), ((int)(((byte)(228)))));
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(194)))), ((int)(((byte)(228)))));
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(194)))), ((int)(((byte)(228)))));
            this.gunaVScrollBar1.ThumbSize = 100;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // noItempanel
            // 
            this.noItempanel.Controls.Add(this.label4);
            this.noItempanel.Controls.Add(this.label3);
            this.noItempanel.Controls.Add(this.label1);
            this.noItempanel.Controls.Add(this.pictureBox2);
            this.noItempanel.Location = new System.Drawing.Point(10, 91);
            this.noItempanel.Name = "noItempanel";
            this.noItempanel.Size = new System.Drawing.Size(745, 452);
            this.noItempanel.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Komoda", 27.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(221)))));
            this.label4.Location = new System.Drawing.Point(31, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 86);
            this.label4.TabIndex = 17;
            this.label4.Text = "Change the source if it\'s still not working";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Komoda", 27.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(30, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 85);
            this.label3.TabIndex = 16;
            this.label3.Text = "Try to visit the source site or reload this application";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(745, 452);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // BrowseNovelUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.rdoWuxiaWorldSite);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.rdoBoxnovel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.noItempanel);
            this.DoubleBuffered = true;
            this.Name = "BrowseNovelUC";
            this.Size = new System.Drawing.Size(774, 621);
            this.Load += new System.EventHandler(this.BrowseNovelUC_Load);
            this.panel1.ResumeLayout(false);
            this.noItempanel.ResumeLayout(false);
            this.noItempanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2RadioButton rdoWuxiaWorldSite;
        private Guna.UI2.WinForms.Guna2RadioButton rdoBoxnovel;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel noItempanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
