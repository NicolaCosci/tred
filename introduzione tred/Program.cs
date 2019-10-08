using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduzione_tred
{
    class Program
    {
        static void Main(string[] args)
        {
            Visualizzapari();
            Console.WriteLine();
            Visualizzadispari();

            Console.ReadLine();
        }

        public static void Visualizzapari()
        {
            for (int i = 0; i < 200; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i+ " ");
                }
            }
            
        }
        public static void Visualizzadispari()
        {
            for (int i = 0; i < 200; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i+ " ");
                }
            }
            
        }
    }
}
