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
using NovelReader;

namespace NovelReaderUserControlLibrary
{
    public partial class BrowseNovelUC : UserControl
    {
        private Guna.UI.Lib.ScrollBar.PanelScrollHelper vscrollHelper;

        int sourcesite;
        string previouslink = string.Empty, nextlink = string.Empty;
        public BrowseNovelUC(int _sourcesite)
        {
            InitializeComponent();
            sourcesite = _sourcesite;
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
                    lblNovelIndicator.Text = "true";
                }
                else
                {
                    await LoadNovelDataToCardAsync
                        ($"{SourcePickerMethod.GetSourceUrl((SourcePickerMethod.Source)sourcesite)}", false);
                    lblNovelIndicator.Text = "true";
                }
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (DisposeCard(flowLayoutPanel1))
            {
                await LoadNovelDataToCardAsync(SourcePickerMethod.GetSourceUrl((SourcePickerMethod.Source)sourcesite), false);
                lblNovelIndicator.Text = "true";
            }
        }
        private void lblNovelIndicator_TextChanged(object sender, EventArgs e)
        {
            if (lblNovelIndicator.Text.Equals("true"))
            {
                AddEventOnNovelCard();
                lblNovelIndicator.Text = "false";
            }
            else { }
            this.Focus();
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
            List<Task<NovelReaderUserControlLibrary.NovelCard>> novelTasks = new List<Task<NovelReaderUserControlLibrary.NovelCard>>();

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
        private NovelReaderUserControlLibrary.NovelCard AddNovelCardValue(string title, string latestchapter, string link, string imglink, string rating)
        {
            NovelReaderUserControlLibrary.NovelCard nc
                = new NovelReaderUserControlLibrary.NovelCard();


            return nc.SendNovelCardData(title, latestchapter, link, imglink, rating);
        }

        private void NovelCardToPanel(NovelReaderUserControlLibrary.NovelCard novelCard)
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

        #region Disposing novel card, adding event and removing it.
        static bool DisposeCard(FlowLayoutPanel mypanel)
        {
            foreach (NovelReaderUserControlLibrary.NovelCard novelCard in mypanel.Controls)
            {
                novelCard.pictureBox1.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

                foreach (Label lbl in novelCard.Controls.OfType<Label>())
                    RemoveClickEvent(lbl);

                foreach (PictureBox pic in novelCard.Controls.OfType<PictureBox>())
                    RemoveClickEvent(pic);


                RemoveClickEvent(novelCard);
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

        private static void RemoveClickEvent(Control b)
        {
            System.Reflection.FieldInfo f1 = typeof(Control).GetField("EventClick",
                System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
            object obj = f1.GetValue(b);
            System.Reflection.PropertyInfo pi = b.GetType().GetProperty("Events",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(b, null);
            list.RemoveHandler(obj, list[obj]);
        }

        private void AddEventOnNovelCard()
        {
            foreach (var c in this.flowLayoutPanel1.Controls.OfType<NovelReaderUserControlLibrary.NovelCard>())
            {
                //new ElapsedEventHandler((sender, e) => PlayMusicEvent(sender, e, musicNote))
                c.Click += new EventHandler((sender, e) => NovelCard_Click(sender, e, c._title, c._link, c._rating));

                //{ NovelCard_Click(sender, e, c._title, c._link, c._imglink, c._rating); };

                foreach (var x in c.Controls.OfType<Label>())
                {
                    x.Click += new EventHandler((sender, e) => NovelCard_Click(sender, e, c._title, c._link, c._rating));
                }

                foreach (var x in c.Controls.OfType<PictureBox>())
                {
                    x.Click += new EventHandler((sender, e) => NovelCard_Click(sender, e, c._title, c._link, c._rating));
                }
            }
        }

        private void NovelCard_Click(object sender, EventArgs e, string title, string link, string rating)
        {
            NovelInformationForm f1 = new NovelInformationForm(title, link, rating, sourcesite);
            f1.ShowDialog();
            f1.pictureBox1.Dispose();
            f1.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
        #endregion

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (DisposeCard(flowLayoutPanel1))
            {
                if (!string.IsNullOrEmpty(nextlink))
                {
                    await LoadNovelDataToCardAsync(nextlink, false);
                    lblNovelIndicator.Text = "true";
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
                    lblNovelIndicator.Text = "true";
                }
            }
        }
    }
}
