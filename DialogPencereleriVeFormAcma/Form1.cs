using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogPencereleriVeFormAcma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pb_resim.SizeMode = PictureBoxSizeMode.Zoom;
            openFileDialog1.Filter = ".jpg Dosyası |*.jpg| .jpeg Dosyası |*.jpeg| Tüm Dosya Türleri | *.*";
            saveFileDialog1.Filter = "alp Dosyası|*.alp";
            openFileDialog2.Filter = "alp Dosyası|*.alp";
            FontlariGetir();
            string txtYol = @"C:\Alp/leBron.txt";
            string rtfYol = @"C:\Alp/leBron.rtf";
            richTextBox1.LoadFile(rtfYol);
        }

        private void btn_sec_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            label1.Text = "Dialog Result = " + sonuc.ToString();
            if (sonuc == DialogResult.OK)
            {
                pb_resim.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_kaydet.Text))
            {
                DialogResult sonuc = saveFileDialog1.ShowDialog();
                lbl_saveFile.Text = sonuc.ToString();
                string dosyaYolu = "";
                if (sonuc == DialogResult.OK)
                {
                    dosyaYolu = saveFileDialog1.FileName;
                    StreamWriter yazici = new StreamWriter(dosyaYolu);
                    yazici.WriteLine(tb_kaydet.Text);
                    yazici.Close();
                }
            }
            else
            {
                lbl_saveFile.Text = "Metin Kutusu Boş olamaz";
            }
        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog2.FileName;
                StreamReader okuyucu = new StreamReader(path);
                tb_kaydet.Text = okuyucu.ReadToEnd();
                okuyucu.Close();
            }
        }

        private void btn_klasorAc_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                string path = folderBrowserDialog1.SelectedPath;
                DirectoryInfo klasor = new DirectoryInfo(path);
                List<FileInfo> dosyalar = klasor.GetFiles().ToList();
                foreach (FileInfo item in dosyalar)
                {
                    listBox1.Items.Add(item.Name);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color secilen = colorDialog1.Color;
                lbl_secilenRenk.ForeColor = secilen;
                lbl_secilenRenk.Text = secilen.Name;
            }
        }

        private void btn_fontSec_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font fnt = fontDialog1.Font;
                lbl_secilenFont.Font = fnt;
                
            }
        }
         
        private void FontlariGetir()
        {
            List<FontFamily> fontlar = FontFamily.Families.ToList();

            foreach (FontFamily item in fontlar)
            {
                cb_fontlar.Items.Add(item.Name);
            }

        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cb_fontlar.Text))
            {
               
                List<FontFamily> fontlar = FontFamily.Families.ToList();
                
                foreach (FontFamily item in fontlar)
                {
                    if (item.Name == cb_fontlar.Text)
                    {
                        Font fnt = new Font(item, lbl_fontTest.Font.Size);
                        lbl_fontTest.Font = fnt;
                        break;
                    }
                }

               

            }
        }

        private void btn_richKaydet_Click(object sender, EventArgs e)
        {
            string rtfYol = @"C:\Alp/leBron2.rtf";
            richTextBox1.SaveFile(rtfYol);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog2.Color;
            }
        }
    }
}
