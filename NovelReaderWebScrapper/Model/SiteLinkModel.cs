using System;

namespace NovelReaderWebScrapper.Model
{
    public class SiteLinkModel
    {
        public string PreviousLink { get; set; }
        public string NextLink { get; set; }
        public string Result { get; set; }
        public SiteLinkModel(string _PreviousLink, string _NextLink, string _Result)
        {
            PreviousLink = _PreviousLink;
            NextLink = _NextLink;
            Result = _Result;
        }
        ~SiteLinkModel()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
