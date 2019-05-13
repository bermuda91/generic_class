using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_class
{
    class Hasta<t1,IlacTip> where IlacTip: Ilac
    {
        public string adi { get; set; }
        public string soyadi { get; set; }
        public int tckn { get; set; }
        public t1 hastaTuru { get; set; }
        public List<IlacTip> ilaclar { get; set; }

        public Hasta()
        {
            ilaclar = new List<IlacTip>();
        }
    }

    class Ilac
    {
        public string adi { get; set; }
        public string Marka { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }

    }

    class AgriKesici : Ilac
    {
        public int kutudaki_Miktari { get; set; }
        public string kullanim_Yontemi { get; set; }

        //public override string ToString()
        //{
        //    return kullanim_Yontemi.ToString();
        //}
    }
    class Sogukhastaliklari
    {
        public string hastalikAdi { get; set; }
        public int hastalikSuresi { get; set; }
        public string hastalikTavsiyeler { get; set; }
    }

}
