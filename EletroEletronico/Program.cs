using System;

namespace EletroEletronico
{
    class Program
    {
        static void Main(string[] args)
        {

            Tv tv = new Tv("Sony", "Vaio 2000", 220, false);
            BluRay bluRay = new BluRay("LG", "BR3000", 110, false);

            PS4 pS4 = new PS4("Sony", "PS4 Pro", 110, false, true);

            Console.WriteLine(tv);
            Console.WriteLine(bluRay);
            Console.WriteLine(pS4);

            Console.ReadKey();



        }
    }
}
