using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYTHAGORAS
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Instast det første tal");
            double tal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Instast det andet tal");
            double tal2 = int.Parse(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(tal1, 2) + Math.Pow(tal2, 2));


            Console.WriteLine(c);
            if (tal1 > tal2)
            {
                Console.WriteLine(tal1 + " Er størst");
            }
            else
            {
                Console.WriteLine(tal2 + " Er Størst");
            }



            Console.ReadKey();
        }
    }
}
