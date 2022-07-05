using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        List <Musteri> musteriListesi = new List<Musteri>();

        public void YeniMusteri(int id, string isim, string soyIsim, double bakiye)
        {

            Musteri yeniMusteri = new Musteri();
            yeniMusteri.id = id;
            yeniMusteri.isim = isim;
            yeniMusteri.soyIsim = soyIsim;
            yeniMusteri.bakiye = bakiye;
            musteriListesi.Add(yeniMusteri);

            Console.WriteLine("Yeni müşteri listeye eklendi...");
        }

        public void MusteriSil(int id)
        {
            foreach (Musteri musteri in musteriListesi)
            {
                if (musteri.id == id)
                {
                    musteriListesi.Remove(musteri);
                    break;
                }
                             

            }
        }

        public void MusteriListele()
        {
            foreach (Musteri musteri in musteriListesi)
            {
                Console.WriteLine(musteri.id + " " + musteri.isim + " " + musteri.soyIsim + " " + musteri.bakiye);
            }
                
        }
    }
}
