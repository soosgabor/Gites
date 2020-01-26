using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gites
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] pálya;
            PályaInit(out pálya); //Feltölti aláhúzás jelekkel a pályát
            Aknázás(pálya);
            Kirajzolás(pálya);
            Console.ReadKey();
        }

        private static void Kirajzolás(char[,] pálya)
        {
            throw new NotImplementedException();
        }

        private static void Aknázás(char[,] pálya)
        {
            throw new NotImplementedException();
        }

        private static void PályaInit(out char[,] pálya)
        {
            Console.Write("Kérem adja meg, hogy mekkora pályán akar játszani: (5-20)");
            int méret = int.Parse(Console.ReadLine());
            pálya = new char[méret, méret];
            for (int i = 0; i < pálya.GetLength(0); i++)
            {
                for (int j = 0; j < pálya.GetLength(1); j++)
                {
                    pálya[i, j] = '_';
                }
            }
        }
    }
}
