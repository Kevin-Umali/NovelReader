using NovelReaderWebScrapper.Model;
using System;
using System.Collections.Generic;

namespace NovelReader
{
    public class SourcePickerMethod
    {
        public static string GetSourceUrl(Source sitesource)
        {
            switch (sitesource)
            {
                case Source.Boxnovel:
                    return "https://boxnovel.com/";
                //case Source.Novelplanet:
                //    return "https://novelplanet.com/";
                //case Source.Novelspread:
                //    return "https://www.novelspread.com/";
                //case Source.Readlightnovel:
                //    return "https://www.readlightnovel.org/";
                //case Source.Wuxiaworld:
                //    return "https://www.wuxiaworld.com/";
                case Source.WuxiaworldSite:
                    return "https://wuxiaworld.site/";
                //case Source.WuxiaworldOnline:
                //    return "https://wuxiaworld.online/wuxiaworld";
                default:
                    return "https://boxnovel.com/";
            }
        }

        public static SiteLinkModel GetSiteLinkModel(string URL, Scrapper scrapper)
        {
            switch (scrapper)
            {
                case Scrapper.BoxNovelScrapper:
                    return NovelReaderWebScrapper.Website.BoxNovelScrapper.GetPreviosNextLinkAndResult($"{URL}");
                case Scrapper.WuxiaWorldSiteScrapper:
                    return NovelReaderWebScrapper.Website.WuxiaWorldSiteScrapper.GetPreviosNextLinkAndResult($"{URL}");
                default:
                    return NovelReaderWebScrapper.Website.BoxNovelScrapper.GetPreviosNextLinkAndResult($"{URL}");
            }
        }

        public static List<NovelDataModel> GetNovelDataModels(string URL, bool isSearch, Scrapper scrapper)
        {
            switch (scrapper)
            {
                case Scrapper.BoxNovelScrapper:
                    return NovelReaderWebScrapper.Website.BoxNovelScrapper.GetBoxNovelData($"{URL}", isSearch);
                case Scrapper.WuxiaWorldSiteScrapper:
                    return NovelReaderWebScrapper.Website.WuxiaWorldSiteScrapper.GetWuxiaWorldSiteData($"{URL}", isSearch);
                default:
                    return NovelReaderWebScrapper.Website.BoxNovelScrapper.GetBoxNovelData($"{URL}", isSearch);
            }
        }

        public static List<NovelChapterModel> GetNovelChapterModels(string URL, Scrapper scrapper)
        {
            switch (scrapper)
            {
                case Scrapper.BoxNovelScrapper:
                    return NovelReaderWebScrapper.Website.BoxNovelScrapper.GetBoxNovelChapterList($"{URL}");
                case Scrapper.WuxiaWorldSiteScrapper:
                    return NovelReaderWebScrapper.Website.WuxiaWorldSiteScrapper.GetWuxiaWorldSiteChapterList($"{URL}");
                default:
                    return NovelReaderWebScrapper.Website.BoxNovelScrapper.GetBoxNovelChapterList($"{URL}");
            }
        }
        public static NovelSummaryModel GetNovelSummaryModel(string URL, Scrapper scrapper)
        {
            switch (scrapper)
            {
                case Scrapper.BoxNovelScrapper:
                    return NovelReaderWebScrapper.Website.BoxNovelScrapper.GetBoxNovelSummary($"{URL}");
                case Scrapper.WuxiaWorldSiteScrapper:
                    return NovelReaderWebScrapper.Website.WuxiaWorldSiteScrapper.GetWuxiaWorldSiteSummary($"{URL}");
                default:
                    return NovelReaderWebScrapper.Website.BoxNovelScrapper.GetBoxNovelSummary($"{URL}");
            }
        }

        public static NovelSypnosisModel GetNovelSypnosisModel(string URL, Scrapper scrapper)
        {
            switch (scrapper)
            {
                case Scrapper.BoxNovelScrapper:
                    return NovelReaderWebScrapper.Website.BoxNovelScrapper.GetBoxNovelSypnosis($"{URL}");
                case Scrapper.WuxiaWorldSiteScrapper:
                    return NovelReaderWebScrapper.Website.WuxiaWorldSiteScrapper.GetWuxiaWorldSypnosis($"{URL}");
                default:
                    return NovelReaderWebScrapper.Website.BoxNovelScrapper.GetBoxNovelSypnosis($"{URL}");
            }
        }
        public static ChapterTextModel GetChapterTextModel(string URL, Scrapper scrapper)
        {
            switch (scrapper)
            {
                case Scrapper.BoxNovelScrapper:
                    return NovelReaderWebScrapper.Website.BoxNovelScrapper.GetChapterText($"{URL}");
                case Scrapper.WuxiaWorldSiteScrapper:
                    return NovelReaderWebScrapper.Website.WuxiaWorldSiteScrapper.GetChapterText($"{URL}");
                default:
                    return NovelReaderWebScrapper.Website.BoxNovelScrapper.GetChapterText($"{URL}");
            }
        }
        public enum Source
        {
            Boxnovel,
            //Novelplanet,
            //Novelspread,
            //Readlightnovel,
            //Wuxiaworld,
            WuxiaworldSite
            //WuxiaworldOnline
        }

        public enum Scrapper
        {
            BoxNovelScrapper,
            //NovelPlanetScrapper,
            //NovelSpreadScrapper,
            //ReadLightNovelScrapper,
            //WuxiaWorldScrapper,
            WuxiaWorldSiteScrapper
            //WuxiaWorldOnlineScrapper
        }

        ~SourcePickerMethod()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
