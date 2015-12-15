using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HackEmu {
    public partial class FormPassReq : Form {
        public FormPassReq() {
            InitializeComponent();
        }

        public string EnteredPass {
            get { return textBoxPass.Text; }
        }
    }
}
