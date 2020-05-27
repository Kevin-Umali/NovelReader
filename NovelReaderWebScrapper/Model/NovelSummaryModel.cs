using System;

namespace NovelReaderWebScrapper.Model
{
    public class NovelSummaryModel
    {
        public string Author { get; set; } = "Unknown";
        public string Artist { get; set; } = "Unknown";
        public string Genre { get; set; } = "Unknown";
        public string Release { get; set; } = "Unknown";
        public string ImgLink { get; set; }
        public string Status { get; set; } = "Unknown";

        public NovelSummaryModel(string _Author, string _Artist,
            string _Genre, string _Release, string _ImgLink, string _Status)
        {
            Author = _Author;
            Artist = _Artist;
            Genre = _Genre;
            Release = _Release;
            ImgLink = _ImgLink;
            Status = _Status;
        }

        ~NovelSummaryModel()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
