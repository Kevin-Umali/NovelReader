using System;

namespace NovelReaderWebScrapper.Model
{
    public class NovelDataModel
    {
        public string Title { get; set; }
        public string LatestChapter { get; set; }
        public string Link { get; set; }
        public string ImgLink { get; set; }
        public string Rating { get; set; }

        // Construct data
        public NovelDataModel(string _Title, string _LatestChapter, string _Link, string _ImgLink, string _Rating)
        {
            Title = _Title;
            LatestChapter = _LatestChapter;
            Link = _Link;
            ImgLink = _ImgLink;
            Rating = _Rating;
        }

        ~NovelDataModel()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
