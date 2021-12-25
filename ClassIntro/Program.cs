using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // class örneği yapalım
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Enes Baser";
            kurs1.IzlenmeOrani = 90;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Berberliğe Başlangıç Paketi";
            kurs2.Egitmen = "Ilyas Durak";
            kurs2.IzlenmeOrani = 50;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Ingilizce Başlangıç Paketi";
            kurs3.Egitmen = "Irfan Dundar";
            kurs3.IzlenmeOrani = 70;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach(var kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen + " " + kurs.KursAdi);
            }
            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + " " + kurs2.KursAdi);
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
