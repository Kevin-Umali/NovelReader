using System;
using System.Threading.Tasks;

namespace NovelReader
{
    public class ForceCloseMessageBox
    {
        public static void ForceMessageBoxClose(string _Message, int _span)
        {
            var w = new System.Windows.Forms.Form() { Size = new System.Drawing.Size(0, 0) };
            Task.Delay(TimeSpan.FromSeconds(_span))
                .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
            System.Windows.Forms.MessageBox.Show(w, _Message, "Information", System.Windows.Forms.MessageBoxButtons.OK);
        }

        private static bool CheckOpened(string name)
        {
            System.Windows.Forms.FormCollection fc = System.Windows.Forms.Application.OpenForms;

            foreach (System.Windows.Forms.Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
