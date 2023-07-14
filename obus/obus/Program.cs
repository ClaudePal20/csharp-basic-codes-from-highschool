using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obus
{
    class Program
    {
        static void Main(string[] args)
        {
            float calif = 0, nc = 0, suma = 0, promedio = 0;
            Console.WriteLine("Programa para obtener promedio de calificaciones");
            Console.WriteLine("\n Dame el numero de calificaciones a promediar");
            nc = float.Parse(Console.ReadLine());
            Console.WriteLine("Dame la primera/sig calificacion");
            for (float nc = 0; i <= nc; nc++);
            {
                Console.WriteLine("Introduce la calificacion "+1);
                calif = Convert.ToInt32(Console.ReadLine());
                suma = suma + calif;
            }
            promedio = (calif / nc);
            Console.WriteLine("Tu promedio de calificaciones es " + promedio);
            Console.ReadKey();
        }
    }
}
