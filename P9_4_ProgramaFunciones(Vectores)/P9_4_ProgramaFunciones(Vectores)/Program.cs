using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_4_ProgramaFunciones_Vectores_
{
    class Program
    {
        static void Main(string[] args)
        {
            int longvect = 0, opc = 0;      //Declaracion
            float elemento = 0;
            do
            {
                Console.WriteLine("Programa para ver la longitud de un vector");
                Console.Write("¿Cuál será la longitud de tu vector?\n");
                longvect = int.Parse(Console.ReadLine());
                float[] vectores = new float[longvect];
                for (int i = 0; i < vectores.Length; i++)
                {
                    Console.WriteLine("Dame el elemento del vector {0}", i + 1);
                    elemento = float.Parse(Console.ReadLine());
                    vectores[i] = elemento;
                }
                
                Console.WriteLine("\nLa longitud del vector es: {0}\n", vectores.Length);
                Console.Write("\nOrden original\n");
                for (int i = 0; i < vectores.Length; i++)
                {
                    elemento = vectores[i];
                    Console.WriteLine("El vector {0} es {1}", i + 1, elemento);
                }
                Console.Write("\nOrden reverso\n");
                for (int i = 0; i < vectores.Length; i++)
                {
                    Array.Reverse(vectores);
                    elemento = vectores[i];
                    Console.WriteLine("El vector {0} es {1}", i + 1, elemento);
                }
                Console.Write("\nOrden de menor a mayor\n");
                for (int i = 0; i < vectores.Length; i++)
                {
                    Array.Sort(vectores);
                    elemento = vectores[i];
                    Console.WriteLine("El vector {0} es {1}", i + 1, elemento);
                }
                Console.Write("\n¿Deseas volver a utilizar la herramienta?\n1. Si\n2.No\n");
                opc = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (opc == 1);
            Console.Write("Presiona ENTER para salir del programa");
            Console.ReadKey();
        }
    }
}
