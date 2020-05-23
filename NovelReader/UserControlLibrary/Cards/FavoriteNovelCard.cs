using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelReader.UserControlLibrary.Cards
{
    public partial class FavoriteNovelCard : UserControl
    {
        public string _title = string.Empty,
            _novellink = string.Empty,
            _imglink = string.Empty;
        int _sourcesite;
        public FavoriteNovelCard(int sourcesite)
        {
            InitializeComponent();
            _sourcesite = sourcesite;
        }
        public FavoriteNovelCard SendFavoriteNovelCardData(string title, string novellink, string imglink)
        {
            _title = title;
            _novellink = novellink;
            _imglink = imglink;

            return this;
        }
        private void FavoriteNovelCard_Load(object sender, EventArgs e)
        {
            lbltitle.Text = _title;
            if (!string.IsNullOrEmpty(_imglink))
                pictureBox1.LoadAsync(_imglink);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NovelInformationForm f1 = new NovelInformationForm(_title, _novellink, "0", _sourcesite);
            f1.ShowDialog();
            f1.pictureBox1.Dispose();
            f1.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        ~FavoriteNovelCard()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
