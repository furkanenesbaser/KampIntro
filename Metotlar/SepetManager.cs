using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // Naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("TEBRİKLER."+ "  " + urun.Adi + " " + "Sepete Eklendi!");
        }
    }
}
