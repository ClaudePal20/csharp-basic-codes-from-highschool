using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_3_ProgramaMayor_DoWhile_
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0, num2 = 0;
            int opc = 0;
            Console.WriteLine("Programa para desplegar número mayor\n");
            do
            {
                Console.WriteLine("Dame el primer numero");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("\nDame el segundo numero");
                num2 = float.Parse(Console.ReadLine());
                if (num1 < num2)
                {
                    Console.WriteLine("El número {0} es el mayor", num2);
                }
                else if (num2 < num1)
                {
                    Console.WriteLine("El número {0} es el mayor", num1);
                }
                else if (num2 == num1)
                {
                    Console.WriteLine("Ambos números {0} y {1} son iguales", num1, num2);
                }
                else
                {
                    Console.WriteLine("Digitaste caracteres erroneos o muy largos");
                }
                Console.WriteLine("\n¿Deseas desplegar otros numeros? \n1. Si \n2. No");
                opc = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            while (opc == 1);
            Console.ReadKey();
        }
    }
}
