using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_2_Calcular_el_promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int calif1 = 0, calif2 = 0, calif3 = 0, suma = 0, promedio = 0; //Declaracion de variables

            Console.WriteLine("Programa para obtener el promedio de 3 calificaciones");
            Console.WriteLine("\nDame tu primera calificación"); //Leemos las calificaciones
            calif1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDame tu segunda calificacion");
            calif2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDame tu tercera calificacion");
            calif3 = int.Parse(Console.ReadLine());

            suma = calif1 + calif2 + calif3; //Obtenemos la suma de calificaciones
            promedio = suma / 3;    //Sacamos el promedio dividiendo la suma entre el numero de promedios

            Console.WriteLine("\nTu promedio es " + promedio);    //Imprimimos el resultado
            Console.ReadKey();
        }
    }
}
