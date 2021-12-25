using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //döngü örneği
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // array(dizi) örneği 
            string[] kurslar = new string[] { "c#", "c++", "python", "java", "javascript" };

            for(int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            // foreach örneği
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
