using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_Saludo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variables
            int edad = 0;
            string nombre = "";
            float estatura = 0;
            //Leer datos
            Console.Write("¿Cuál es su nombre?");
            nombre = Console.ReadLine();
            Console.Write("Dame tu edad");
            edad= int.Parse(Console.ReadLine());
            Console.Write("Dame tu estatura en centimetros");
            estatura = float.Parse(Console.ReadLine());
            //Imprimir Datos
            Console.WriteLine("Hola {0} su edad es {1} y tu estatura es {2}", nombre, edad, estatura); // Aqui imprimes una cadena pero con un orden
            Console.ReadKey();
        }
    }
}
