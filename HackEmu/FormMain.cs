using System;
using System.Drawing;
using System.Windows.Forms;

namespace HackEmu {
    public partial class FormMain : Form {
        Settings_t ISettings;

        private Random rand;
        private string StrToEnter;
        private int TimeTop, TimeCurr, TimeToNextTask;
        private const int NewTaskIntl_min = 2 * 60, NewTaskIntl_max = 3 * 60;
        
        public FormMain() {
            InitializeComponent();
            rand = new Random();
            ISettings = new Settings_t();

            int IterationTime_m = rand.Next(10, 20);
            lblTimeLeft.Text = "Время подбора: " + IterationTime_m.ToString() + " мин";
            TimeTop = IterationTime_m * 60;
            TimeCurr = 0;
            progressBar1.Maximum = TimeTop;
        }

        private string GenerateRandStr(int MinLen, int MaxLen) {
            string rslt = "";
            int Len = rand.Next(MinLen, MaxLen);
            for(int i = 0; i < Len; i++) {
                int code = rand.Next('0', 'Z' + 1);
                rslt += (char)code;
            }
            return rslt;
        }

        private void RunNewTask() {
            timer1.Enabled = false;
            StrToEnter = GenerateRandStr(4, 10);
            lblInstruction.Text = "Введите символы: " + StrToEnter;
            textBox1.Text = "";
            textBox1.Enabled = true;
            btnNext.Enabled = true;
        }

        private void Form1_Shown(object sender, EventArgs e) {
            // Request password
            while(true) {
                FormPassReq fPassReq = new FormPassReq("Master");
                fPassReq.Owner = this;
                fPassReq.ShowDialog();
                if(fPassReq.DialogResult == DialogResult.OK) {
                    string sPass = fPassReq.EnteredPass;
                    if(sPass.Equals("SuperPass", StringComparison.OrdinalIgnoreCase)) break;
                    else if(sPass.Equals("Master", StringComparison.OrdinalIgnoreCase)) {
                        // Show Master Control
                        FormMaster fMaster = new FormMaster(ISettings);
                        fMaster.Owner = this;
                        fMaster.ShowDialog();
                        if(fMaster.DialogResult == DialogResult.OK) {
                            Decimal.TryParse(fMaster.textBoxIterationTimeMax.Text, out ISettings.IterationTimeMax);
                            Decimal.TryParse(fMaster.textBoxIterationTimeMin.Text, out ISettings.IterationTimeMin);
                            Decimal.TryParse(fMaster.textBoxPeriodMax.Text, out ISettings.PeriodMax);
                            Decimal.TryParse(fMaster.textBoxPeriodMin.Text, out ISettings.PeriodMin);
                            ISettings.PassToFind = fMaster.textBoxPass.Text;
                        }
                    }
                }
                else {
                    this.Close();
                    break;
                }
            } // while

            RunNewTask();
        } // Form1_Shown

        private void btnNext_Click(object sender, EventArgs e) {
            if(textBox1.Text.Equals(StrToEnter)) {
                // Calculate next request time
                TimeToNextTask = rand.Next(NewTaskIntl_min, NewTaskIntl_max);
                // Disable controls, enable timer
                textBox1.Enabled = false;
                btnNext.Enabled = false;
                timer1.Enabled = true;
            }
            else {
                textBox1.BackColor = Color.Red;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            textBox1.BackColor = SystemColors.Window;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            TimeCurr++;
            progressBar1.Value = TimeCurr;
            int TimeLeft_m = (TimeTop - TimeCurr) / 60;
            lblTimeLeft.Text = "Время подбора: " + TimeLeft_m.ToString() + " мин";
            lblPass.Text = GenerateRandStr(4, 10);

            Application.DoEvents();

            if(--TimeToNextTask <= 0) RunNewTask();

            if(TimeCurr >= TimeTop) {
                timer1.Enabled = false;
                textBox1.Visible = false;
                btnNext.Visible = false;
                lblInstruction.Text = "Пароль подобран: MySuperPass";
            }
        }
    }

}
