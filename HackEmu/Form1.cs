using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HackEmu
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e) {
            // Request password
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
        }
    }
}
