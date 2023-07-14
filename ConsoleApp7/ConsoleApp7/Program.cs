using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Promedio__do-while_
{
   class Program
{
    static void Main(string[] args)
    {
        //Declarar Variables
        float cal = 0, promedio = 0, cont = 0, suma = 0;
        int nc = 0;
        string nombre = "";
        //Leer variables
        Console.Write("Por favor introduzca su nombre: ");
        nombre = Console.ReadLine();
        Console.Write("Mucho gusto " + nombre + ", ¿cuantas calificaciones quiere promediar? ");
        nc = int.Parse(Console.ReadLine());
        do
        {
            Console.Write("Introduzca su calificacion: ");
            cal = float.Parse(Console.ReadLine());
            suma = suma + cal;
            cont = cont + 1;
            Console.WriteLine("Su calificacion ha sido registrada");
        } while (cont < nc);

         promedio = suma / nc;
        Console.WriteLine("Su promedio es " + promedio);
        Console.Write("El programa procedera a cerrarse");
        Console.ReadKey();

    }
}
}