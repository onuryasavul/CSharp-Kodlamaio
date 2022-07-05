using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Onur", "Mert", "Selçuk" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //isimler[3] = Console.ReadLine();
            //Console.WriteLine(isimler[3]); Hata verir!!!


            List<string> isimler2 = new List<string> {"Onur", "Mert", "Selçuk" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Mehmet");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
