using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5.Programa_Saludo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variables
            int edad = 0;
            string nombre = "";

            //Leer datos
            Console.Write("¿Cuál es su nombre?")
            nombre = Console.ReadLine();
            Console.Write("Dame tu edad")
            edad = int.Parse(Console.ReadLine());

            //Imprimir Datos
            Console.WriteLine("Hola" + nombre); // Aqui imprimes una cadena normal
            Console.WriteLine("Hola {0} su edad es {1}", nombre, edad); // Aqui imprimes una cadena pero con un orden
            Console.WriteLine("Hola {0}.\n su edad es {1}", nombre, edad); //Aqui imprimes una cadena con orden con un salto de linea
            Console.ReadKey();
        }
    }
}
