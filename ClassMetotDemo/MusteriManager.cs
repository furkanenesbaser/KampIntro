using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler " + musteri.Ad + " isimli kullanıcı eklendi" );
        } 
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Soyad + " Listelendi");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " Silindi");
        }
    }
}
