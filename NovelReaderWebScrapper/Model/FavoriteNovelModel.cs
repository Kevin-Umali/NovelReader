using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelReaderWebScrapper.Model
{
    public class FavoriteNovelModel
    {
        public int ID { get; set; }
        public string NovelName { get; set; }
        public string NovelLink { get; set; }
        public string Img { get; set; }
        public string Source { get; set; }

        ~FavoriteNovelModel()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
