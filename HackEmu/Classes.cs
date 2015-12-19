using System.IO;

namespace HackEmu {
    public class Settings_t {
        public decimal IterationTimeMin, IterationTimeMax, PeriodMin, PeriodMax;
        public string PassToFind;

        public Settings_t() {
            IterationTimeMin = 10;
            IterationTimeMax = 20;
            PeriodMin = 1.5M;
            PeriodMax = 3;
            PassToFind = "MySuperPass";
        }

        public void Save(string Filename) {
            int[] tmp = decimal.GetBits(IterationTimeMin);
            string sToWrite = tmp.ToString();       
            tmp = decimal.GetBits(IterationTimeMax);
            sToWrite += tmp.ToString();
        }
    }
}
