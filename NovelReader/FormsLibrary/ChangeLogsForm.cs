using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelReader.FormsLibrary
{
    public partial class ChangeLogsForm : Form
    {
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm();
        private Guna.UI.Lib.ScrollBar.PanelScrollHelper vscrollHelper;
        public ChangeLogsForm()
        {
            InitializeComponent();
            shadowForm.SetShadowForm(this);
        }

        private void ChangeLogsForm_Load(object sender, EventArgs e)
        {
            vscrollHelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flowLayoutPanel1, gunaVScrollBar1, true);
        }
    }
}
