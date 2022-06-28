using System;


namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.isim = "Elma";
            urun1.fiyat = 15;
            urun1.aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.isim = "Karpuz";
            urun2.fiyat = 80;
            urun2.aciklama = "Adana Karpuzu";


            Urun[] urunler = new Urun[] {urun1, urun2};

            foreach(Urun urun in urunler)
            {
                Console.WriteLine(urun.isim);
                Console.WriteLine(urun.fiyat);
                Console.WriteLine(urun.aciklama);
                Console.WriteLine("\n");


            }

            Console.WriteLine("Method kullanımı:");
            SepetManager sepetManager = new SepetManager();
            int adet1 = 5;
            int adet2 = 8;

            sepetManager.Ekle(urun1, adet1);
            sepetManager.Ekle(urun2, adet2);

        }
    }
}
