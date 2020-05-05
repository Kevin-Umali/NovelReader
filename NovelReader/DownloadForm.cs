using iTextSharp.text;
using iTextSharp.text.pdf;
using NovelReaderWebScrapper.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelReader
{
    public partial class DownloadForm : Form
    {
        private List<NovelReaderWebScrapper.Model.NovelChapterModel> novelChapters = new List<NovelReaderWebScrapper.Model.NovelChapterModel>();
        private string _title = string.Empty;
        int PercentageComplete = 0;
        int sourcesite = Properties.Settings.Default.SourceSite;
        public DownloadForm()
        {
            InitializeComponent();
        }
        public void SendDownloadData(List<NovelReaderWebScrapper.Model.NovelChapterModel> novelChapterModels, string title)
        {
            _title = title;
            novelChapters = novelChapterModels;
        }
        private void DownloadForm_Load(object sender, EventArgs e)
        {
            guna2CircleProgressBar1.Maximum = novelChapters.Count;
            timer1.Start();
            var documentpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) 
                + $@"\{string.Join("", _title.Split('\\', '/', ':', '*', '?', '"', '<', '>', '|'))}";

            if (!Directory.Exists(documentpath))
            {
                Directory.CreateDirectory(documentpath);
            }
        }
        public async Task DownloadChapterAsync()
        {
            //List<Task<(ChapterTextModel Text, string ItemName)>> chapterTexts = new List<Task<(ChapterTextModel, string)>>();

            foreach (var item in novelChapters)
            {
                await Task.Run(() => SaveToPdf(item.ChapterName, GetChapterTextData(item.ChapterLink)));
            }

            //var result = await Task.WhenAll(chapterTexts);

            //foreach(var item in result)
            //{
            //    await Task.Run(() => SaveToPdf(item.ItemName, item.Text.ChapterText));
            //}
        }

        private string GetChapterTextData(string url)
        {
            string chapterText = SourcePickerMethod.GetChapterTextModel($"{url}", (SourcePickerMethod.Scrapper)sourcesite).ChapterText;
            return chapterText;
        }

        private void SaveToPdf(string name, string chaptertext)
        {
            Document myDocument = new Document(PageSize.A4);
            var documentpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                + $@"\{string.Join("", _title.Split('\\', '/', ':', '*', '?', '"', '<', '>', '|'))}";
            string pdf = Path.Combine(documentpath, $"{string.Join("", name.Split('\\','/',':','*','?','"','<','>','|'))}.pdf");
            try
            {
                if (!File.Exists(pdf))
                {
                    PdfWriter.GetInstance(myDocument, new FileStream(pdf, FileMode.Create));
                    myDocument.Open();
                    myDocument.Add(new Paragraph(chaptertext.Trim()));
                }
                else
                {
                    myDocument.Close();
                    Update();
                    return;
                }
            }
            catch (DocumentException de)
            {
                Console.Error.WriteLine(de.Message);
            }
            catch (IOException ioe)
            {
                Console.Error.WriteLine(ioe.Message);
            }
            myDocument.Close();
            GC.Collect();
            Update();
        }

        void Update()
        {
            if (this.guna2CircleProgressBar1.InvokeRequired || this.label1.InvokeRequired)
            {
                this.guna2CircleProgressBar1.Invoke(new MethodInvoker(delegate ()
                {
                    guna2CircleProgressBar1.Value = PercentageComplete++;
                }));

                this.label1.Invoke(new MethodInvoker(delegate ()
                {
                    label1.Text = $"{PercentageComplete.ToString()}/{guna2CircleProgressBar1.Maximum.ToString()}";
                }));
            }
        }
        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            var documentpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                + $@"\{string.Join("", _title.Split('\\', '/', ':', '*', '?', '"', '<', '>', '|'))}";
            await DownloadChapterAsync();
            MessageBox.Show($"Download Complete {Environment.NewLine} File(s) saved to {documentpath}");
            this.Dispose();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            guna2CircleProgressBar1.Dispose();
            GC.Collect();
        }
    }
}
