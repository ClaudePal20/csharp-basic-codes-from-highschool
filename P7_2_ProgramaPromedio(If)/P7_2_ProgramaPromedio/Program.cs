using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_2_ProgramaPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            float calif1 = 0, calif2 = 0, calif3 = 0, promedio = 0;
            Console.WriteLine("Programa para sacar promedios: ");
            Console.WriteLine("\nDame la primera calificacion: ");
            calif1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nDame la segunda calificacion: ");
            calif2 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nDame la tercera calificacion: ");
            calif3 = float.Parse(Console.ReadLine());

            promedio = ((calif1 + calif2 + calif3)/3);

            if (promedio < 7)
            {
                Console.WriteLine("\nEl promedio es de "+promedio);
                Console.WriteLine("No es aprobatorio");
            }
            else
            {
                Console.WriteLine("\nEl promedio es de "+promedio);
                Console.WriteLine("Es aprobatorio");
            }
            Console.ReadKey();
        }
    }
}
