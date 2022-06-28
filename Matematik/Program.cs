using System;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Toplama(10, 10);
            dortIslem.Cikarma(10, 10);
            dortIslem.Carpma(10, 10);
            dortIslem.Bolme(10, 10);

        }
    }
}
