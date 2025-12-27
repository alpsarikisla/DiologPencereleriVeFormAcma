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
    public partial class GirisForm : Form
    {
        bool girisVar = false;
        public GirisForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_kullaniciAdi.Text))
            {
                if(!string.IsNullOrEmpty(tb_sifre.Text))
                {
                    if (tb_kullaniciAdi.Text == "admin" && tb_sifre.Text == "1234")
                    {
                        girisVar = true;
                        //MDI_Ana_Form frm = new MDI_Ana_Form();
                        //frm.Show();
                        this.Close();
                    }
                
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Şifre boş bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı boş bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GirisForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Closed Çalıştı");
            if (girisVar == false)
            {
                Application.Exit();
            }
        }

        private void GirisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Closing Çalıştı");
            
        }
    }
}
