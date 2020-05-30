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
                case Source.NovelCrush:
                    return "https://novelcrush.com/";
                case Source.NovelFull:
                    return "https://novelfull.com/latest-release-novel";
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
                case Source.NovelCrush:
                    return $"https://novelcrush.com/?s={search}&post_type=wp-manga";
                case Source.NovelFull:
                    return $"https://novelfull.com/search?keyword={search}";
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
                case Scrapper.NovelCrushScrapper:
                    return NovelReaderWebScrapper.Website.NovelCrushScrapper.GetPreviosAndNextLink($"{URL}");
                case Scrapper.NovelFullScrapper:
                    return NovelReaderWebScrapper.Website.NovelFullScrapper.GetPreviosAndNextLink($"{URL}");
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
                case Scrapper.NovelCrushScrapper:
                    return NovelReaderWebScrapper.Website.NovelCrushScrapper.GetNovelCrushData($"{URL}", isSearch);
                case Scrapper.NovelFullScrapper:
                    return NovelReaderWebScrapper.Website.NovelFullScrapper.GetNovelFullData($"{URL}", isSearch);
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
                case Scrapper.NovelCrushScrapper:
                    return NovelReaderWebScrapper.Website.NovelCrushScrapper.GetNovelCrushChapterList($"{URL}");
                case Scrapper.NovelFullScrapper:
                    return NovelReaderWebScrapper.Website.NovelFullScrapper.GetNovelFullChapterList($"{URL}");
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
                case Scrapper.NovelCrushScrapper:
                    return NovelReaderWebScrapper.Website.NovelCrushScrapper.GetNovelCrushSummary($"{URL}");
                case Scrapper.NovelFullScrapper:
                    return NovelReaderWebScrapper.Website.NovelFullScrapper.GetNovelFullSummary($"{URL}");
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
                case Scrapper.NovelCrushScrapper:
                    return NovelReaderWebScrapper.Website.NovelCrushScrapper.GetNovelCrushSypnosis($"{URL}");
                case Scrapper.NovelFullScrapper:
                    return NovelReaderWebScrapper.Website.NovelFullScrapper.GetNovelFullSypnosis($"{URL}");
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
                case Scrapper.NovelCrushScrapper:
                    return NovelReaderWebScrapper.Website.NovelCrushScrapper.GetChapterText($"{URL}");
                case Scrapper.NovelFullScrapper:
                    return NovelReaderWebScrapper.Website.NovelFullScrapper.GetChapterText($"{URL}");
                default:
                    return NovelReaderWebScrapper.Website.BoxNovelScrapper.GetChapterText($"{URL}");
            }
        }
        public enum Source
        {
            Boxnovel,
            WuxiaworldSite,
            RoyalRoad,
            NovelCrush,
            NovelFull
        }

        public enum Scrapper
        {
            BoxNovelScrapper,
            WuxiaWorldSiteScrapper,
            RoyalRoadScrapper,
            NovelCrushScrapper,
            NovelFullScrapper
        }

        ~SourcePickerMethod()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
