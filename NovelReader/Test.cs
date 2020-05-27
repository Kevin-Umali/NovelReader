using NovelReaderWebScrapper.Website;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
            var a = RoyalRoadScrapper.GetRoyalRoadData("https://www.royalroad.com/fictions/latest-updates?page=1", false);
            foreach(var aa in a)
            {
                richTextBox1.Text += $"{aa.Title}{Environment.NewLine}Latest Chapter:{aa.LatestChapter}{Environment.NewLine}{Environment.NewLine}";
            }
            //var a = RoyalRoadScrapper.GetRoyalRoadSummary("https://www.royalroad.com/fiction/32110/bloodsong");

            //richTextBox1.Text += $"Artist: {a.Artist}{Environment.NewLine}Author: {a.Author}" +
            //        $"{Environment.NewLine}Genre: {a.Genre}" +
            //        $"{Environment.NewLine}ImgLink: {a.ImgLink}" +
            //        $"{Environment.NewLine}Release: {a.Release}" +
            //        $"{Environment.NewLine}Status: {a.Status}{Environment.NewLine}{Environment.NewLine}";

            //var a = RoyalRoadScrapper.GetRoyalRoadSypnosis("https://www.royalroad.com/fiction/32110/bloodsong");

            //richTextBox1.Text += $"Sypnosis: {a.Sypnosis}";

            //var aa = RoyalRoadScrapper.GetChapterText("https://www.royalroad.com/fiction/16946/azarinth-healer/chapter/198148/chapter-2-generic-wolves-who-wouldve-guessed");
                
            //richTextBox1.Text = $"PreviousChapterLink: {aa.PreviousChapterLink}{Environment.NewLine}NextChapterLink: {aa.NextChapterLink}" +
            //            $"{Environment.NewLine}ChapterText: {aa.ChapterText} {Environment.NewLine}{Environment.NewLine}";
        }
    }
}
