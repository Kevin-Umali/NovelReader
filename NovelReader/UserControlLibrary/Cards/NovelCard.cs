using System;
using System.Windows.Forms;

namespace NovelReader.UserControlLibrary.Cards
{
    public partial class NovelCard : UserControl
    {
        public string _title = string.Empty,
            _latestchapter = string.Empty, _link = string.Empty, 
            _imglink = string.Empty, _rating = string.Empty;

        int _sourcesite;

        private void lbltitle_Click(object sender, EventArgs e)
        {
            NovelInformationForm f1 = new NovelInformationForm(_title, _link, _rating, _sourcesite);
            f1.ShowDialog();
            f1.pictureBox1.Dispose();
            f1.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        //private readonly Color[] colors = { Color.FromArgb(234, 240, 255), Color.FromArgb(255, 245, 236) };
        public NovelCard(int sourcesite)
        {
            InitializeComponent();
            _sourcesite = sourcesite;
        }
        public NovelCard SendNovelCardData(string title, string latestchapter, string link, string imglink, string rating)
        {
            _title = title;
            _latestchapter = latestchapter;
            _link = link;
            _imglink = imglink;
            _rating = rating;

            return this;
        }

        private void NovelCard_Load(object sender, EventArgs e)
        {
            lbltitle.Text = _title;
            lbllatestchapter.Text = _latestchapter;
            lblrating.Text = _rating;

            guna2RatingStar1.Value = float.Parse(_rating);

            if (!string.IsNullOrEmpty(_imglink))
                pictureBox1.LoadAsync(_imglink);
        }

        ~NovelCard()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
