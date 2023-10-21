using OOPHamburgerciLibrary.Concrete;



namespace OOPHamburgerciUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public List<Ekstra> EkstraMalzeme = new List<Ekstra>();
        public List<Menu> MenulerListesi = new List<Menu>();


        private void sipariþOluþturToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmSiparisOlustur = new FrmSiparisOlustur();
            ShowForm(ref frmSiparisOlustur);


        }

        private void sipariþBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmsiparisBilgileri = new SiparisBilgileri();

            ShowForm(ref frmsiparisBilgileri);


        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmEkstraMalzemeEkle = new FrmEkstraMalzemeEkle();
            ShowForm(ref frmEkstraMalzemeEkle);
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmMenuEkle = new FrmMenuEkle();
            ShowForm(ref frmMenuEkle);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            IsMdiContainer = true;
            MenulerListesi.Add(new Menu { MenuId = 1, MenuAdi = "Big King Menü", MenuFiyati = 15 });
            MenulerListesi.Add(new Menu { MenuId = 2, MenuAdi = "Double King Chicken Menü", MenuFiyati = 20 });
            MenulerListesi.Add(new Menu { MenuId = 3, MenuAdi = "Whooper Menü", MenuFiyati = 25 });
            MenulerListesi.Add(new Menu { MenuId = 4, MenuAdi = "Whooper Jr. Menü", MenuFiyati = 30 });
            MenulerListesi.Add(new Menu { MenuId = 5, MenuAdi = "Chicken Royal Menü", MenuFiyati = 35 });

            EkstraMalzeme.Add(new Ekstra { EkstaMalzemeID = 1, EkstaMalzemeAdi = "Ketçap", Fiyati = 1 });
            EkstraMalzeme.Add(new Ekstra { EkstaMalzemeID = 2, EkstaMalzemeAdi = "Mayonez", Fiyati = 1 });
            EkstraMalzeme.Add(new Ekstra { EkstaMalzemeID = 3, EkstaMalzemeAdi = "Hardal", Fiyati = 2 });
            EkstraMalzeme.Add(new Ekstra { EkstaMalzemeID = 4, EkstaMalzemeAdi = "BBQ", Fiyati = 2 });
            EkstraMalzeme.Add(new Ekstra { EkstaMalzemeID = 5, EkstaMalzemeAdi = "Ranch", Fiyati = 3 });
            EkstraMalzeme.Add(new Ekstra { EkstaMalzemeID = 6, EkstaMalzemeAdi = "Buffalo", Fiyati = 3 });

        }

        void ShowForm(ref Form form)
        // Menülerin 1 kere açýlmasýný ve tekrar seçilen menünün öne gelmesini saðlýyoruz.
        {
            Form f = form;
            Form tempForm = null;

            foreach (Form child in this.MdiChildren)
            {
                if (child.Text == f.Text)
                {
                    tempForm = child;
                    break;
                }
            }

            if (tempForm != null)
            {
                tempForm.BringToFront();
            }
            else
            {
                f.MdiParent = this;
                f.Show();
            }





        }
    }
}