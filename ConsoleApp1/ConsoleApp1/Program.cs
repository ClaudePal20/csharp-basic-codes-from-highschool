using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string nombre;
			int NC = 5, cal = 0;
			Console.WriteLine("Dame tu nombre");
			nombre = Console.ReadLine();
			int[] calificaciones = new int[NC];
			for (int i = 1; i <= 5; i++)
			{
				Console.Write("Dame calificacion " + i + " : ");
				cal = int.Parse(Console.ReadLine());
				calificaciones[i] = cal;
			}
			for (int i = 1; i <= 5; i++)
			{
				cal = calificaciones[i];
				Console.WriteLine("La calificacion " + i + " es " + cal);
			}
			Console.ReadKey();

		}
	}
}
