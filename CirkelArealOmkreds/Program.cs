using System;

namespace CirkelArealOmkreds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Du vil gerne regne arealet af en cirkel ud. Formlen er A = Pi * r^2. Så vi skal bruge radius, hvad er radius?");

            string radius = Console.ReadLine();
            Console.WriteLine("Du har angivet radius til at være {0}", radius);

            double radius2 = float.Parse(radius);

            //Beregning
            double pi = Math.PI;
            double areal;
            areal = radius2 * radius2 * pi;

            Console.WriteLine("Arealet af en cirkel med radius på {0} er {1:N2}", radius, areal);

            // Areal slut
            //Omkreds start

            Console.WriteLine("Nu vil vi gerne regne omkredsen ud på cirkel. Formlen hedder O = d * Pi. Angiv diameteren af din cirkel");

            string dia = Console.ReadLine();
            Console.WriteLine("Du har angivet diameteren til at være {0}", dia);

            double diameter2 = float.Parse(dia);

            //Beregning

            double omkreds;

            omkreds = diameter2 * pi;

            Console.WriteLine("Omkredsen af cirklen med en diameter på {0}, har omkredsen {1:N2}", dia, omkreds);






        }
    }
}
