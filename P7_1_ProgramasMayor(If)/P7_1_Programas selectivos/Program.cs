using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace P7_1_Programas_selectivos
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0, num2 = 0;
            Console.WriteLine("Programa para destacar qué número es mayor");
            Console.WriteLine("\nDame el primer numero:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nDame el segundo numero:");
            num2 = float.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("\nEl numero mayor: {0}",num1);
            }
            else
            {
                Console.WriteLine("\nEl numero mayor es: {0}",num2);
            }
                Console.ReadKey();
        }
    }
}
