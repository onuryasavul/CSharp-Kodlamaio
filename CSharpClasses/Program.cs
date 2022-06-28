using System;

namespace CSharpClasses
{

    class Program
    {

        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "Onur";
            kurs1.izlenmeOrani = 10;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Python";
            kurs2.egitmen = "Mert";
            kurs2.izlenmeOrani = 20;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Java";
            kurs3.egitmen = "Selçuk";
            kurs3.izlenmeOrani = 30;

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};
            int i = 90;
            foreach(var kurs in kurslar){
                Console.WriteLine(kurs.kursAdi + "-----------------");
                Console.WriteLine("Eğitmen: " + kurs.egitmen);
                Console.WriteLine("Eski izlenme oranı: " + kurs.izlenmeOrani);
                kurs.setIzlenmeOrani(i);
                Console.WriteLine("Yeni izlenme oranı: " + kurs.izlenmeOrani);
                i++;
            }



        }
    }

    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }

        public void setIzlenmeOrani (int izlenmeOrani)
        {
            this.izlenmeOrani = izlenmeOrani;
        }
        public void setKursAdi(string kursAdi)
        {
            this.kursAdi = kursAdi;
        }

        public void setEgitmen(string egitmen)
        {
            this.egitmen = egitmen;
        }

    }
}

