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
    public class NovelCrushScrapper
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

                HtmlNode[] node = doc.DocumentNode.SelectNodes("//div[@class='wp-pagenavi']").ToArray();
                foreach (HtmlNode item in node)
                {
                    previous = item?.SelectSingleNode(".//a[@class='previouspostslink'][@href]")?.GetAttributeValue("href", string.Empty);
                    next = item?.SelectSingleNode(".//a[@class='nextpostslink'][@href]")?.GetAttributeValue("href", string.Empty);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return new SiteLinkModel(previous, next);
        }
        public static List<NovelDataModel> GetNovelCrushData(string url, bool isSearch)
        {
            var boxNovelData = new List<NovelDataModel>();
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = htmlWeb.Load($"{url}");

                if (isSearch)
                {
                    HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div[@class='c-tabs-item']/div").ToArray();
                    Console.WriteLine(nodes.Count());
                    foreach (HtmlNode item in nodes)
                    {

                        var title = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//h3/a")
                            ?.InnerText
                            );

                        var latestchapter = /*StringFormat.TrimAllWithInplaceCharArray(*/
                            HttpUtility.HtmlDecode(
                                item?.SelectSingleNode(".//div[@class='meta-item latest-chap']/span/a")
                                ?.InnerText
                                )?.Trim()/*)*/;

                        var link = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//h3/a[@href]")
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

                        boxNovelData.Add(new NovelDataModel(title, latestchapter, link, imagelink, rating));
                    }
                }
                else
                {
                    HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div[@class='page-content-listing item-small_thumbnail']/div/div/div").ToArray();
                    foreach (HtmlNode item in nodes)
                    {
                        var title = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//div/div[@class='post-title font-title']/h3/a")
                            ?.InnerText
                            );

                        var latestchapter = /*StringFormat.TrimAllWithInplaceCharArray(*/
                            HttpUtility.HtmlDecode(
                                item?.SelectSingleNode(".//div[@class='list-chapter']/div/span")
                                ?.InnerText
                                )?.Trim()/*)*/;

                        var link = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//div/div[@class='post-title font-title']/h3/a[@href]")
                            ?.GetAttributeValue("href", string.Empty)
                            );

                        var imagelink = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//div[@class='item-thumb hover-details c-image-hover']/a/img")
                            ?.Attributes["src"]
                            ?.Value
                            );

                        var rating = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//div/div[@class='meta-item rating']/div/span")
                            ?.InnerText
                            );

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


        public static NovelSummaryModel GetNovelCrushSummary(string url)
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


            return new NovelSummaryModel(author, artist, genre, release, imglink,
                status.Contains("OnGoing") ? "OnGoing" : "Completed");
        }

        public static NovelSypnosisModel GetNovelCrushSypnosis(string url)
        {
            string sypnosis = string.Empty;
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = htmlWeb.Load($"{url}");

                doc.OptionEmptyCollection = true;

                HtmlNode nodes = doc.DocumentNode.SelectNodes("//div[@class='description-summary']/div").FirstOrDefault();

                sypnosis = HttpUtility.HtmlDecode(nodes.InnerText)?.Trim()
                        ?.Replace("Show more", "")
                        ?.Replace("Description", "");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new NovelSypnosisModel(sypnosis);
        }

        public static List<NovelChapterModel> GetNovelCrushChapterList(string url)
        {
            var ChapterListData = new List<NovelChapterModel>();
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

                    ChapterListData.Add(new NovelChapterModel(chapter, chapterlink, daterelease));
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

                HtmlNode linknode = doc.DocumentNode.SelectNodes("//div[@class='select-pagination']/div").First();

                previouschapter = linknode?.SelectSingleNode(".//div/a[@class='btn prev_page'][@href]")?.GetAttributeValue("href", string.Empty);
                nextchapter = linknode?.SelectSingleNode(".//div/a[@class='btn next_page'][@href]")?.GetAttributeValue("href", string.Empty);

                HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div[@class='entry-content']").ToArray();
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

            return new ChapterTextModel(previouschapter, nextchapter, text.Trim());
        }

        ~NovelCrushScrapper()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
