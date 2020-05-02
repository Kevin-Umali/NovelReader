using System;

namespace NovelReaderWebScrapper.DataConstructor
{
    public class ChapterTextData
    {
        public string PreviousChapterLink { get; set; }
        public string NextChapterLink { get; set; }
        public string ChapterText { get; set; }
        public ChapterTextData(string _PreviousChapterLink, string _NextChapterLink, string _ChapterText)
        {
            PreviousChapterLink = _PreviousChapterLink;
            NextChapterLink = _NextChapterLink;
            ChapterText = _ChapterText;
        }
        ~ChapterTextData()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
