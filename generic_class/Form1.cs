using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace generic_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> metinListesi = new List<string>();
            List<int> sayiListesi = new List<int>();

            metinListesi.Add("uyelik");
            metinListesi.Add("satislar");
            metinListesi.Add("depo");

            foreach (var item in metinListesi)
            {
                MessageBox.Show(item);
            }

            // asagidaki listedeki elemanlari yazdırmadim
            ArrayList liste = new ArrayList();
            liste.Add("personeller");
            liste.Add(4750);
            liste.Add(true);
            liste.Add(' ');

            Sogukhastaliklari s = new Sogukhastaliklari();
            s.hastalikAdi = "grip";
            s.hastalikSuresi = 5;
            s.hastalikTavsiyeler = "c vitamini ve dinlenme";

            AgriKesici a = new AgriKesici();
            a.adi = "Nurofen";
            a.Marka = "DEVA";
            a.kullanim_Yontemi = "su ile";
            a.kutudaki_Miktari = 25;

            /*Aşağıdaki kısım önemli*/
            Hasta<Sogukhastaliklari, AgriKesici> h = new Hasta<Sogukhastaliklari, AgriKesici>();
            h.adi = "berkay";
            h.soyadi = "akkaya";
            h.tckn = 123456;
            h.hastaTuru = s;  // burada, yukarda tanımladığımız "s" i verdiği için aşağıdaki mesajda gösterebiliyoruz.
            MessageBox.Show(h.hastaTuru.hastalikTavsiyeler);

            h.ilaclar.Add(a);   // Bunun çalışabilmesi için, hasta sınıfında ctor yazmak lazım. Çünkü ilaçların 1 kere new lenmesi lazım.      
            foreach (var item in h.ilaclar)
            {
                MessageBox.Show(item.kullanim_Yontemi);
            }

            

        }
    }
}
