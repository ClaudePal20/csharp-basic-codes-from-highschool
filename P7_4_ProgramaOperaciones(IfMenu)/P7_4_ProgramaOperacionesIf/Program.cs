using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_4_ProgramaOperacionesIf
{
    class Program
    {
        static void Main(string[] args)
        {
            float opc = 0, num1 = 0, num2 = 0, suma = 0, resta = 0, div = 0, multi = 0;
            Console.WriteLine("Programa para realizar operaciones basicas");
            Console.WriteLine("\nElige la operacion a realizar \n1. Suma \n2. Resta \n3. Division \n4. Multiplicacion\n ");
            opc = float.Parse(Console.ReadLine());
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
            Console.ReadKey();
        }
    }
}
