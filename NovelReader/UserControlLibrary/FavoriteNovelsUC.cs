using NovelReader.Classes;
using NovelReaderWebScrapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelReader.UserControlLibrary
{
    public partial class FavoriteNovelsUC : UserControl
    {
        private Guna.UI.Lib.ScrollBar.PanelScrollHelper vscrollHelper;
        public FavoriteNovelsUC()
        {
            InitializeComponent();
        }
        #region Prepare data of favorite novels
        private List<FavoriteNovelModel> PrepareFavoriteNovelData(string search)
        {
            List<FavoriteNovelModel> favoriteNovels = DatabaseAccess.LoadFavoriteData(search);
            return favoriteNovels;
        }

        private async Task LoadFavoriteNovelDataToCardAsync(string search)
        {
            List<FavoriteNovelModel> novelDatas = PrepareFavoriteNovelData(search);
            List<Task<Cards.FavoriteNovelCard>> novelTasks = new List<Task<Cards.FavoriteNovelCard>>();

            if (novelDatas.Count() >= 1)
            {
                noItempanel.SendToBack();
                foreach (FavoriteNovelModel novelitem in novelDatas)
                {
                    novelTasks.Add(Task.Run(() => AddFavoriteNovelCardValue(novelitem.NovelName, novelitem.NovelLink,
                        novelitem.Img, Convert.ToInt32(novelitem.Source))));
                }

                var result = await Task.WhenAll(novelTasks);

                foreach (var item in result)
                {
                    await Task.Run(() => FavoriteNovelCardToPanel(item));
                }
            }
            else
            {
                noItempanel.BringToFront();
            }
        }
        private Cards.FavoriteNovelCard AddFavoriteNovelCardValue(string title, string novellink, string imglink, int sourcesite)
        {
            Cards.FavoriteNovelCard nfc = new Cards.FavoriteNovelCard(sourcesite);
            return nfc.SendFavoriteNovelCardData(title, novellink, imglink);
        }

        private void FavoriteNovelCardToPanel(Cards.FavoriteNovelCard favoriteNovelCard)
        {
            if (this.flowLayoutPanel1.InvokeRequired)
            {
                this.flowLayoutPanel1.Invoke(new MethodInvoker(delegate ()
                {
                    flowLayoutPanel1.Controls.Add(favoriteNovelCard);
                }));
            }
            else
            {
                flowLayoutPanel1.Controls.Add(favoriteNovelCard);
            }
        }
        #endregion
        #region Disposing novel card.
        static bool DisposeCard(FlowLayoutPanel mypanel)
        {
            foreach (Cards.FavoriteNovelCard novelCard in mypanel.Controls)
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
        private void FavoriteNovelsUC_Load(object sender, EventArgs e)
        {
            vscrollHelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flowLayoutPanel1, gunaVScrollBar1, true);
            timer1.Start();
            //var data = DatabaseAccess.LoadFavoriteData(null);
            //foreach (var xx in data)
            //    Console.WriteLine($"{xx.ID} {xx.NovelName} {xx.NovelLink} {Environment.NewLine} {xx.Img} {xx.Source} {Environment.NewLine} {Environment.NewLine}");
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (DisposeCard(flowLayoutPanel1))
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                    await LoadFavoriteNovelDataToCardAsync(txtSearch.Text);
                else
                    timer1.Start();
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (DisposeCard(flowLayoutPanel1))
            {
                await LoadFavoriteNovelDataToCardAsync(null);
            }
        }

        ~FavoriteNovelsUC()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
