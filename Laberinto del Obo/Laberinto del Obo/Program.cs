using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberinto_del_Obo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc1 = 0, opc11 = 0;
            Console.Write("\nEl Laberinto del Obo: El despertar de Free Fire ");
            Console.Write("\n Elige tu lugar de inicio: \n1. Casa de Holguin 2. Casa de Stiff 3. Habitacion de Oscarcuck \n");
            opc1 = int.Parse(Console.ReadLine());
            if (opc1 == 1)
            {
                Console.Write("\nDespiertas en un sofa con un olor a culo tremendo, tienes 20 llamadas perdidas del banco y tienes tan solo 100 pesos en el bolsillo\n¿Qué procedes a hacer?");
                Console.Write("\n 1. Jugar Free Fire 2. Ver memes 3. Decir la N-Word \n");
                opc11 = int.Parse(Console.ReadLine());

                if (opc11 == 1)
                {
                    Console.Write("\nIntentas prender el celular para jugar free fire y no enciende, oh no, game over.");
                }
                else if (opc11 == 2)
                {
                    Console.Write("Ves un meme pero de repente descubres que te funaron, oh no, game over.");
                }
                else if (opc11 == 3)
                {
                    Console.Write("Empiezas a decir la N-Word y aparece un nigga en tu ventana con un arma, ¿qué haces?");
                    Console.Write("\n1. Le digo hola 2. Le hablo a la policia 3. Le aviento un bote de KFC \n");
                }
            }
            else if (opc1 == 2)
            {
                Console.Write("\nDespiertas en tu habitación y lo primero que ves es un poster de una china desnuda, ¿qué haces?");
                Console.WriteLine("\n1. Pajearme 2. Meterme a facebook 3. Valer berga un rato nomas \n");
                opc11 = int.Parse(Console.ReadLine());
                {
                    Console.Write("\nComienzas a pajearte pero adivina que, se te cae el pene, game over.");
                }
            }
            else if (opc1 == 3)
            {
                Console.Write("\n Estas caminando por tu habitación y ves una chica por la ventana, ¿qué haces? \n 1. Le saludo 2. La miro 3. Le hablo por messenger");
                opc11 = int.Parse(Console.ReadLine());
                if (opc11 == 1)
                {
                    Console.Write("\nYa te vi dum, te han ignorado, game over.");
                }
                else if (opc11 == 2)
                {
                    Console.Write("\nDéjala en paz Esquizo, maldita sea (game over)");
                }
                else if (opc11 == 3)
                    Console.Write("\nLe dices 'Hola' por mensaje y te saluda de vuelta, ¿qué le quieres decir?");
            }
            
            Console.ReadKey();

        }
    }
}
