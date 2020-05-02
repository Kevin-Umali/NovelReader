using NovelReaderWebScrapper.DataConstructor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelReader
{
    public partial class MainForm : Form
    {
        private Guna.UI.Lib.ScrollBar.PanelScrollHelper vscrollHelper;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm();

        string orderby = "alphabet";

        string source = $"{Properties.Settings.Default.Source}";
        string previous = string.Empty, next = string.Empty;
        public MainForm()
        {
            InitializeComponent();

            shadowForm.SetShadowForm(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData($"{source}", false);
            vscrollHelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flowLayoutPanel1, gunaVScrollBar1, true);
            this.Focus();
        }
        #region Load Novel to Panel
        void LoadData(string url, bool isSearch)
        {
            if (flowLayoutPanel1.Controls.Count >= 1)
            {
                if (DisposeCard(flowLayoutPanel1))
                {
                    GetPreviousAndNextUrl($"{url}");

                    List<NovelData> NovelDataList = NovelReaderWebScrapper.Website.BoxNovelScrapper.GetBoxNovelData($"{url}", isSearch);
                    if (NovelDataList.Count >= 1)
                    {
                        noItempanel.SendToBack();
                        NovelDataAdd(NovelDataList);
                    }
                    else
                    {
                        noItempanel.BringToFront();
                    }
                }
            }
            else
            {
                GetPreviousAndNextUrl(url);

                List<NovelData> NovelDataList = NovelReaderWebScrapper.Website.BoxNovelScrapper.GetBoxNovelData($"{url}", isSearch);
                if (NovelDataList.Count >= 1)
                {
                    noItempanel.SendToBack();
                    NovelDataAdd(NovelDataList);
                }
                else
                {
                    noItempanel.BringToFront();
                }
            }

            lblNovelIndicator.Text = "true";

        }
        private void NovelDataAdd(List<NovelData> data)
        {
            foreach (var item in data)
            {
                System.Threading.Thread.Sleep(20);
                AddNovelCardAsync(item.Title, item.LatestChapter,
                    item.Link, item.ImgLink, item.Rating);
            }
        }
        int valcolor = 0;
        public async void AddNovelCardAsync(string title, string latestchapter, string link, string imglink, string rating)
        {
            NovelReaderUserControlLibrary.NovelCard nc
                = new NovelReaderUserControlLibrary.NovelCard();

            valcolor = (valcolor.Equals(1) ? 0 : 1);

            nc.SendNovelCardData(title, latestchapter, link, imglink, rating, valcolor);

            await Task.Run(() =>
            {
                if (this.flowLayoutPanel1.InvokeRequired)
                {
                    this.flowLayoutPanel1.Invoke(new Action(delegate ()
                    {
                        flowLayoutPanel1.Controls.Add(nc);

                        flowLayoutPanel1.Invalidate();
                        flowLayoutPanel1.Update();
                        flowLayoutPanel1.Refresh();
                    }));
                }
            });
        }
        #endregion
        private void GetPreviousAndNextUrl(string url)
        {
            var extract = NovelReaderWebScrapper.Website.BoxNovelScrapper.GetPreviosNextLinkAndResult($"{url}");

            next = extract.NextLink;
            previous = extract.PreviousLink;
            lblresult.Text = $"{extract.Result}";

            btnNext.Enabled = (string.IsNullOrEmpty(next) ? false : true);
            btnPrev.Enabled = (string.IsNullOrEmpty(previous) ? false : true);
        }




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
            ForceCloseMessageBox.ForceMessageBoxClose("Wait a moment.", 2);
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

        void NovelCard_Click(object sender, EventArgs e, string title, string link, string rating)
        {
            NovelInformationForm f1 = new NovelInformationForm(title, link, rating);
            f1.ShowDialog();
            f1.pictureBox1.Dispose();
            f1.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void lblNovelIndicator_TextChanged(object sender, EventArgs e)
        {
            if (lblNovelIndicator.Text.Equals("true"))
            {
                AddEventOnNovelCard();
                lblNovelIndicator.Text = "false";
            }
            else
            {

            }
            this.Focus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(next))
                LoadData($"{next}", false);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
                LoadData($"https://boxnovel.com/?s={txtSearch.Text}&post_type=wp-manga&m_orderby={orderby}", true);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;
            orderby = btn.Tag.ToString();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(previous))
                LoadData($"{previous}", false);
        }
    }
}
