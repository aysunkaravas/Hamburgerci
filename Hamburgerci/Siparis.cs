using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Hamburgerci
{
  public class Siparis
    {

        public Siparis()
        {
            Malzemeler = new List<Malzeme>();
        }

        public Menu Menu { get; set; }

        public List<Malzeme> Malzemeler { get; set; }
        public Boy Boy { get; set; }
        public int Adet { get; set; }

        private double toplamFiyat;
        public double ToplamFiyat
        {
            get
            {
                toplamFiyat = Menu.Fiyat;
                if (this.Boy == Boy.Orta)
                {
                    toplamFiyat *= 1.5;
                }
                else if (this.Boy == Boy.Büyük)
                {
                    toplamFiyat *= 1.7;
                }

                foreach (Malzeme malzeme in this.Malzemeler)
                {
                    toplamFiyat += malzeme.Fiyat;
                }

                toplamFiyat *= this.Adet;
                return toplamFiyat;
            }
        }

        public double EkstraMalzemeFiyatlari()
        {
            double toplam = 0;
            foreach (Malzeme malzeme in this.Malzemeler)
            {
                toplamFiyat += malzeme.Fiyat;


            }

            return toplam;
        }


        public override string ToString()
        {
            string ekstraMalzemelerIsimleri = string.Empty;
            foreach (Malzeme malzeme in this.Malzemeler)
            {
                ekstraMalzemelerIsimleri += malzeme.Ad + " ";
            }

            string bilgi = $"{this.Adet} {this.Menu.Ad} , {ekstraMalzemelerIsimleri} , {this.Boy} ==> Toplam : {this.ToplamFiyat} ";

            return bilgi;
        }


    }
}
