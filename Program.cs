using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarieren und Initialisieren der Variablen meinName
            string meinName = "Irina";

            string nachricht = "Mein Name ist " + meinName;
            int laengeDesStrings = nachricht.Length;
            // die ToUpper Methode gibt den String in Großschrift zurück.
            string allesGrossGeschrieben = nachricht.ToUpper();
            string allesKleinGeschrieben = nachricht.ToLower();
            Console.WriteLine(allesGrossGeschrieben);
            Console.WriteLine(allesKleinGeschrieben);
            Console.WriteLine(nachricht + " ist {0} Zeichen {1} lang", laengeDesStrings);
            Console.ReadKey();
        }
    }
}