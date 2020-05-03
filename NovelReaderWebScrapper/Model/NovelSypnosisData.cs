using System;

namespace NovelReaderWebScrapper.Model
{
    public class NovelSypnosisModel
    {
        public string Sypnosis { get; set; }
        public NovelSypnosisModel(string _Sypnosis)
        {
            Sypnosis = _Sypnosis;
        }
        ~NovelSypnosisModel()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
