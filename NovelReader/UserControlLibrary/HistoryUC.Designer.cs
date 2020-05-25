namespace NovelReader.UserControlLibrary
{
    partial class HistoryUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.historydatagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NovelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreviousChapterLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Read = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.historydatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // historydatagridview
            // 
            this.historydatagridview.AllowUserToAddRows = false;
            this.historydatagridview.AllowUserToDeleteRows = false;
            this.historydatagridview.AllowUserToResizeColumns = false;
            this.historydatagridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.historydatagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.historydatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historydatagridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.historydatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historydatagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.historydatagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historydatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.historydatagridview.ColumnHeadersHeight = 21;
            this.historydatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.historydatagridview.ColumnHeadersVisible = false;
            this.historydatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NovelName,
            this.PreviousChapterLink,
            this.Source,
            this.Read,
            this.Remove});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historydatagridview.DefaultCellStyle = dataGridViewCellStyle6;
            this.historydatagridview.EnableHeadersVisualStyles = false;
            this.historydatagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.historydatagridview.Location = new System.Drawing.Point(13, 16);
            this.historydatagridview.Name = "historydatagridview";
            this.historydatagridview.RowHeadersVisible = false;
            this.historydatagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.historydatagridview.RowTemplate.Height = 40;
            this.historydatagridview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historydatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historydatagridview.Size = new System.Drawing.Size(748, 587);
            this.historydatagridview.TabIndex = 26;
            this.historydatagridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.historydatagridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.historydatagridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.historydatagridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.historydatagridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.historydatagridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.historydatagridview.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.historydatagridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.historydatagridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.historydatagridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.historydatagridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.historydatagridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.historydatagridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.historydatagridview.ThemeStyle.HeaderStyle.Height = 21;
            this.historydatagridview.ThemeStyle.ReadOnly = false;
            this.historydatagridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.historydatagridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.historydatagridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.historydatagridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.historydatagridview.ThemeStyle.RowsStyle.Height = 40;
            this.historydatagridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.historydatagridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.historydatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historydatagridview_CellContentClick);
            // 
            // NovelName
            // 
            this.NovelName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NovelName.HeaderText = "Novel Name";
            this.NovelName.MinimumWidth = 400;
            this.NovelName.Name = "NovelName";
            this.NovelName.ReadOnly = true;
            this.NovelName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NovelName.Width = 400;
            // 
            // PreviousChapterLink
            // 
            this.PreviousChapterLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PreviousChapterLink.DefaultCellStyle = dataGridViewCellStyle3;
            this.PreviousChapterLink.HeaderText = "Chapter Link";
            this.PreviousChapterLink.Name = "PreviousChapterLink";
            this.PreviousChapterLink.Visible = false;
            // 
            // Source
            // 
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            this.Source.Visible = false;
            // 
            // Read
            // 
            this.Read.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "Read";
            this.Read.DefaultCellStyle = dataGridViewCellStyle4;
            this.Read.FillWeight = 50.76142F;
            this.Read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Read.HeaderText = "";
            this.Read.MinimumWidth = 150;
            this.Read.Name = "Read";
            this.Read.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Read.Width = 174;
            // 
            // Remove
            // 
            this.Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "Remove";
            this.Remove.DefaultCellStyle = dataGridViewCellStyle5;
            this.Remove.FillWeight = 50.76142F;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.HeaderText = "";
            this.Remove.MinimumWidth = 150;
            this.Remove.Name = "Remove";
            this.Remove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Remove.Width = 174;
            // 
            // HistoryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.Controls.Add(this.historydatagridview);
            this.DoubleBuffered = true;
            this.Name = "HistoryUC";
            this.Size = new System.Drawing.Size(774, 621);
            this.Load += new System.EventHandler(this.HistoryUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historydatagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView historydatagridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn NovelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreviousChapterLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewButtonColumn Read;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
    }
}
