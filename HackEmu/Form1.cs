using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HackEmu
{
    public partial class Form1 : Form {
        private int TimeTop, TimeCurr;

        public Form1() {
            InitializeComponent();
            Random rand = new Random();
            int IterationTime_m = rand.Next(10, 20);
            lblTimeLeft.Text = "Время подбора: " + IterationTime_m.ToString() + " мин";
            TimeTop = IterationTime_m * 60;
            TimeCurr = 0;
            progressBar1.Maximum = TimeTop;
        }

        private void Form1_Shown(object sender, EventArgs e) {
            // Request password
            /*
            string sPass = "";
            while(true) {
                FormPassReq passForm = new FormPassReq();
                passForm.Owner = this;
                passForm.ShowDialog();
                sPass = passForm.EnteredPass;
                if(passForm.DialogResult == DialogResult.OK) {
                    if(sPass.Equals("SuperPass", StringComparison.OrdinalIgnoreCase)) break;
                }
                else {
                    this.Close();
                    break;
                }
            } // while
            */

        } // Form1_Shown

        private void btnNext_Click(object sender, EventArgs e) {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            TimeCurr++;
            progressBar1.Value = TimeCurr;
            int TimeLeft_m = (TimeTop - TimeCurr) / 60;
            lblTimeLeft.Text = "Время подбора: " + TimeLeft_m.ToString() + " мин";
            Application.DoEvents();
            if(TimeCurr >= TimeTop) {
                timer1.Enabled = false;

            }
        }
    }
}
