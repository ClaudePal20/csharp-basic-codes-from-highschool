using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P7_5_ProgramaAreasIf
{
    class Program
    {
        static void Main(string[] args)
        {
            float ancho = 0, Altura = 0, Trian = 0, Rect = 0, Cuad = 0; //Declaramos varialbes
            int opc = 0; 
            Console.WriteLine("Programa para calcular areas"); 
            Console.WriteLine("\nElige la figura a calcular su area\n1. Triangulo \n2. Rectangulo \n3. Cuadrado"); //Despliego el menu
            opc = int.Parse(Console.ReadLine()); //Leemos la opcion a elegir o el caso
            if (opc == 1) //Caso 1
            {
                Console.WriteLine("\nEscribe la medida de la base del triangulo\n "); //Pedimos la base
                ancho = float.Parse(Console.ReadLine()); //Leemos la base
                Console.WriteLine("\nAhora, escribe la medida de la altura\n "); //Pedimos la altura
                Altura = float.Parse(Console.ReadLine()); //Leemos la altura
                Trian = ((ancho * Altura) / 2); //Obtenemos el area
                Console.WriteLine("\nEsta es el area del triangulo " + Trian); //Desplegamos el area

            }
            else if (opc == 2) //Caso 2
            {
                Console.WriteLine("\nEscribe la medida de la base del rectangulo"); //Pedimos la base
                ancho = float.Parse(Console.ReadLine()); //Leemos el ancho
                Console.WriteLine("\nAhora, escribe la medida de la altura\n "); //Pedimos la altura
                Altura = float.Parse(Console.ReadLine()); //Leemos la altura
                Rect = (ancho * Altura); //Obtenemos el area
                Console.WriteLine("\nEsta es la medida del area del rectangulo\n " + Rect); //Desplegamos el area
            }
            else if (opc == 3) //Caso 3
            {
                Console.WriteLine("\nEscribe la medida de un lado del cuadrado"); //Pedimos la medida de un lado
                ancho = float.Parse(Console.ReadLine()); //Leemos la medida del lado
                Cuad = (ancho * ancho); //Obtenemos el area
                Console.WriteLine("\nEsta es la medida del area del cuadrado " +Cuad); //Desplegamos el area
            }
            Console.ReadKey(); //Termina programa
        }
    }
}
