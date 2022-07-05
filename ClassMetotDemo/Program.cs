using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusteriManager mm = new MusteriManager();

            mm.YeniMusteri(1, "Onur", "Yasavul", 5000);
            mm.YeniMusteri(2, "Mert", "Yasavul", 100);
            mm.YeniMusteri(3, "Selçuk", "Yasavul", 30000);

            mm.MusteriListele();


            mm.MusteriSil(1);


            mm.MusteriListele();





        }
    }
}
