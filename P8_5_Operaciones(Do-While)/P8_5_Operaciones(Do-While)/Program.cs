using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_5_Operaciones_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0, num2 = 0, suma = 0, resta = 0, div = 0, multi = 0;
            int opc = 0, opc2 = 0;
            Console.WriteLine("Programa para realizar operaciones basicas\n");
            do
            {
                Console.WriteLine("Elige la operacion a realizar \n1. Suma \n2. Resta \n3. Division \n4. Multiplicacion\n ");
                opc = int.Parse(Console.ReadLine());
                Console.WriteLine("\nDame el primer numero\n ");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("\nDame el segundo numero\n ");
                num2 = float.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    suma = num1 + num2;
                    Console.WriteLine("\nTu resultado de la suma es de " + suma);
                }
                else if (opc == 2)
                {
                    resta = num1 - num2;
                    Console.WriteLine("\nTu resultado de la resta es de " + resta);
                }
                else if (opc == 3)
                {
                    div = num1 / num2;
                    Console.WriteLine("\nTu resultado de la division es de " + div);
                }
                else if (opc == 4)
                {
                    multi = num1 * num2;
                    Console.WriteLine("\nTu resultado de la multiplicación es de " + multi);
                }
                Console.WriteLine("\n¿Deseas realizar otra operación? \n1. Si \n2. No");
                opc2 = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            while (opc2 == 1);
        }
        Console.ReadKey();
    } 
}
