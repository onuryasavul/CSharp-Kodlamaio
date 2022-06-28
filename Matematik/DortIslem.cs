using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    internal class DortIslem
    {
        public void Toplama(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam işlemi sonucu: " + sonuc);
        }

        public void Cikarma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Çıkarma işlemi sonucu: " + sonuc);
        }
        public void Carpma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("Çarpma işlemi sonucu: " + sonuc);
        }
        public void Bolme(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            Console.WriteLine("Bölme işlemi sonucu: " + sonuc);
        }
    }
}
