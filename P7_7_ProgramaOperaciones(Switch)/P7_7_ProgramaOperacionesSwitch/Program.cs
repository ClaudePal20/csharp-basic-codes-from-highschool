using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_7_ProgramaOperacionesSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            float resta = 0, suma = 0, div = 0, multi = 0, num1 = 0, num2 = 0;
            Console.WriteLine("Calculadora basica con decimales");
            Console.WriteLine("\n¿Qué operación quieres realizar? \n1. Resta \n2. Suma \n3.Multiplicación \n4.División");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    {
                        Console.WriteLine("\nDame el primer numero\n ");
                        num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nDame el segundo numero\n ");
                        num2 = float.Parse(Console.ReadLine());
                        resta = num1 - num2;
                        Console.WriteLine("\nEl resultado de la resta es " + resta);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\nDame el primer numero\n ");
                        num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nDame el segundo numero\n ");
                        num2 = float.Parse(Console.ReadLine());
                        suma = num1 + num2;
                        Console.WriteLine("\nEl resultado de la suma es " + suma);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\nDame el primer numero\n ");
                        num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nDame el segundo numero\n ");
                        num2 = float.Parse(Console.ReadLine());
                        multi = num1 * num2;
                        Console.WriteLine("\nEl resultado de la multiplicacion es\n " + multi);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("\nDame el primer numero\n ");
                        num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nDame el segundo numero\n ");
                        num2 = float.Parse(Console.ReadLine());
                        div = num1 / num2;
                        Console.WriteLine("\nEl resultado de la division es\n " + div);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("\nOpcion no valida");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
