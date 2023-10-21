using OOPHamburgerciLibrary.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPHamburgerciUi
{
    public partial class FrmEkstraMalzemeEkle : Form
    {
        public FrmEkstraMalzemeEkle()
        {
            InitializeComponent();
        }

        private void FrmEkstraMalzemeEkle_Load(object sender, EventArgs e)
        {
            MalzemeEkle();
        }

        public void MalzemeEkle()
        {


            //txtEkstraMalzemeAdi.Text = string.Empty;
        }

        private void btnEkstraMalzemeyiKaydet_Click(object sender, EventArgs e)
        {
            if (txtEkstraMalzemeAdi.Text == string.Empty)
            {
                MessageBox.Show("Ekstra Malzeme adı boş bırakılamaz");
            }
            else
            {
                string ekstraMalzemeAdi = txtEkstraMalzemeAdi.Text;
                int malzemeFiyati = (int)numericMalzemeFiyat.Value;
                int ekstraMalzemeID = (MdiParent as Form1).EkstraMalzeme.Count + 1;

                (MdiParent as Form1).EkstraMalzeme.Add(new Ekstra { EkstaMalzemeID = ekstraMalzemeID, EkstaMalzemeAdi = ekstraMalzemeAdi, Fiyati = malzemeFiyati });

                txtEkstraMalzemeAdi.Text = string.Empty;
                numericMalzemeFiyat.Value = 0;

                MessageBox.Show("Malzeme Başarıyla Eklendi.");

            }
        }
    }
}
