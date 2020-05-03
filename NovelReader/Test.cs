using System;
using System.Windows.Forms;

namespace NovelReader
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ss = NovelReaderWebScrapper.Website
                .WuxiaWorldSiteScrapper.GetChapterText
                ("https://wuxiaworld.site/novel/the-strongest-cultivation-system/chapter-2/");
            Console.WriteLine($"{ss.ChapterText.Trim()}  {ss.NextChapterLink}  {ss.PreviousChapterLink}");
            //foreach(var asd in ss)
            //Console.WriteLine($"{ss.Artist}  {ss.Author}  {ss.Genre}  {Environment.NewLine + Environment.NewLine}" +
            //    $"{ss.ImgLink}  {ss.Release}  {ss.Status}");
        }
    }
}
