using OOPHamburgerciLibrary.Concrete;
using OOPHamburgerciLibrary.Enum;
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
    public partial class FrmSiparisOlustur : Form
    {
        public FrmSiparisOlustur()
        {
            InitializeComponent();
        }
        void FiyatGuncelle()
        {
            Siparis siparis = new Siparis();
            siparis.Adet = (int)numericUpDownAdet.Value;
            int secilenMalzemeSayisi = checkListBoxMalzeme.CheckedItems.Count;
            int secilenMalzemeFiyatlariToplami=0, menuFiyati = 0;
            
            siparis.Tutar = Convert.ToInt32(label5.Text);
            
            
            foreach (var item in checkListBoxMalzeme.CheckedItems)
            {
                var result = from s in (MdiParent as Form1).EkstraMalzeme
                             where s.EkstaMalzemeAdi == item
                             select s;
                foreach (var i in result)
                {
                    
                    secilenMalzemeFiyatlariToplami += i.Fiyati;
                }


            }

            var sonuc = from s in (MdiParent as Form1).MenulerListesi
                        where s.MenuAdi == comboBoxMenuler.SelectedItem.ToString()
                         select s;
            foreach (var i in sonuc)
            {

                menuFiyati += (int)i.MenuFiyati;
            }


            //List<Ekstra> seciliMalzemelerListesi = new List<Ekstra>();

            //for (int i = 0; i < checkListBoxMalzeme.CheckedItems.Count; i++)
            //{
            //    seciliMalzemelerListesi.Add(new Ekstra { EkstaMalzemeAdi = (string)checkListBoxMalzeme.CheckedItems[i] });
            //}



            int hangisi = comboBoxMenuler.SelectedIndex;
            
            if (siparis.Tutar == 0)
            {
                if (radioButtonBüyük.Checked)
                {
                    siparis.Tutar = Convert.ToInt32(menuFiyati * (1.2) * siparis.Adet) + (secilenMalzemeFiyatlariToplami);
                    label5.Text = siparis.Tutar.ToString();
                    
                }
                else if (radioButtonOrta.Checked)
                {

                    siparis.Tutar = Convert.ToInt32(menuFiyati * (1.1) * siparis.Adet) + (secilenMalzemeFiyatlariToplami);
                    label5.Text = siparis.Tutar.ToString();

                }
                else
                {
                    siparis.Tutar = Convert.ToInt32(menuFiyati * siparis.Adet) + (secilenMalzemeFiyatlariToplami);
                    label5.Text = siparis.Tutar.ToString();

                }

            }
            else
            {
                if (radioButtonBüyük.Checked)
                {
                    siparis.Tutar += Convert.ToInt32(menuFiyati * (1.2) * siparis.Adet) + (secilenMalzemeFiyatlariToplami);
                    label5.Text = siparis.Tutar.ToString();

                }
                else if (radioButtonOrta.Checked)
                {

                    siparis.Tutar += Convert.ToInt32(menuFiyati * (1.1) * siparis.Adet) + (secilenMalzemeFiyatlariToplami);
                    label5.Text = siparis.Tutar.ToString();

                }
                else
                {
                    siparis.Tutar += Convert.ToInt32(menuFiyati * siparis.Adet) + (secilenMalzemeFiyatlariToplami);
                    label5.Text = siparis.Tutar.ToString();

                }
            }

            // Toplam tutarı label a basmamıza yarıyor.

        }
        private void comboBoxMenuler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmSiparisOlustur_Load(object sender, EventArgs e)
        {
            //Sipariş Oluştur sayfası açılırken aşağıdaki menüler listeye eklenecek ardından combobox a ekleyeceğiz. Eğer sonradan menü oluşturulursa bu listeye dahil olacak.
            checkListBoxMalzeme.Items.Clear();
            

            for (int i = 1; i < (MdiParent as Form1).EkstraMalzeme.Count+1; i++)
            {
                var result = from s in (MdiParent as Form1).EkstraMalzeme
                             where s.EkstaMalzemeID == i 
                             select s;
                foreach (var item in result)
                {
                    checkListBoxMalzeme.Items.Add(item.EkstaMalzemeAdi);
                }
            }


            
            MenuDoldur();
            

            //FrmMenuEkle frmMenuEkle = new FrmMenuEkle();
            //frmMenuEkle.btnMenuyuKaydet_Click(sender, e);
            //List<string> asdf = menu.Menuler;


        }
        
        

        private void MenuDoldur()
        {
            comboBoxMenuler.Items.Clear();
            
            
            for (int i = 1; i < (MdiParent as Form1).MenulerListesi.Count + 1; i++)
            {
                var result = from s in (MdiParent as Form1).MenulerListesi
                             where s.MenuId == i
                             select s;
                foreach (var item in result)
                {
                    comboBoxMenuler.Items.Add(item.MenuAdi);
                }
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            FiyatGuncelle();
            SiparisEkle();
        }

        private void SiparisEkle()
        {
            string girilenBoyut;
            string secilenMenuAdi = (string)comboBoxMenuler.SelectedItem;
            string girilenAdet = (numericUpDownAdet.Value.ToString() + " Adet");
            if (radioButtonBüyük.Checked)
            {
                girilenBoyut = radioButtonBüyük.Text;
            }
            else if (radioButtonOrta.Checked)
                girilenBoyut = radioButtonOrta.Text;
            else
                girilenBoyut = radioButtonKüçük.Text;




            listBoxSiparisBilgileri.Items.Add(secilenMenuAdi + "x" + girilenAdet + "," + girilenBoyut + " Boy" + ",");


            for (int i = 0; i < checkListBoxMalzeme.CheckedItems.Count; i++)
            {
                listBoxSiparisBilgileri.Items.Add(checkListBoxMalzeme.CheckedItems[i]);
            }

        }

        private void buttonSiparisiTamamla_Click(object sender, EventArgs e)
        {
            SiparisiGonder();
            listBoxSiparisBilgileri.Items.Clear();
        }

        private void SiparisiGonder()
        {

        }
    }
}


