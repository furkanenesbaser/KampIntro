using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // burada JSden farklı olarak değişkenlerin hangi tipte olduğunu başında belirtmemiz lazım.
            // kategoriEtiketi değer tutucu yani değişken.

            // string metinsel ifade demektir. Metinsel ifade oluştururken string kullanılır.
            string kategoriEtiketi = "kategoriler";
            Console.WriteLine(kategoriEtiketi);

            // değer kullanırken int, double ve bool kullanılır. int de normal değerleri double de ondalıklı
            //ifadeleri boolda ise true false değerleri kullanabiliriz.

            //int yani normal rakam
            int ogrenciSayisi = 32000;
            Console.WriteLine(ogrenciSayisi);

            //double yani ondalıklı
            double faizOrani = 1.45;
            Console.WriteLine(faizOrani);

            //bool yani true false
            bool sistemeGirisYapmisMi = false;
            // bool sisteminin şart bloğunu yani if else sini yazalım giriş yapıldıysa sisteme girsin. 
            // Giriş yapılmadıysa Giriş yapın uyarısını versin.
            if(sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Sisteme Giriş Yapıldı. Hoşgeldiniz!");
            }
            else
            {
                Console.WriteLine("Lütfen Önce Sisteme Giriş Yapınız!");
            }

            // if else ile bir örnek daha yapalım.
            double dolarDun = 14.03;
            double dolarBugun = 15.03;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("dolar azalmış");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("dolar artmış");
            }
            else
            {
                Console.WriteLine("dolarda herhangi bir artış veya azalış söz konusu değil");
            }
        }
    }
}
