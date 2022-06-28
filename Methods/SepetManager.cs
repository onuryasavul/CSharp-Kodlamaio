using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    internal class SepetManager
    {
        public void Ekle(Urun urun, int adet)
        {
            Console.WriteLine(adet + " adet " + 
                urun.isim + " sepete eklendi!");

        }


    }
}
