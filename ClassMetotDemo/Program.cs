using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Müşteri Listesine Hoş Geldiniz!");
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Enes";
            musteri1.Soyad = "Baser";
            musteri1.TcKn = 12121212;
            musteri1.Yas = 21;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Emre";
            musteri2.Soyad = "Doğru";
            musteri2.TcKn = 121212;
            musteri2.Yas = 18;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach(Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.TcKn);
                Console.WriteLine(musteri.Yas);
                Console.WriteLine("------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri1);
            musteriManager.Sil(musteri1);
        }
    }
}
