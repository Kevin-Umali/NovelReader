using HtmlAgilityPack;
using NovelReaderWebScrapper.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace NovelReaderWebScrapper.Website
{
    public class RoyalRoadScrapper
    {
        public static SiteLinkModel GetPreviosAndNextLink(string url)
        {
            string previous = string.Empty, next = string.Empty;
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = htmlWeb.Load($"{url}");

                doc.OptionEmptyCollection = true;

                HtmlNode[] node = doc.DocumentNode.SelectNodes("//div/ul[@class='pagination justify-content-center']/li").ToArray();
                foreach (HtmlNode item in node)
                {
                    if (url.Equals("https://www.royalroad.com/fictions/latest-updates?page=2"))
                    {
                        if (item.InnerText.Contains("Next"))
                        {
                            next = "https://www.royalroad.com" + item?.SelectSingleNode(".//a[@href]")?.GetAttributeValue("href", string.Empty);
                        }
                        previous = "https://www.royalroad.com/fictions/latest-updates?page=1";
                    }
                    else
                    {
                        if (item.InnerText.Contains("Next"))
                            next = "https://www.royalroad.com" + item?.SelectSingleNode(".//a[@href]")?.GetAttributeValue("href", string.Empty);

                        if (item.InnerText.Contains("Previous"))
                            previous = "https://www.royalroad.com" + item?.SelectSingleNode(".//a[@href]")?.GetAttributeValue("href", string.Empty);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return new SiteLinkModel(previous, next);
        }
        public static List<NovelDataModel> GetRoyalRoadData(string url, bool isSearch)
        {
            var boxNovelData = new List<NovelDataModel>();
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = htmlWeb.Load($"{url}");

                if (isSearch)
                {
                    HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div[@class='fiction-list']/div").ToArray();
                    foreach (HtmlNode item in nodes)
                    {
                        var title = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//h2[@class='fiction-title']/a")
                            ?.InnerText
                            );

                        var latestchapter = "Unknown";

                        var link = "https://www.royalroad.com" + HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//h2[@class='fiction-title']/a[@href]")
                            ?.GetAttributeValue("href", string.Empty)
                            );

                        var imagelink = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//figure[@class='col-sm-2 col-md-3 col-lg-2 text-center']/img")
                            ?.Attributes["src"]
                            ?.Value
                            );

                        if (!string.IsNullOrEmpty(imagelink))
                            if (imagelink.Equals("/Content/Images/nocover-new-min.png"))
                                imagelink = "https://www.royalroad.com/Content/Images/nocover-new-min.png";

                        var rating = Math.Round(Convert.ToDouble(HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//div/div/span[@title]")
                            ?.GetAttributeValue("title", string.Empty)
                            )), 1);

                        boxNovelData.Add(new NovelDataModel(title, latestchapter, link, imagelink, rating.ToString()));
                    }
                }
                else
                {
                    HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div[@class='fiction-list']/div").ToArray();
                    foreach (HtmlNode item in nodes)
                    {
                        var title = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//h2[@class='fiction-title']/a")
                            ?.InnerText
                            );

                        var latestchapter = /*StringFormat.TrimAllWithInplaceCharArray(*/
                            HttpUtility.HtmlDecode(
                                item?.SelectSingleNode(".//ul/li/a/span[@class='col-xs-8']")
                                ?.InnerText
                                )?.Trim()/*)*/;

                        var link = "https://www.royalroad.com" + HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//h2[@class='fiction-title']/a[@href]")
                            ?.GetAttributeValue("href", string.Empty)
                            );

                        var imagelink = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//figure[@class='col-sm-2']/img")
                            ?.Attributes["src"]
                            ?.Value
                            );

                        if (!string.IsNullOrEmpty(imagelink))
                            if (imagelink.Equals("/Content/Images/nocover-new-min.png"))
                                imagelink = "https://www.royalroad.com/Content/Images/nocover-new-min.png";

                        var rating = "0";

                        boxNovelData.Add(new NovelDataModel(title, latestchapter, link, imagelink, rating));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return boxNovelData;
        }


        public static NovelSummaryModel GetRoyalRoadSummary(string url)
        {
            string author = string.Empty, artist = string.Empty,
                genre = string.Empty, release = string.Empty,
                imglink = string.Empty, status = string.Empty;
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = htmlWeb.Load($"{url}");

                doc.OptionEmptyCollection = true;

                HtmlNode imgnode = doc.DocumentNode.SelectNodes("//div[@class='col-md-3 hidden-sm hidden-xs text-center']").First();
                imglink = imgnode.SelectSingleNode("img").Attributes["src"].Value;

                if (imglink.Equals("/Content/Images/nocover-new-min.png"))
                    imglink = "https://www.royalroad.com/Content/Images/nocover-new-min.png";

                HtmlNode _author = doc.DocumentNode.SelectNodes("//div[@class='col-md-5 col-lg-6 text-center md-text-left fic-title']").First();
                author = HttpUtility.HtmlDecode(
                                _author?.SelectSingleNode(".//h4/span[@property='name']")
                                ?.InnerText)
                            ?.Trim();

                artist = "Unknown";

                release = "Unknown";

                status = "Unknown";

                HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div[@class='margin-bottom-10']//span[@class='tags']").ToArray();

                foreach (HtmlNode item in nodes)
                {
                    genre = HttpUtility.HtmlDecode(item?.InnerText?.Trim());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return new NovelSummaryModel(author, artist, genre, release, imglink,
                status);
        }

        public static NovelSypnosisModel GetRoyalRoadSypnosis(string url)
        {
            string sypnosis = string.Empty;
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = htmlWeb.Load($"{url}");

                doc.OptionEmptyCollection = true;

                HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div[@class='description']").ToArray();
                foreach (HtmlNode item in nodes)
                {
                    sypnosis += HttpUtility.HtmlDecode(item.InnerText)?.Trim();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new NovelSypnosisModel(sypnosis);
        }

        public static List<NovelChapterModel> GetRoyalRoadChapterList(string url)
        {
            var ChapterListData = new List<NovelChapterModel>();
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("User-Agent: Other");
                    using (Stream data = client.OpenRead(url))
                    {
                        using (StreamReader reader = new StreamReader(data))
                        {
                            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                            doc.LoadHtml(reader.ReadToEnd());

                            doc.OptionEmptyCollection = true;

                            HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//table[@id='chapters']/tbody/tr").ToArray();
                            foreach (HtmlNode item in nodes)
                            {
                                var chapter = HttpUtility.HtmlDecode(
                                    item?.SelectSingleNode(".//td/a")?.FirstChild
                                    ?.InnerText
                                    )?.Trim();

                                var chapterlink = "https://www.royalroad.com" + HttpUtility.HtmlDecode(
                                    item?.SelectSingleNode(".//a[@href]")
                                    ?.GetAttributeValue("href", string.Empty)
                                    )?.Trim();

                                var daterelease = HttpUtility.HtmlDecode(item?.SelectSingleNode(".//td/a/time")
                                    ?.InnerHtml
                                    ?.Trim());

                                ChapterListData.Add(new NovelChapterModel(chapter, chapterlink, daterelease));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ChapterListData;
        }

        public static ChapterTextModel GetChapterText(string url)
        {
            string text = string.Empty, previouschapter = string.Empty, nextchapter = string.Empty;

            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = htmlWeb.Load($"{url}");

                doc.OptionEmptyCollection = true;

                HtmlNode linknode = doc.DocumentNode.SelectNodes("//div[@class='row nav-buttons']").First();

                previouschapter = linknode?.SelectSingleNode("//div[@class='col-xs-6 col-md-4 col-lg-3 col-xl-2']/a[@href]")
                    ?.GetAttributeValue("href", string.Empty);

                if (!string.IsNullOrEmpty(previouschapter))
                    previouschapter = "https://www.royalroad.com" + previouschapter;

                nextchapter = linknode?.SelectSingleNode("//div[@class='col-xs-6 col-md-4 col-md-offset-4 col-lg-3 col-lg-offset-6']/a[@href]")
                    ?.GetAttributeValue("href", string.Empty);

                if (!string.IsNullOrEmpty(nextchapter))
                    nextchapter = "https://www.royalroad.com" + nextchapter;

                HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div[@class='chapter-inner chapter-content']/p").ToArray();
                foreach (HtmlNode item in nodes)
                {
                    text += HttpUtility.HtmlDecode(
                        item?.InnerText
                        ) + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new ChapterTextModel(previouschapter, nextchapter, text);
        }

        ~RoyalRoadScrapper()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
