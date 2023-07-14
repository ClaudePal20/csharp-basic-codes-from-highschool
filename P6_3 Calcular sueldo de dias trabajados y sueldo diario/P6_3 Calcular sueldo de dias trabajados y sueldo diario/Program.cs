using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_3_Calcular_sueldo_de_dias_trabajados_y_sueldo_diario
{
    class Program
    {
        static void Main(string[] args)
        {
            float sueldodiario = 0, diasdetrabajo = 0, sueldopercibido = 0;//Declaramos los dias de trabajo, el sueldo diario y el sueldo percibido

            Console.WriteLine("Programa para obtener el sueldo percibido de una persona");
            Console.WriteLine("\nEscribe tu sueldo diario"); //Empezamos a leer las variables 
            sueldodiario = float.Parse(Console.ReadLine());
            Console.WriteLine("\nEscribe cuantos dias trabajas al mes");
            diasdetrabajo = float.Parse(Console.ReadLine());

            sueldopercibido = sueldodiario * diasdetrabajo; //Hacemos la obtencion del sueldo percibido

            Console.WriteLine("\nTu sueldo percibido es " + sueldopercibido + " $ pesos mensuales"); //Imprimimos el resultado
            Console.ReadKey();
        }
    }
}

