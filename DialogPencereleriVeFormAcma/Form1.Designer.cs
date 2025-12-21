namespace DialogPencereleriVeFormAcma
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sec = new System.Windows.Forms.Button();
            this.pb_resim = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_kaydet = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lbl_saveFile = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_ac = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_klasorAc = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_secilenRenk = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_fontSec = new System.Windows.Forms.Button();
            this.lbl_secilenFont = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cb_fontlar = new System.Windows.Forms.ComboBox();
            this.lbl_fontTest = new System.Windows.Forms.Label();
            this.btn_degistir = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_richKaydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pb_resim);
            this.groupBox1.Controls.Add(this.btn_sec);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open File Dialog";
            // 
            // btn_sec
            // 
            this.btn_sec.Location = new System.Drawing.Point(118, 19);
            this.btn_sec.Name = "btn_sec";
            this.btn_sec.Size = new System.Drawing.Size(75, 23);
            this.btn_sec.TabIndex = 0;
            this.btn_sec.Text = "Dosya Seç";
            this.btn_sec.UseVisualStyleBackColor = true;
            this.btn_sec.Click += new System.EventHandler(this.btn_sec_Click);
            // 
            // pb_resim
            // 
            this.pb_resim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_resim.Location = new System.Drawing.Point(6, 19);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(106, 91);
            this.pb_resim.TabIndex = 1;
            this.pb_resim.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dialog Result = ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ac);
            this.groupBox2.Controls.Add(this.lbl_saveFile);
            this.groupBox2.Controls.Add(this.btn_kaydet);
            this.groupBox2.Controls.Add(this.tb_kaydet);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save File Dialog";
            // 
            // tb_kaydet
            // 
            this.tb_kaydet.Location = new System.Drawing.Point(6, 19);
            this.tb_kaydet.Multiline = true;
            this.tb_kaydet.Name = "tb_kaydet";
            this.tb_kaydet.Size = new System.Drawing.Size(200, 150);
            this.tb_kaydet.TabIndex = 0;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(212, 19);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 1;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // lbl_saveFile
            // 
            this.lbl_saveFile.AutoSize = true;
            this.lbl_saveFile.Location = new System.Drawing.Point(212, 105);
            this.lbl_saveFile.Name = "lbl_saveFile";
            this.lbl_saveFile.Size = new System.Drawing.Size(35, 13);
            this.lbl_saveFile.TabIndex = 2;
            this.lbl_saveFile.Text = "label2";
            // 
            // btn_ac
            // 
            this.btn_ac.Location = new System.Drawing.Point(212, 48);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(75, 23);
            this.btn_ac.TabIndex = 3;
            this.btn_ac.Text = "Aç";
            this.btn_ac.UseVisualStyleBackColor = true;
            this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.btn_klasorAc);
            this.groupBox3.Location = new System.Drawing.Point(330, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 318);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Folder Browser Dialog";
            // 
            // btn_klasorAc
            // 
            this.btn_klasorAc.Location = new System.Drawing.Point(6, 19);
            this.btn_klasorAc.Name = "btn_klasorAc";
            this.btn_klasorAc.Size = new System.Drawing.Size(188, 23);
            this.btn_klasorAc.TabIndex = 0;
            this.btn_klasorAc.Text = "Klasör Seç";
            this.btn_klasorAc.UseVisualStyleBackColor = true;
            this.btn_klasorAc.Click += new System.EventHandler(this.btn_klasorAc_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 264);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_secilenRenk);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(536, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 76);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Color Dialog";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Renk Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_secilenRenk
            // 
            this.lbl_secilenRenk.AutoSize = true;
            this.lbl_secilenRenk.Location = new System.Drawing.Point(6, 48);
            this.lbl_secilenRenk.Name = "lbl_secilenRenk";
            this.lbl_secilenRenk.Size = new System.Drawing.Size(163, 13);
            this.lbl_secilenRenk.TabIndex = 1;
            this.lbl_secilenRenk.Text = "Seçtiğiniz Renkleri Burada Görün";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_secilenFont);
            this.groupBox5.Controls.Add(this.btn_fontSec);
            this.groupBox5.Location = new System.Drawing.Point(536, 94);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(252, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Font Dialog";
            // 
            // btn_fontSec
            // 
            this.btn_fontSec.Location = new System.Drawing.Point(9, 25);
            this.btn_fontSec.Name = "btn_fontSec";
            this.btn_fontSec.Size = new System.Drawing.Size(75, 23);
            this.btn_fontSec.TabIndex = 0;
            this.btn_fontSec.Text = "Font Seç";
            this.btn_fontSec.UseVisualStyleBackColor = true;
            this.btn_fontSec.Click += new System.EventHandler(this.btn_fontSec_Click);
            // 
            // lbl_secilenFont
            // 
            this.lbl_secilenFont.AutoSize = true;
            this.lbl_secilenFont.Location = new System.Drawing.Point(6, 54);
            this.lbl_secilenFont.Name = "lbl_secilenFont";
            this.lbl_secilenFont.Size = new System.Drawing.Size(163, 13);
            this.lbl_secilenFont.TabIndex = 2;
            this.lbl_secilenFont.Text = "Seçtiğiniz Font Özelliklerini Görün";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_degistir);
            this.groupBox6.Controls.Add(this.lbl_fontTest);
            this.groupBox6.Controls.Add(this.cb_fontlar);
            this.groupBox6.Location = new System.Drawing.Point(536, 196);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(252, 88);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Yüklü Fontlar Listesi";
            // 
            // cb_fontlar
            // 
            this.cb_fontlar.FormattingEnabled = true;
            this.cb_fontlar.Location = new System.Drawing.Point(9, 25);
            this.cb_fontlar.Name = "cb_fontlar";
            this.cb_fontlar.Size = new System.Drawing.Size(228, 21);
            this.cb_fontlar.TabIndex = 0;
            // 
            // lbl_fontTest
            // 
            this.lbl_fontTest.AutoSize = true;
            this.lbl_fontTest.Location = new System.Drawing.Point(74, 57);
            this.lbl_fontTest.Name = "lbl_fontTest";
            this.lbl_fontTest.Size = new System.Drawing.Size(163, 13);
            this.lbl_fontTest.TabIndex = 3;
            this.lbl_fontTest.Text = "Seçtiğiniz Font Özelliklerini Görün";
            // 
            // btn_degistir
            // 
            this.btn_degistir.Location = new System.Drawing.Point(9, 52);
            this.btn_degistir.Name = "btn_degistir";
            this.btn_degistir.Size = new System.Drawing.Size(59, 23);
            this.btn_degistir.TabIndex = 4;
            this.btn_degistir.Text = "Değiştir";
            this.btn_degistir.UseVisualStyleBackColor = true;
            this.btn_degistir.Click += new System.EventHandler(this.btn_degistir_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.btn_richKaydet);
            this.groupBox7.Controls.Add(this.richTextBox1);
            this.groupBox7.Location = new System.Drawing.Point(794, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(409, 318);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Rich Text Box";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(397, 253);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btn_richKaydet
            // 
            this.btn_richKaydet.Location = new System.Drawing.Point(328, 278);
            this.btn_richKaydet.Name = "btn_richKaydet";
            this.btn_richKaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_richKaydet.TabIndex = 1;
            this.btn_richKaydet.Text = "Kaydet";
            this.btn_richKaydet.UseVisualStyleBackColor = true;
            this.btn_richKaydet.Click += new System.EventHandler(this.btn_richKaydet_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Renk Değiştir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 344);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_sec;
        private System.Windows.Forms.PictureBox pb_resim;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_kaydet;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label lbl_saveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_ac;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_klasorAc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_secilenRenk;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_fontSec;
        private System.Windows.Forms.Label lbl_secilenFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbl_fontTest;
        private System.Windows.Forms.ComboBox cb_fontlar;
        private System.Windows.Forms.Button btn_degistir;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_richKaydet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}

