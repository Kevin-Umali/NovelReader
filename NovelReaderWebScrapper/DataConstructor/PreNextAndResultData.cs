using System;

namespace NovelReaderWebScrapper.DataConstructor
{
    public class PreNextAndResultData
    {
        public string PreviousLink { get; set; }
        public string NextLink { get; set; }
        public string Result { get; set; }
        public PreNextAndResultData(string _PreviousLink, string _NextLink, string _Result)
        {
            PreviousLink = _PreviousLink;
            NextLink = _NextLink;
            Result = _Result;
        }
        ~PreNextAndResultData()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
