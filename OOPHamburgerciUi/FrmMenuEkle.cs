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
    public partial class FrmMenuEkle : Form
    {
        public FrmMenuEkle()
        {
            InitializeComponent();
        }

        public void btnMenuyuKaydet_Click(object sender, EventArgs e)
        {
            if (txtMenuAdi.Text == string.Empty)
            {
                MessageBox.Show("Menü adı boş bırakılamaz");
            }
            else
            {
                string menuAdi = txtMenuAdi.Text;
                int menuFiyati = (int)numericFiyat.Value;
                int menuID = (MdiParent as Form1).MenulerListesi.Count + 1;

                (MdiParent as Form1).MenulerListesi.Add(new Menu { MenuId=menuID, MenuAdi = menuAdi,MenuFiyati=menuFiyati });





                txtMenuAdi.Text = string.Empty;
                numericFiyat.Value = 0;

                MessageBox.Show("Menu Başarıyla Eklendi.");
            }
        }

        private void FrmMenuEkle_Load(object sender, EventArgs e)
        {

        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSiparisOlustur frmSiparisOlustur = new FrmSiparisOlustur();
            frmSiparisOlustur.Show();
        }
    }
}
