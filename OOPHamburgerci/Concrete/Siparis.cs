using OOPHamburgerciLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHamburgerciLibrary.Concrete
{
    public class Siparis
    {

        public int SiparisId { get; set; }
        public int MenuId { get; set; }
        public BoyutTipi Boyut { get; set; }

        public int Adet { get; set; }

        public List<string> EkstraMalzeme { get; set; }


        public int Tutar { get; set; }

        





    }
}
