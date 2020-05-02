using NovelReaderWebScrapper.DataConstructor;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NovelReader
{
    public partial class NovelInformationForm : Form
    {
        string _title, _link, _rating = string.Empty;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm();
        public NovelInformationForm(string title, string link, string rating)
        {
            InitializeComponent();
            _title = title;
            _link = link;
            _rating = rating;
            shadowForm.SetShadowForm(this);
        }

        private void NovelInformationForm_Load(object sender, EventArgs e)
        {
            lbltitle.Text = _title;
            lblrating.Text = $"{_rating}";
            guna2RatingStar1.Value = float.Parse(_rating);
            NovelReaderWebScrapper.DataConstructor.NovelSummaryData NovelDataSummary
                = NovelReaderWebScrapper.Website.BoxNovelScrapper.GetBoxNovelSummary($"{_link}");

            lblauthor.Text = $"{NovelDataSummary.Author} - {NovelDataSummary.Artist}";
            lblgenre.Text = NovelDataSummary.Genre;
            lblrelease.Text = $"{NovelDataSummary.Release} - {NovelDataSummary.Status}";
            pictureBox1.LoadAsync(NovelDataSummary.ImgLink);

            lblsypnosis.Text = NovelReaderWebScrapper.Website.BoxNovelScrapper.GetBoxNovelSypnosis($"{_link}").Sypnosis.Trim().TrimStart();
        }
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            chapterdatagridview.Rows.Clear();
            chapterdatagridview.Refresh();

            List<NovelChapterData> ChapterDataList = new List<NovelChapterData>
                (NovelReaderWebScrapper
                .Website
                .BoxNovelScrapper
                .GetBoxNovelChapterList($"{_link}"));

            //Action<Tuple<string, string>> body = data =>
            //{
            //    guna2DataGridView1.Invoke(new Action(delegate ()
            //    {
            //        guna2DataGridView1.Rows.Add(new object[]
            //        {
            //            data.Item1,
            //            data.Item2,
            //            "Read Now"
            //        });
            //    }));
            //};
            //Parallel.ForEach(ChapterDataList, body);

            foreach (var item in ChapterDataList)
                await TaskAsync(item.ChapterName, item.DateRelease, item.ChapterLink).ConfigureAwait(false);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chapterdatagridview.Rows.Count >= 1)
            {
                if (e.ColumnIndex == 3)
                {
                    this.Hide();
                    NovelChapterReaderForm f1 = new NovelChapterReaderForm(chapterdatagridview.CurrentRow.Cells["Link"].Value.ToString());
                    f1.Closed += (s, args) => this.Close();
                    f1.ShowDialog();
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Still working on this. Please wait on the next update");
            //foreach (var item in NovelReaderWebScrapper.Website.BoxNovelScrapper.GetBoxNovelChapterList($"{_link}"))
            //    Console.WriteLine($"{item.Item1} {item.Item2}");
        }

        private async Task TaskAsync(string chaptername, string daterelease, string link)
        {
            await Task.Run(() =>
            {
                if (this.chapterdatagridview.InvokeRequired)
                {
                    this.chapterdatagridview.Invoke(new Action(delegate ()
                    {
                        chapterdatagridview.Rows.Add(new object[]
                        {
                            false,
                            chaptername,
                            daterelease,
                            link,
                            "Read"
                        });
                    }
                    ));
                }
            });
        }
    }
}
