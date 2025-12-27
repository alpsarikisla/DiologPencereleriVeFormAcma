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
    public partial class MDI_Ana_Form : Form
    {
        public MDI_Ana_Form()
        {
            InitializeComponent();
            GirisForm giris_frm = new GirisForm();
            giris_frm.ShowDialog();
        }

        private void TSMI_tedarikciler_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;

            bool acikMi = false;

            foreach (Form item in acikFormlar)
            {
                if (item.GetType() == typeof(Tedarikciler))
                {
                    item.Activate();
                    acikMi = true;
                }
            }

            if (acikMi == false)
            {
                Tedarikciler frm = new Tedarikciler();
                frm.MdiParent = this;
                frm.Show();
            }
            
        }

        private void TSMI_Kategoriler_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;

            bool acikMi = false;

            foreach (Form item in acikFormlar)
            {
                if (item.GetType() == typeof(Kategoriler))
                {
                    item.Activate();
                    acikMi = true;
                }
            }

            if (acikMi == false)
            {
                Kategoriler frm = new Kategoriler();
                frm.MdiParent = this;
                frm.Show();
            }

        }
    }
}
