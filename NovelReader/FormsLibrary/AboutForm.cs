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
    public partial class AboutForm : Form
    {
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm();
        public AboutForm()
        {
            InitializeComponent();
            shadowForm.SetShadowForm(this);
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
