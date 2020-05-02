using HtmlAgilityPack;
using NovelReaderWebScrapper.DataConstructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovelReaderWebScrapper.Website
{
    public class BoxNovelScrapper
    {
        // Changing List<Tuple<...,...>> to List<DataConstructor> better structure with element naming convention.
        public static PreNextAndResultData GetPreviosNextLinkAndResult(string url)
        {
            string previous = string.Empty, next = string.Empty, result = string.Empty;
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = htmlWeb.Load($"{url}");

                doc.OptionEmptyCollection = true;

                result = doc.DocumentNode.SelectSingleNode("//div[@class='c-blog__heading style-2 font-heading']/h4")?.InnerText?.Trim()?.ToUpper();
                Console.WriteLine(result);
                HtmlNode[] node = doc.DocumentNode.SelectNodes("//div[@class='nav-links']").ToArray();
                foreach (HtmlNode item in node)
                {
                    next = item?.SelectSingleNode(".//div[@class='nav-previous pull-left']/a[@href]")?.GetAttributeValue("href", string.Empty);
                    previous = item?.SelectSingleNode(".//div[@class='nav-next pull-right']/a[@href]")?.GetAttributeValue("href", string.Empty);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return new PreNextAndResultData(previous, next, result);
        }
        public static List<NovelData> GetBoxNovelData(string url, bool isSearch)
        {
            var boxNovelData = new List<NovelData>();
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = htmlWeb.Load($"{url}");

                if (isSearch)
                {
                    HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div[@class='c-tabs-item__content']").ToArray();
                    foreach (HtmlNode item in nodes)
                    {
                        var title = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//h4/a")
                            ?.InnerText
                            );

                        var latestchapter = /*StringFormat.TrimAllWithInplaceCharArray(*/
                            HttpUtility.HtmlDecode(
                                item?.SelectSingleNode(".//div[@class='meta-item latest-chap']/span/a")
                                ?.InnerText
                                )?.Trim()/*)*/;

                        var link = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//h4/a[@href]")
                            ?.GetAttributeValue("href", string.Empty)
                            );

                        var imagelink = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//img")
                            ?.Attributes["src"]
                            ?.Value
                            );

                        var rating = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//span[@class='score font-meta total_votes']")
                            ?.InnerText
                            );

                        boxNovelData.Add(new NovelData(title, latestchapter, link, imagelink, rating));
                    }
                }
                else
                {
                    HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div[@class='page-item-detail']").ToArray();
                    foreach (HtmlNode item in nodes)
                    {
                        var title = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//h5/a")
                            ?.InnerText
                            );

                        var latestchapter = /*StringFormat.TrimAllWithInplaceCharArray(*/
                            HttpUtility.HtmlDecode(
                                item?.SelectSingleNode(".//div[@class='chapter-item']/span")
                                ?.InnerText
                                )?.Trim()/*)*/;

                        var link = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//h5/a[@href]")
                            ?.GetAttributeValue("href", string.Empty)
                            );

                        var imagelink = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//img")
                            ?.Attributes["src"]
                            ?.Value
                            );

                        var rating = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//span[@class='score font-meta total_votes']")
                            ?.InnerText
                            );

                        boxNovelData.Add(new NovelData(title, latestchapter, link, imagelink, rating));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return boxNovelData;
        }


        public static NovelSummaryData GetBoxNovelSummary(string url)
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

                HtmlNode imgnode = doc.DocumentNode.SelectNodes("//div[@class='summary_image']//a").First();
                imglink = imgnode.SelectSingleNode("img").Attributes["src"].Value;

                HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div[@class='summary_content']").ToArray();

                foreach (HtmlNode item in nodes)
                {
                    author = HttpUtility.HtmlDecode(
                               item?.SelectSingleNode(".//div/div[@class='author-content']")
                               ?.InnerText)
                           ?.Trim();

                    artist = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//div/div[@class='artist-content']")
                            ?.InnerText)
                        ?.Trim();

                    genre = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//div/div[@class='genres-content']")
                            ?.InnerText)
                        ?.Trim();

                    release = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//div[@class='post-status']/div/div/a")
                            ?.InnerText)
                        ?.Trim();

                    status = HttpUtility.HtmlDecode(item?.SelectSingleNode("//div[@class='post-status']")
                            ?.InnerText?.Trim());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return new NovelSummaryData(author, artist, genre, release, imglink,
                status.Contains("OnGoing") ? "OnGoing" : "Completed");
        }

        public static NovelSypnosisData GetBoxNovelSypnosis(string url)
        {
            string sypnosis = string.Empty;
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = htmlWeb.Load($"{url}");

                doc.OptionEmptyCollection = true;

                HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div[@class='description-summary']").ToArray();
                foreach (HtmlNode item in nodes)
                {
                    sypnosis += HttpUtility.HtmlDecode(item.InnerText)?.Trim()
                        ?.Replace("Show more", "")
                        ?.Replace("Description", "");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new NovelSypnosisData(sypnosis);
        }

        public static List<NovelChapterData> GetBoxNovelChapterList(string url)
        {
            var ChapterListData = new List<NovelChapterData>();
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = htmlWeb.Load($"{url}");

                doc.OptionEmptyCollection = true;

                HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div[@class='page-content-listing single-page']/div/ul/li").ToArray();
                foreach (HtmlNode item in nodes)
                {
                    var chapter = HttpUtility.HtmlDecode(
                        item?.SelectSingleNode(".//a")
                        ?.InnerText
                        )?.Trim();

                    var chapterlink = HttpUtility.HtmlDecode(
                        item?.SelectSingleNode(".//a[@href]")
                        ?.GetAttributeValue("href", string.Empty)
                        )?.Trim();

                    var daterelease = HttpUtility.HtmlDecode(item?.SelectSingleNode(".//span")
                        ?.InnerText
                        ?.Trim());

                    ChapterListData.Add(new NovelChapterData(chapter, chapterlink, daterelease));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ChapterListData;
        }

        public static ChapterTextData GetChapterText(string url)
        {
            string text = string.Empty, previouschapter = string.Empty, nextchapter = string.Empty;

            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = htmlWeb.Load($"{url}");

                doc.OptionEmptyCollection = true;

                HtmlNode linknode = doc.DocumentNode.SelectNodes("//div[@class='nav-links']").First();
                previouschapter = linknode?.SelectSingleNode("//div[@class='nav-previous']/a[@href]")?.GetAttributeValue("href", string.Empty);
                nextchapter = linknode?.SelectSingleNode("//div[@class='nav-next']/a[@href]")?.GetAttributeValue("href", string.Empty);

                HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div[@class='entry-content']/div/div/div/div/p").ToArray();
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

            return new ChapterTextData(previouschapter, nextchapter, text);
        }

        ~BoxNovelScrapper()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
