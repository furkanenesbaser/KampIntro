using System;

namespace MetotlarAlistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sonuc = Add(1);
            Console.WriteLine(sonuc);
        }
        static int Add(int x, int number1=19, int number2=19)
        {
            var sonuc = x + number1 + number2;
            return sonuc;
        }
    }
}
