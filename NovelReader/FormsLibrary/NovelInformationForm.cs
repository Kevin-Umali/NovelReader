using NovelReader.Classes;
using NovelReader.UserControlLibrary.Cards;
using NovelReaderWebScrapper.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NovelReader.FormsLibrary
{
    public partial class NovelInformationForm : Form
    {
        string _title = string.Empty, _link = string.Empty, _rating = string.Empty, _imglink = string.Empty;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm();
        int _sourcesite;
        public NovelInformationForm(string title, string link, string rating, int sourcesite)
        {
            InitializeComponent();
            _title = title;
            _link = link;
            _rating = rating;
            _sourcesite = sourcesite;
            shadowForm.SetShadowForm(this);
        }

        private void NovelInformationForm_Load(object sender, EventArgs e)
        {
            label1.Text = (_sourcesite == 0) ? "Novel Reader >> Novel Information >> BoxNovel"
                : (_sourcesite == 1) ? "Novel Reader >> Novel Information >> WuxiaWorld.Site"
                : (_sourcesite == 2) ? "Novel Reader >> Novel Information >> RoyalRoad"
                : (_sourcesite == 3) ? "Novel Reader >> Novel Information >> NovelCrush"
                : (_sourcesite == 4) ? "Novel Reader >> Novel Information >> NovelFull"
                : "Novel Reader >> Novel Information >> BoxNovel";

            guna2Button1.Checked = DatabaseAccess.CheckNovelFavorites(_title, _sourcesite) ? true : false;

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
            _imglink = NovelDataSummary.ImgLink;
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
            NovelSypnosisModel novelSypnosis = SourcePickerMethod.GetNovelSypnosisModel(url, (SourcePickerMethod.Scrapper)_sourcesite);
            return novelSypnosis;
        }
        private NovelSummaryModel PrepareNovelSummaryData(string url)
        {
            NovelSummaryModel novelSummary = SourcePickerMethod.GetNovelSummaryModel(url, (SourcePickerMethod.Scrapper)_sourcesite);
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
            return SourcePickerMethod.GetNovelChapterModels(url, (SourcePickerMethod.Scrapper)_sourcesite);
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

                if (e.ColumnIndex == 3)
                {
                    this.Hide();
                    NovelChapterReaderForm f1 = new NovelChapterReaderForm(_title, chapterdatagridview.CurrentRow.Cells["Link"].Value.ToString(), _sourcesite);
                    f1.Closed += (s, args) => this.Close();
                    f1.ShowDialog();
                }
            }
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
            this.Dispose();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (DatabaseAccess.SaveAndUnsaveNovelFavorites(_title, _link, _imglink, _sourcesite))
            {
                guna2Button1.Checked = DatabaseAccess.CheckNovelFavorites(_title, _sourcesite) ? true : false;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var data = DatabaseAccess.ContinueReading(_title, _sourcesite);
            if (!string.IsNullOrEmpty(data.chapterlink))
            {
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.Dispose();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                }
                this.Hide();
                NovelChapterReaderForm f1 = new NovelChapterReaderForm(_title, data.chapterlink, data.sourcesite);
                f1.Closed += (s, args) => this.Dispose();
                f1.ShowDialog();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MainForm f2 = (MainForm)Application.OpenForms["MainForm"];

            if (f2.CheckDownload())
                f2.LoadDownload(new DownloadCard(_sourcesite, PrepareNovelChapterData(_link), _title));
            else
                MessageBox.Show("Wait until the recent download is finished");
            
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        ~NovelInformationForm()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
