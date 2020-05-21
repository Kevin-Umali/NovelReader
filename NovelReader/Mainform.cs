using NovelReaderWebScrapper.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelReader
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
    }
}
