using HtmlAgilityPack;
using NovelReaderWebScrapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace NovelReaderWebScrapper.Website
{
    public class NovelFullScrapper
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

                HtmlNode node = doc.DocumentNode.SelectNodes("//div[@class='col-xs-12 col-sm-12 col-md-9 col-truyen-main']").FirstOrDefault();
                Console.WriteLine(node.InnerHtml);

                previous = node?.SelectSingleNode(".//ul/li[@class='prev']/a[@href]")?.GetAttributeValue("href", string.Empty);
                if (!string.IsNullOrEmpty(previous))
                    previous = "https://novelfull.com" + previous;

                next = node?.SelectSingleNode(".//ul/li[@class='next']/a[@href]")?.GetAttributeValue("href", string.Empty);
                if (!string.IsNullOrEmpty(next))
                    next = "https://novelfull.com" + next;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return new SiteLinkModel(previous, next);
        }
        public static List<NovelDataModel> GetNovelFullData(string url, bool isSearch)
        {
            var boxNovelData = new List<NovelDataModel>();
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = htmlWeb.Load($"{url}");

                if (isSearch)
                {
                    HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div/div/div/div[@class='row']").ToArray();
                    foreach (HtmlNode item in nodes)
                    {
                        var title = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//div/h3[@class='truyen-title']/a")
                            ?.InnerText
                            );

                        var latestchapter = /*StringFormat.TrimAllWithInplaceCharArray(*/
                            HttpUtility.HtmlDecode(
                                item?.SelectSingleNode(".//div/div/a/span[@class='chapter-text']")
                                ?.InnerText
                                )?.Trim()/*)*/;


                        var link = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//div/h3[@class='truyen-title']/a[@href]")
                            ?.GetAttributeValue("href", string.Empty)
                            );

                        if (!string.IsNullOrEmpty(link))
                            link = "https://novelfull.com" + link;

                        var imagelink = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//img")
                            ?.Attributes["src"]
                            ?.Value
                            );

                        if (!string.IsNullOrEmpty(imagelink))
                            imagelink = "https://novelfull.com" + imagelink;

                        var rating = "0";

                        boxNovelData.Add(new NovelDataModel(title, latestchapter, link, imagelink, rating));
                    }
                }
                else
                {
                    HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div/div/div/div[@class='row']").ToArray();
                    foreach (HtmlNode item in nodes)
                    {
                        var title = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//div/h3[@class='truyen-title']/a")
                            ?.InnerText
                            );

                        var latestchapter = /*StringFormat.TrimAllWithInplaceCharArray(*/
                            HttpUtility.HtmlDecode(
                                item?.SelectSingleNode(".//div/div/a/span[@class='chapter-text']")
                                ?.InnerText
                                )?.Trim()/*)*/;


                        var link = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//div/h3[@class='truyen-title']/a[@href]")
                            ?.GetAttributeValue("href", string.Empty)
                            );

                        if (!string.IsNullOrEmpty(link))
                            link = "https://novelfull.com" + link;

                        var imagelink = HttpUtility.HtmlDecode(
                            item?.SelectSingleNode(".//img")
                            ?.Attributes["src"]
                            ?.Value
                            );

                        if (!string.IsNullOrEmpty(imagelink))
                            imagelink = "https://novelfull.com" + imagelink;

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


        public static NovelSummaryModel GetNovelFullSummary(string url)
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

                HtmlNode imgnode = doc.DocumentNode.SelectNodes("//div[@class='book']").FirstOrDefault();

                imglink = imgnode.SelectSingleNode("img").Attributes["src"].Value;
                if (!string.IsNullOrEmpty(imglink))
                    imglink = "https://novelfull.com" + imglink;

                HtmlNode nodes = doc.DocumentNode.SelectNodes("//div[@class='info']/div").Where(x => x.InnerText.Contains("Author:")).FirstOrDefault();
                author = HttpUtility.HtmlDecode(
                               nodes?.InnerText
                           ?.Replace("Author:", ""));

                HtmlNode nodes1 = doc.DocumentNode.SelectNodes("//div[@class='info']/div").Where(x => x.InnerText.Contains("Genre:")).FirstOrDefault();
                genre = HttpUtility.HtmlDecode(
                               nodes1?.InnerText
                           ?.Replace("Genre:", ""));

                artist = "Unknown";

                release = "Unknown";

                HtmlNode nodes2 = doc.DocumentNode.SelectNodes("//div[@class='info']/div").Where(x => x.InnerText.Contains("Status:")).FirstOrDefault();
                status = HttpUtility.HtmlDecode(
                               nodes2?.InnerText
                           ?.Replace("Status:", ""));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return new NovelSummaryModel(author, artist, genre, release, imglink,
                status);
        }

        public static NovelSypnosisModel GetNovelFullSypnosis(string url)
        {
            string sypnosis = string.Empty;
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = htmlWeb.Load($"{url}");

                doc.OptionEmptyCollection = true;

                HtmlNode nodes = doc.DocumentNode.SelectNodes("//div[@class='desc-text']").FirstOrDefault();
                sypnosis = HttpUtility.HtmlDecode(nodes.InnerText)?.Trim();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new NovelSypnosisModel(sypnosis);
        }

        public static List<NovelChapterModel> GetNovelFullChapterList(string url)
        {
            var ChapterListData = new List<NovelChapterModel>();
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = htmlWeb.Load($"{url}");

                doc.OptionEmptyCollection = true;

                HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div/div/div/div/div[@class='col-xs-12 col-sm-6 col-md-6']/ul/li").ToArray();
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
                    if (!string.IsNullOrEmpty(chapterlink))
                        chapterlink = "https://novelfull.com" + chapterlink;

                    var daterelease = "Unknown";

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

                HtmlNode linknode = doc.DocumentNode.SelectNodes("//div[@id='chapter-nav-top']").First();
                Console.WriteLine(linknode.InnerHtml);
                previouschapter = linknode?.SelectSingleNode(".//a[@id='prev_chap'][@href]")?.GetAttributeValue("href", string.Empty); 
                if (!string.IsNullOrEmpty(previouschapter))
                    previouschapter = "https://novelfull.com" + previouschapter;

                nextchapter = linknode?.SelectSingleNode(".//a[@id='next_chap'][@href]")?.GetAttributeValue("href", string.Empty);
                if (!string.IsNullOrEmpty(nextchapter))
                    nextchapter = "https://novelfull.com" + nextchapter;

                HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//div[@class='chapter-c']/p").ToArray();
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

        ~NovelFullScrapper()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
