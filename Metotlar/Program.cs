using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("E-Ticaret Siteme Hoş Geldiniz!");

            Urun urun1 = new Urun();
            urun1.Adi = "Makas";
            urun1.Fiyati = 100;
            urun1.Aciklama = "Keskin Makas";
            urun1.StokAdedi = 20;

            Urun urun2 = new Urun();
            urun2.Adi = "Laptop";
            urun2.Fiyati = 11.500;
            urun2.Aciklama = "Son Teknoloji Laptop";
            urun2.StokAdedi = 2;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type safe - tip güvenli
            foreach(Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("--------Metotlar-------");

            // instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
        }
    }
}
