using System;

namespace NovelReaderWebScrapper.DataConstructor
{
    public class NovelSypnosisData
    {
        public string Sypnosis { get; set; }
        public NovelSypnosisData(string _Sypnosis)
        {
            Sypnosis = _Sypnosis;
        }
        ~NovelSypnosisData()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
