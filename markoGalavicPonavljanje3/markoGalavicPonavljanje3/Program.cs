using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavicPonavljanje3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] niz = new string[3];

            Console.WriteLine("Unesi prvi string");
            niz[0] = Console.ReadLine();
            Console.WriteLine("Unesi drugi string");
            niz[1] = Console.ReadLine();
            Console.WriteLine("Unesi treci string ");
            niz[2] = Console.ReadLine();

            Array.Sort(niz);
            Array.Reverse(niz);
            Console.WriteLine("Sortirani stringovi");
            for(int i=0; i<2; i++)
            {
                Console.WriteLine(niz[1]);
            }
            Console.ReadKey(); 
        }
    }
}
