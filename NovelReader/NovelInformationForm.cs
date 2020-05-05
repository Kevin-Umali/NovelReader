using NovelReaderWebScrapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NovelReader
{
    public partial class NovelInformationForm : Form
    {
        string _title, _link, _rating = string.Empty;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm();
        int sourcesite = Properties.Settings.Default.SourceSite;

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
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            NovelReaderWebScrapper.Model.NovelSummaryModel NovelDataSummary
                = PrepareNovelSummaryData($"{_link}");

            lblauthor.Text = $"{NovelDataSummary.Author} - {NovelDataSummary.Artist}";
            lblgenre.Text = NovelDataSummary.Genre;
            lblrelease.Text = $"{NovelDataSummary.Release} - {NovelDataSummary.Status}";
            pictureBox1.LoadAsync(NovelDataSummary.ImgLink);

            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            lblsypnosis.Text = PrepareSypnosisData(_link).Sypnosis.Trim().TrimStart();
        }
        private NovelSypnosisModel PrepareSypnosisData(string url)
        {
            NovelSypnosisModel novelSypnosis = SourcePickerMethod.GetNovelSypnosisModel(url, (SourcePickerMethod.Scrapper)sourcesite);
            return novelSypnosis;
        }
        private NovelSummaryModel PrepareNovelSummaryData(string url)
        {
            NovelSummaryModel novelSummary = SourcePickerMethod.GetNovelSummaryModel(url, (SourcePickerMethod.Scrapper)sourcesite);
            return novelSummary;
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            chapterdatagridview.Rows.Clear();
            chapterdatagridview.Refresh();
            chapterdatagridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            chapterdatagridview.RowHeadersVisible = false;
            await LoadChapterDataAsync();
        }
        private List<NovelChapterModel> PrepareNovelChapterData(string url)
        {
            return SourcePickerMethod.GetNovelChapterModels(url, (SourcePickerMethod.Scrapper)sourcesite);
        }

        private async Task LoadChapterDataAsync()
        {
            List<NovelChapterModel> novelChapterDatas = PrepareNovelChapterData(_link);

            foreach (var chapteritem in novelChapterDatas)
            {
                await Task.Run(() =>
                AddDataGridRows(chapteritem.ChapterName, chapteritem.DateRelease, chapteritem.ChapterLink));
            }
        }

        private void AddDataGridRows(string chaptername, string daterelease, string link)
        {
            if (this.chapterdatagridview.InvokeRequired)
            {
                this.chapterdatagridview.Invoke(new MethodInvoker(delegate ()
                {
                    chapterdatagridview.Rows.Add(
                        false,
                        chaptername,
                        daterelease,
                        link,
                        "Read");
                }
                ));
            }
        }
        private void chapterdatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (chapterdatagridview.Rows.Count >= 1)
            {

                if (e.ColumnIndex == 4)
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DownloadForm f1 = new DownloadForm();
            f1.SendDownloadData(PrepareNovelChapterData(_link), _title);
            f1.ShowDialog();
            f1.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private bool DisposeControl()
        {
            chapterdatagridview.Dispose();
            guna2ShadowPanel1.Dispose();
            foreach (Control controls in this.Controls)
            {
                controls.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
            return true;
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            if (DisposeControl())
            {
                this.Dispose();
            }
        }
    }
}
