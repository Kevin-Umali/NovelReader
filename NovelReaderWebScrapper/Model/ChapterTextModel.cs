using System;

namespace NovelReaderWebScrapper.Model
{
    public class ChapterTextModel
    {
        public string PreviousChapterLink { get; set; }
        public string NextChapterLink { get; set; }
        public string ChapterText { get; set; }
        public ChapterTextModel(string _PreviousChapterLink, string _NextChapterLink, string _ChapterText)
        {
            PreviousChapterLink = _PreviousChapterLink;
            NextChapterLink = _NextChapterLink;
            ChapterText = _ChapterText;
        }
        ~ChapterTextModel()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
