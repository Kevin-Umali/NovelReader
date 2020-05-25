using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelReaderWebScrapper.Model
{
    public class HistoryModel
    {
        public string NovelName { get; set; }
        public string PreviousChapterLink { get; set; }
        public int Source { get; set; }

        ~HistoryModel()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
