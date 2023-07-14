using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_1_Suma_de_dos_números
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, suma = 0; //Hacemos nuestra declaración de variables

            Console.WriteLine("Programa para sumar dos números ");
            Console.WriteLine("\nDame el primer número: "); //Empezamos a leer las variables
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDame el segundo número: "); 
            n2 = int.Parse(Console.ReadLine());

            suma = n1+n2; //Hacemos la suma

            Console.Write("\nEl resultado de la suma es: " +suma); //Imprimimos el resultado de la suma
            Console.ReadKey();
        }
    }
}


