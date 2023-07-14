using System;

namespace atrabajar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Filas = new int[5];
            int[] Columnas = new int[4];
            int[,] Matriz = new int[5, 4];

                for (int i = 0;i<=3; i ++)
                for (int j = 0; j<=3; j++)
                {
                    Console.Write("Valor en [{0}][{1}]: ", i, j);
                    Matriz[i, j] = int.Parse(Console.ReadLine());
                }
            for (int i = 0; i <= 3; i++)
                for (int j = 0; j <= 3; j++)
                {
                    Filas[i] = Matriz[i, j] + Matriz[i, j] + Matriz[i, j] + Matriz[i, j];
                    Columnas[j] = Matriz[i, j];
                }
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Suma de la fila {0} es {1}", i, Filas[i]);
                Console.WriteLine("El promedio de la columna {0} es {1}", i, Columnas[i]);
            }
            Console.ReadKey();
        }
    }
}
