using NovelReaderWebScrapper.Model;
using System;
using System.Collections.Generic;

namespace NovelReader.Classes
{
    public class SourcePickerMethod
    {
        public static string GetSourceUrl(Source sitesource)
        {
            switch (sitesource)
            {
                case Source.Boxnovel:
                    return "https://boxnovel.com/";
                case Source.WuxiaworldSite:
                    return "https://wuxiaworld.site/";
                case Source.RoyalRoad:
                    return "https://www.royalroad.com/fictions/latest-updates";
                //case Source.NovelCrush:
                //    return "https://novelcrush.com/";
                //case Source.NovelFool:
                //    return "https://novelfull.com/latest-release-novel";
                //case Source.WebNovelOnline:
                //    return "https://webnovelonline.com/novel-list/recently";
                //case Source.Novelplanet:
                //    return "https://novelplanet.com/";
                //case Source.Novelspread:
                //    return "https://www.novelspread.com/";
                //case Source.Readlightnovel:
                //    return "https://www.readlightnovel.org/";
                //case Source.Wuxiaworld:
                //    return "https://www.wuxiaworld.com/";
                default:
                    return "https://boxnovel.com/";
            }
        }
        public static string GetSourceUrl(Source sitesource, string search)
        {
            switch (sitesource)
            {
                case Source.Boxnovel:
                    return $"https://boxnovel.com/?s={search}&post_type=wp-manga";
                case Source.WuxiaworldSite:
                    return $"https://wuxiaworld.site/?s={search}&post_type=wp-manga";
                case Source.RoyalRoad:
                    return $"https://www.royalroad.com/fictions/search?title={search}";
                //case Source.NovelCrush:
                //    return "https://novelcrush.com/";
                //case Source.NovelFool:
                //    return "https://novelfull.com/latest-release-novel";
                //case Source.WebNovelOnline:
                //    return "https://webnovelonline.com/novel-list/recently";
                //case Source.Novelplanet:
                //    return "https://novelplanet.com/";
                //case Source.Novelspread:
                //    return "https://www.novelspread.com/";
                //case Source.Readlightnovel:
                //    return "https://www.readlightnovel.org/";
                //case Source.Wuxiaworld:
                //    return "https://www.wuxiaworld.com/";
                default:
                    return "https://boxnovel.com/";
            }
        }
        public static SiteLinkModel GetSiteLinkModel(string URL, Scrapper scrapper)
        {
            switch (scrapper)
            {
                case Scrapper.BoxNovelScrapper:
                    return NovelReaderWebScrapper.Website.BoxNovelScrapper.GetPreviosAndNextLink($"{URL}");
                case Scrapper.WuxiaWorldSiteScrapper:
                    return NovelReaderWebScrapper.Website.WuxiaWorldSiteScrapper.GetPreviosAndNextLink($"{URL}");
                case Scrapper.RoyalRoadScrapper:
                    return NovelReaderWebScrapper.Website.RoyalRoadScrapper.GetPreviosAndNextLink($"{URL}");
                default:
                    return NovelReaderWebScrapper.Website.BoxNovelScrapper.GetPreviosAndNextLink($"{URL}");
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
                case Scrapper.RoyalRoadScrapper:
                    return NovelReaderWebScrapper.Website.RoyalRoadScrapper.GetRoyalRoadData($"{URL}", isSearch);
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
                case Scrapper.RoyalRoadScrapper:
                    return NovelReaderWebScrapper.Website.RoyalRoadScrapper.GetRoyalRoadChapterList($"{URL}");
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
                case Scrapper.RoyalRoadScrapper:
                    return NovelReaderWebScrapper.Website.RoyalRoadScrapper.GetRoyalRoadSummary($"{URL}");
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
                    return NovelReaderWebScrapper.Website.WuxiaWorldSiteScrapper.GetWuxiaWorldSiteSypnosis($"{URL}");
                case Scrapper.RoyalRoadScrapper:
                    return NovelReaderWebScrapper.Website.RoyalRoadScrapper.GetRoyalRoadSypnosis($"{URL}");
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
                case Scrapper.RoyalRoadScrapper:
                    return NovelReaderWebScrapper.Website.RoyalRoadScrapper.GetChapterText($"{URL}");
                default:
                    return NovelReaderWebScrapper.Website.BoxNovelScrapper.GetChapterText($"{URL}");
            }
        }
        public enum Source
        {
            Boxnovel,
            WuxiaworldSite,
            RoyalRoad
            //NovelFool
            //NovelCrush
            //WebNovelOnline
            //Novelplanet,
            //Novelspread,
            //Readlightnovel,
            //Wuxiaworld,

        }

        public enum Scrapper
        {
            BoxNovelScrapper,
            WuxiaWorldSiteScrapper,
            RoyalRoadScrapper
            //NovelFoolScrapper
            //WebNovelOnlineScrapper
            //NovelCrushScrapper
            //NovelPlanetScrapper,
            //NovelSpreadScrapper,
            //ReadLightNovelScrapper,
            //WuxiaWorldScrapper,

        }

        ~SourcePickerMethod()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
