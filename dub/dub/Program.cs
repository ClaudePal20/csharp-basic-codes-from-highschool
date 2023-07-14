using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dub
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variables
            float num1 = 0, num2 = 0, suma = 0;
            Console.WriteLine("A continuacion realizaremos la suma de dos numeros");
            Console.Write("Dame el primer numero: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Su primer numero ha sido registrado con exito");
            Console.Write("Dame el segundo numero: ");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Su segundo numero ha sido registrado con exito");
            suma = num1 + num2; //Suma de valores
            Console.Write("Su resultado es " + suma); //Impresion de resultado
            Console.ReadKey();

        }
    }
}
