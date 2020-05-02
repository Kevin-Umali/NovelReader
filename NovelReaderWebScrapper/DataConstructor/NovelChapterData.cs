using System;

namespace NovelReaderWebScrapper.DataConstructor
{
    public class NovelChapterData
    {
        public string ChapterName { get; set; }
        public string ChapterLink { get; set; }
        public string DateRelease { get; set; }

        // Construct data
        public NovelChapterData(string _ChapterName, string _ChapterLink, string _DateRelease)
        {
            ChapterName = _ChapterName;
            ChapterLink = _ChapterLink;
            DateRelease = _DateRelease;
        }

        ~NovelChapterData()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
