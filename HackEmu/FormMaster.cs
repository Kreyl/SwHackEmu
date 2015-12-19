using System;
using System.Drawing;
using System.Windows.Forms;

namespace HackEmu {
    public enum Rslt { OK = 0, Failure = 1, CmdError = 2 };

    public partial class FormMaster : Form {
        public FormMaster(Settings_t ASettings) {
            InitializeComponent();
            textBoxIterationTimeMin.Text = ASettings.IterationTimeMin.ToString();
            textBoxIterationTimeMax.Text = ASettings.IterationTimeMax.ToString();
            textBoxPeriodMin.Text = ASettings.PeriodMin.ToString();
            textBoxPeriodMax.Text = ASettings.PeriodMax.ToString();
            textBoxPass.Text = ASettings.PassToFind;
        }

        private Rslt CheckInput(TextBox tb) {
            decimal Dummy;
            if(Decimal.TryParse(tb.Text, out Dummy)) {
                tb.BackColor = SystemColors.Window;
                return Rslt.OK;
            }
            else {
                tb.BackColor = Color.Red;
                return Rslt.Failure;
            }
        }

        private Rslt CheckMinMax(TextBox tbMin, TextBox tbMax) {
            Decimal min, max;
            Decimal.TryParse(tbMin.Text, out min);
            Decimal.TryParse(tbMax.Text, out max);
            if(min <= max) {
                tbMin.BackColor = SystemColors.Window;
                tbMax.BackColor = SystemColors.Window;
                return Rslt.OK;
            }
            else {
                tbMin.BackColor = Color.Yellow;
                tbMax.BackColor = Color.Yellow;
                return Rslt.Failure;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e) {
            // Check if numbers
            bool g1 = CheckInput(textBoxIterationTimeMax) == Rslt.OK;
            bool g2 = CheckInput(textBoxIterationTimeMin) == Rslt.OK;
            bool g3 = CheckInput(textBoxPeriodMax) == Rslt.OK;
            bool g4 = CheckInput(textBoxPeriodMin) == Rslt.OK;
            bool NumbersOk = g1 && g2 && g3 && g4;
            if(NumbersOk) {
                // Check that Min < Max
                g1 = CheckMinMax(textBoxIterationTimeMin, textBoxIterationTimeMax) == Rslt.OK;
                g2 = CheckMinMax(textBoxPeriodMin, textBoxPeriodMax) == Rslt.OK;
            }
            btnApply.Enabled = NumbersOk && g1 && g2;
        }
    }

}
