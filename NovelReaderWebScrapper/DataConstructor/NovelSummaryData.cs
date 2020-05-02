using System;

namespace NovelReaderWebScrapper.DataConstructor
{
    public class NovelSummaryData
    {
        public string Author { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string Release { get; set; }
        public string ImgLink { get; set; }
        public string Status { get; set; }

        public NovelSummaryData(string _Author, string _Artist,
            string _Genre, string _Release, string _ImgLink, string _Status)
        {
            Author = _Author;
            Artist = _Artist;
            Genre = _Genre;
            Release = _Release;
            ImgLink = _ImgLink;
            Status = _Status;
        }

        ~NovelSummaryData()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
