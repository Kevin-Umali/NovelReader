using System;
using System.Linq;
using System.Windows.Forms;

namespace NovelReader.FormsLibrary
{
    public partial class MainForm : Form
    {
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm();
        public MainForm()
        {
            InitializeComponent();

            shadowForm.SetShadowForm(this);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DisposeandAdd(new UserControlLibrary.BrowseNovelUC());
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            DisposeandAdd(new UserControlLibrary.BrowseNovelUC());
        }
        private void DisposeandAdd(UserControl uc)
        {
            mainpanel.Controls.Clear();
            foreach (UserControl aa in mainpanel.Controls)
            {
                aa.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }

            uc.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(uc);
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            DisposeandAdd(new UserControlLibrary.FavoriteNovelsUC());
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            DisposeandAdd(new UserControlLibrary.HistoryUC());
        }

        public void LoadDownload(UserControl uc)
        {
            downloadpanel.Controls.Clear();
            foreach (UserControl aa in downloadpanel.Controls)
            {
                aa.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }

            downloadpanel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        public bool CheckDownload()
        {
            if (downloadpanel.Controls.Count < 1)
                return true;
            else
                return false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ChangeLogsForm>().Count() == 0)
            {
                ChangeLogsForm frm = new ChangeLogsForm();
                frm.Show();
            }
        }
    }
}
