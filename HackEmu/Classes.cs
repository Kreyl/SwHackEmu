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
    }
}
