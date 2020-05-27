using System;

namespace NovelReaderWebScrapper.Model
{
    public class SiteLinkModel
    {
        public string PreviousLink { get; set; }
        public string NextLink { get; set; }
        public SiteLinkModel(string _PreviousLink, string _NextLink)
        {
            PreviousLink = _PreviousLink;
            NextLink = _NextLink;
        }
        ~SiteLinkModel()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
