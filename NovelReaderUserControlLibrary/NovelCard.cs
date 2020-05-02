using System;
using System.Drawing;
using System.Windows.Forms;

namespace NovelReaderUserControlLibrary
{
    public partial class NovelCard : UserControl
    {
        public string _title, _latestchapter, _link, _imglink, _rating = string.Empty;
        private readonly Color[] colors = { Color.FromArgb(234, 240, 255), Color.FromArgb(255, 245, 236) };
        public NovelCard()
        {
            InitializeComponent();
        }
        public void SendNovelCardData(string title, string latestchapter, string link, string imglink, string rating, int val)
        {
            _title = title;
            _latestchapter = latestchapter;
            _link = link;
            _imglink = imglink;
            _rating = rating;
            //this.BackColor = colors[val];
        }

        private void NovelCard_Load(object sender, EventArgs e)
        {
            lbltitle.Text = _title;
            lbllatestchapter.Text = _latestchapter;
            lblrating.Text = _rating;

            guna2RatingStar1.Value = float.Parse(_rating);

            if (!string.IsNullOrEmpty(_imglink))
                pictureBox1.Load(_imglink);
        }
    }
}
