using System;

namespace NovelReaderWebScrapper.DataConstructor
{
    public class NovelData
    {
        public string Title { get; set; }
        public string LatestChapter { get; set; }
        public string Link { get; set; }
        public string ImgLink { get; set; }
        public string Rating { get; set; }

        // Construct data
        public NovelData(string _Title, string _LatestChapter, string _Link, string _ImgLink, string _Rating)
        {
            Title = _Title;
            LatestChapter = _LatestChapter;
            Link = _Link;
            ImgLink = _ImgLink;
            Rating = _Rating;
        }

        ~NovelData()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
