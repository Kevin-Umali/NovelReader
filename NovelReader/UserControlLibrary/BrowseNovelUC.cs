using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovelReaderWebScrapper.Model;
using NovelReader.Classes;

namespace NovelReader.UserControlLibrary
{
    public partial class BrowseNovelUC : UserControl
    {
        private Guna.UI.Lib.ScrollBar.PanelScrollHelper vscrollHelper;

        int sourcesite = 0;
        string previouslink = string.Empty, nextlink = string.Empty;
        public BrowseNovelUC()
        {
            InitializeComponent();
        }

        private void BrowseNovelUC_Load(object sender, EventArgs e)
        {
            vscrollHelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flowLayoutPanel1, gunaVScrollBar1, true);
            rdoBoxnovel.Checked = true;
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            //search
            if (DisposeCard(flowLayoutPanel1))
            {
                if (!string.IsNullOrEmpty(nextlink))
                {
                    await LoadNovelDataToCardAsync
                        ($"{SourcePickerMethod.GetSourceUrl((SourcePickerMethod.Source)sourcesite)}?s={txtSearch.Text}", true);
                }
                else
                {
                    await LoadNovelDataToCardAsync
                        ($"{SourcePickerMethod.GetSourceUrl((SourcePickerMethod.Source)sourcesite)}", false);
                }
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (DisposeCard(flowLayoutPanel1))
            {
                await LoadNovelDataToCardAsync(SourcePickerMethod.GetSourceUrl((SourcePickerMethod.Source)sourcesite), false);
            }
        }
        private void rdoWuxiaWorldSite_CheckedChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2RadioButton rdo = (Guna.UI2.WinForms.Guna2RadioButton)sender;
            ChangeSource(Convert.ToInt32(rdo.Tag.ToString()));
        }

        private void ChangeSource(int sourcevalue)
        {
            sourcesite = sourcevalue;
            timer1.Start();
        }

        #region Preparing or load the data in the list.
        private List<NovelDataModel> PrepareNovelData(string url, bool isSearch)
        {
            GetSiteLink(url);
            List<NovelDataModel> novelDatas = SourcePickerMethod.GetNovelDataModels
                ($"{url}", isSearch, (SourcePickerMethod.Scrapper)sourcesite);
            return novelDatas;
        }

        private SiteLinkModel PrepareSiteLinkData(string url)
        {
            SiteLinkModel siteLinkDatas = SourcePickerMethod.GetSiteLinkModel($"{url}", (SourcePickerMethod.Scrapper)sourcesite);
            return siteLinkDatas;
        }

        private void GetSiteLink(string url)
        {
            SiteLinkModel siteLink = PrepareSiteLinkData($"{url}");
            nextlink = siteLink.NextLink;
            previouslink = siteLink.PreviousLink;
            lblresult.Text = $"{siteLink.Result}";

            btnNext.Enabled = (string.IsNullOrEmpty(nextlink) ? false : true);
            btnPrev.Enabled = (string.IsNullOrEmpty(previouslink) ? false : true);
        }
        #endregion

        private async Task LoadNovelDataToCardAsync(string url, bool isSearch)
        {
            List<NovelDataModel> novelDatas = PrepareNovelData($"{url}", isSearch);
            List<Task<Cards.NovelCard>> novelTasks = new List<Task<Cards.NovelCard>>();

            if (novelDatas.Count() >= 1)
            {
                noItempanel.SendToBack();
                foreach (NovelDataModel novelitem in novelDatas)
                {
                    novelTasks.Add(Task.Run(() => AddNovelCardValue(novelitem.Title, novelitem.LatestChapter,
                         novelitem.Link, novelitem.ImgLink, novelitem.Rating)));
                }

                var result = await Task.WhenAll(novelTasks);

                foreach (var item in result)
                {
                    await Task.Run(() => NovelCardToPanel(item));
                }
            }
            else
            {
                noItempanel.BringToFront();
            }
        }
        private Cards.NovelCard AddNovelCardValue(string title, string latestchapter, string link, string imglink, string rating)
        {
            Cards.NovelCard nc = new Cards.NovelCard(sourcesite);
            return nc.SendNovelCardData(title, latestchapter, link, imglink, rating);
        }

        private void NovelCardToPanel(Cards.NovelCard novelCard)
        {
            if (this.flowLayoutPanel1.InvokeRequired)
            {
                this.flowLayoutPanel1.Invoke(new MethodInvoker(delegate ()
                {
                    flowLayoutPanel1.Controls.Add(novelCard);
                }));
            }
            else
            {
                flowLayoutPanel1.Controls.Add(novelCard);
            }
        }

        #region Disposing novel card.
        static bool DisposeCard(FlowLayoutPanel mypanel)
        {
            foreach (Cards.NovelCard novelCard in mypanel.Controls)
            {
                novelCard.pictureBox1.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }

            mypanel.Controls.Clear();
            foreach (UserControl uc in mypanel.Controls)
            {
                uc.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }

            return true;
        }
        #endregion

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (DisposeCard(flowLayoutPanel1))
            {
                if (!string.IsNullOrEmpty(nextlink))
                {
                    await LoadNovelDataToCardAsync(nextlink, false);
                }
            }
        }

        private async void btnPrev_Click(object sender, EventArgs e)
        {
            if (DisposeCard(flowLayoutPanel1))
            {
                if (!string.IsNullOrEmpty(nextlink))
                {
                    await LoadNovelDataToCardAsync(previouslink, false);
                }
            }
        }
        ~BrowseNovelUC()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
