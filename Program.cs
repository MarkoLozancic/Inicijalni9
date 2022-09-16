using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalni9
{
    internal class Program
    {
        //Napišite program koji će definirati niz tipa int, te će ga predefinirati,
          //  odnosno sortirati tako da članovi budu poredani od manjeg prema većem.Program mora raditi ispravno za proizvoljni broj članova niza. Članove niza na kraju ispišite.
        static void Main(string[] args)
        {
            int[] p = new int[] { 3, 4, 5, 6, 1, 2, 7, 8, 9 };
            for (int i = 0; i < p.Length; i++)
            { Console.WriteLine(p[i]); }
            Console.WriteLine("Sortirani niz:\n");
           Array.Sort(p);
            for(int i=0; i<p.Length; i++)
            { Console.WriteLine(p[i]);
               
            }
            Console.ReadKey();
      }
    }
}
