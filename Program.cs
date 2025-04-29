using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.Fiyat = 80;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            // type - safe--tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");
              
            }
            Console.WriteLine("----------metotlar--------\n\n");
            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("elma", "yeşil elma",12,7);
            sepetManager.Ekle2("armut", "yeşil armut", 12,10);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12,75);

            Console.ReadKey();
        }
    }
}
