using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogPencereleriVeFormAcma
{
    public partial class MessageBoxlarVeKullanimlari : Form
    {
        public MessageBoxlarVeKullanimlari()
        {
            InitializeComponent();

            Button btn_deneme = new Button();
            btn_deneme.Text = "Söyleyin Bişi";
            btn_deneme.Location = new Point(10, 260);
            btn_deneme.Click += Btn_deneme_Click;//Delegate
            this.Controls.Add(btn_deneme);

        }

        private void Btn_deneme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uyarı", "Uyarı");
        }

        private void btn_standart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kategori Eklendi", "Başarılı");
        }

        private void btn_button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Veri Silinsin mi", "Veri Uyarısı", MessageBoxButtons.OKCancel);

            if (sonuc == DialogResult.OK)
            {
                label1.Text = "OK Seçildi";
            }
            if (sonuc == DialogResult.Cancel)
            {
                label1.Text = "İptal Edildi";
            }
        }

        private void btn_button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Veri Silinsin mi", "Veri Uyarısı", MessageBoxButtons.YesNo);

            if (sonuc == DialogResult.Yes)
            {
                label1.Text = "Yes Seçildi";
            }
            else if (sonuc == DialogResult.No)
            {
                label1.Text = "No Seçildi";
            }
            else
            {
                label1.Text = "else 'e Düştü";
            }
        }

        private void btn_buton3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Veri Silinsin mi", "Veri Uyarısı", MessageBoxButtons.YesNoCancel);

            if (sonuc == DialogResult.Yes)
            {
                label1.Text = "Yes Seçildi";
            }
            else if (sonuc == DialogResult.No)
            {
                label1.Text = "No Seçildi";
            }
            else
            {
                label1.Text = "else 'e Düştü";
            }
        }

        private void btn_buton4_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Veri Silinsin mi", "Veri Uyarısı", MessageBoxButtons.RetryCancel);

            if(sonuc == DialogResult.Retry)
            {
                label1.Text = "Retry Seçildi";
            }
            else if (sonuc == DialogResult.Cancel)
            {
                label1.Text = "Cancel Seçildi";
            }
        }

        private void btn_buton5_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Veri Silinsin mi", "Veri Uyarısı", MessageBoxButtons.AbortRetryIgnore);

            if (sonuc == DialogResult.Abort)
            {
                label1.Text = "Abort Seçildi";
            }
            else if (sonuc == DialogResult.Retry)
            {
                label1.Text = "Retry Seçildi";
            }
            else if (sonuc == DialogResult.Ignore)
            {
                label1.Text = "Ignore Seçildi";
            }
        }
    }
}
