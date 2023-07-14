using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_1_Programas_Iteractivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num < 100) 
            {
                Console.WriteLine("Dame un numero menor a 100");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("Tu número es "+num);
            }
            Console.WriteLine("Su número es mayor a 100");
            Console.ReadKey();
        }
    }
}
