using NovelReader.Classes;
using NovelReader.FormsLibrary;
using NovelReaderWebScrapper.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelReader.UserControlLibrary
{
    public partial class HistoryUC : UserControl
    {
        public HistoryUC()
        {
            InitializeComponent();
        }

        private async void HistoryUC_Load(object sender, System.EventArgs e)
        {
            historydatagridview.Rows.Clear();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            historydatagridview.Refresh();
            historydatagridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            historydatagridview.RowHeadersVisible = false;

            await LoadHistoryDataAsync();
        }

        private List<HistoryModel> PrepareHistoryData()
        {
            return DatabaseAccess.LoadHistoryData();
        }

        private async Task LoadHistoryDataAsync()
        {
            List<HistoryModel> historyDatas = PrepareHistoryData();

            foreach (var history in historyDatas)
            {
                await Task.Run(() =>
                AddDataGridRows(history.NovelName, history.PreviousChapterLink, history.Source));
            }
        }

        private void AddDataGridRows(string novelname, string link, int source)
        {
            if (this.historydatagridview.InvokeRequired)
            {
                this.historydatagridview.Invoke(new MethodInvoker(delegate ()
                {
                    historydatagridview.Rows.Add(
                        novelname,
                        link,
                        source,
                        "Read",
                        "Remove");
                }
                ));
            }
        }

        private async void historydatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (historydatagridview.Rows.Count >= 1)
            {
                if (e.ColumnIndex == 3)
                {
                    NovelChapterReaderForm f1 = new NovelChapterReaderForm(historydatagridview.CurrentRow.Cells["NovelName"].Value.ToString(), 
                        historydatagridview.CurrentRow.Cells["PreviousChapterLink"].Value.ToString(),
                        Convert.ToInt32(historydatagridview.CurrentRow.Cells["Source"].Value.ToString()));
                }
                else if(e.ColumnIndex == 4)
                {
                    DatabaseAccess.RemoveHistory(historydatagridview.CurrentRow.Cells["NovelName"].Value.ToString(),
                        Convert.ToInt32(historydatagridview.CurrentRow.Cells["Source"].Value.ToString()));

                    historydatagridview.Rows.Clear();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    historydatagridview.Refresh();

                    await LoadHistoryDataAsync();
                }
            }
        }
    }
}
