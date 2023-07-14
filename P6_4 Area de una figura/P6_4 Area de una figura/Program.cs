using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_4_Area_de_una_figura
{
    class Program
    {
        static void Main(string[] args)
        {
            int medidadelado = 0, apotema = 0, area = 0; //Declaramos nuestras variables para el area de un hexágono

            Console.WriteLine("Dame la medida de sus lados"); //Leemos nuestras variables
            medidadelado = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame la medida del apotema");
            apotema = int.Parse(Console.ReadLine());

            area = (((6 * medidadelado) * apotema) / 2); //Obtenemos el área

            Console.WriteLine("Esta es la medida del area: " + area + "centimetros cuadrados"); //Imprimimos resultados
            Console.ReadKey();
        }
    }
}
