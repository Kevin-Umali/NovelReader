using System;

namespace NovelReaderWebScrapper.Model
{
    public class NovelChapterModel
    {
        public string ChapterName { get; set; }
        public string ChapterLink { get; set; }
        public string DateRelease { get; set; }

        // Construct data
        public NovelChapterModel(string _ChapterName, string _ChapterLink, string _DateRelease)
        {
            ChapterName = _ChapterName;
            ChapterLink = _ChapterLink;
            DateRelease = _DateRelease;
        }

        ~NovelChapterModel()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
