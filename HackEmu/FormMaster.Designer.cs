namespace HackEmu {
    partial class FormMaster {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPeriodMax = new System.Windows.Forms.TextBox();
            this.textBoxPeriodMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxIterationTimeMax = new System.Windows.Forms.TextBox();
            this.textBoxIterationTimeMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPeriodMax);
            this.groupBox1.Controls.Add(this.textBoxPeriodMin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Период выдачи заданий";
            // 
            // textBoxPeriodMax
            // 
            this.textBoxPeriodMax.Location = new System.Drawing.Point(106, 63);
            this.textBoxPeriodMax.MaxLength = 9;
            this.textBoxPeriodMax.Name = "textBoxPeriodMax";
            this.textBoxPeriodMax.ShortcutsEnabled = false;
            this.textBoxPeriodMax.Size = new System.Drawing.Size(36, 20);
            this.textBoxPeriodMax.TabIndex = 5;
            this.textBoxPeriodMax.Text = "3";
            this.textBoxPeriodMax.WordWrap = false;
            this.textBoxPeriodMax.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxPeriodMin
            // 
            this.textBoxPeriodMin.Location = new System.Drawing.Point(106, 35);
            this.textBoxPeriodMin.MaxLength = 9;
            this.textBoxPeriodMin.Name = "textBoxPeriodMin";
            this.textBoxPeriodMin.ShortcutsEnabled = false;
            this.textBoxPeriodMin.Size = new System.Drawing.Size(36, 20);
            this.textBoxPeriodMin.TabIndex = 4;
            this.textBoxPeriodMin.Text = "1";
            this.textBoxPeriodMin.WordWrap = false;
            this.textBoxPeriodMin.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Максимум, минут:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Минимум, минут:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPass);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подбираемый пароль";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(18, 35);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(124, 20);
            this.textBoxPass.TabIndex = 1;
            this.textBoxPass.Text = "SuperMegaPass";
            this.textBoxPass.WordWrap = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxIterationTimeMax);
            this.groupBox3.Controls.Add(this.textBoxIterationTimeMin);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(180, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 99);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Время подбора пароля";
            // 
            // textBoxIterationTimeMax
            // 
            this.textBoxIterationTimeMax.Location = new System.Drawing.Point(106, 63);
            this.textBoxIterationTimeMax.MaxLength = 9;
            this.textBoxIterationTimeMax.Name = "textBoxIterationTimeMax";
            this.textBoxIterationTimeMax.ShortcutsEnabled = false;
            this.textBoxIterationTimeMax.Size = new System.Drawing.Size(36, 20);
            this.textBoxIterationTimeMax.TabIndex = 3;
            this.textBoxIterationTimeMax.Text = "20";
            this.textBoxIterationTimeMax.WordWrap = false;
            this.textBoxIterationTimeMax.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxIterationTimeMin
            // 
            this.textBoxIterationTimeMin.Location = new System.Drawing.Point(106, 35);
            this.textBoxIterationTimeMin.MaxLength = 9;
            this.textBoxIterationTimeMin.Name = "textBoxIterationTimeMin";
            this.textBoxIterationTimeMin.ShortcutsEnabled = false;
            this.textBoxIterationTimeMin.Size = new System.Drawing.Size(36, 20);
            this.textBoxIterationTimeMin.TabIndex = 2;
            this.textBoxIterationTimeMin.Text = "10";
            this.textBoxIterationTimeMin.WordWrap = false;
            this.textBoxIterationTimeMin.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Максимум, минут:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Минимум, минут:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 229);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7);
            this.panel1.Size = new System.Drawing.Size(355, 46);
            this.panel1.TabIndex = 4;
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnApply.Image = global::HackEmu.Properties.Resources.Checked2;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(150, 7);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(99, 32);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Применить";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Image = global::HackEmu.Properties.Resources.stop_16x16;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(249, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(99, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormMaster
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(355, 275);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox textBoxPeriodMax;
        public System.Windows.Forms.TextBox textBoxPeriodMin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox textBoxIterationTimeMax;
        public System.Windows.Forms.TextBox textBoxIterationTimeMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
    }
}