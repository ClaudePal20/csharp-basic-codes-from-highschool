using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int calif2 = 0, suma = 0, promedio = 0;
            string nombre = "";
            int[] calificaciones = new int[5];
            Console.WriteLine("Dame tu nombre");
            nombre = Console.ReadLine();
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Dame la calificacion " + i);
                calif2 = int.Parse(Console.ReadLine());
                calificaciones[i] = calif2;
                suma = suma + calif2;
            }
            promedio = suma / 5;
            Console.WriteLine("Tu promedio es " + promedio);
            Console.ReadKey();
        }
    }
}
