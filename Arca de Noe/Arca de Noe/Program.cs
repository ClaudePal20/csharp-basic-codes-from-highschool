using System;

namespace Arca_de_Noe
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0, numanim = 0, opc2 = 0, opc3 = 0, opc4 = 0;
            string sexo = "", nombreespecie = "";
            double peso = 0, pesototal = 0;
            string[] especie = new string[20];
            string[] sexos = new string[20];
            double[] pesosregistrados = new double[20];
            do
            {
                do
                {
                    numanim++;
                    Console.WriteLine("Arca de Noé, elige a los animales que quieres introducir en el arca.\nRecuerda que el arca solo puede soportar un peso máximo de 400kg");
                    //Animales
                    Console.WriteLine("\nElige una clasificacion de animales a introducir \n1. Invertebrados\n2. Mamiferos\n3. Aves\n4. Peces\n5. Reptiles");
                    Console.WriteLine("\nLlevas un peso total de: {0}kg", pesototal);
                    opc = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (opc == 1)
                    {
                        Console.WriteLine("Elija una especie de invertebrados\n1. Arañas (0.2 kg)\n2. Mariposas (0.02 kg)\n3. Caracol (0.02kg)");
                        Console.WriteLine("Llevas un peso total de: {0}kg", pesototal);
                        opc3 = int.Parse(Console.ReadLine());
                        if (opc3 == 1)
                        {
                            peso = 0.2;
                            nombreespecie = "Arañas";
                        }
                        else if (opc3 == 2)
                        {
                            peso = 0.02;
                            nombreespecie = "Mariposas";
                        }
                        else if (opc3 == 3)
                        {
                            peso = 0.02;
                            nombreespecie = "Caracol";
                        }
                        else
                        {
                            peso = 0;
                        }
                    } //Caso 1. Invertebrados
                    else if (opc == 2)
                    {
                        Console.WriteLine("Elija una especie de mamiferos\n1. Caninos\n2. Cerdos\n3. León");
                        Console.WriteLine("Llevas un peso total de: {0}kg", pesototal);
                        opc3 = int.Parse(Console.ReadLine());
                        if (opc3 == 1)
                        {
                            peso = 30;
                            nombreespecie = "Perro";
                        }
                        else if (opc3 == 2)
                        {
                            peso = 80;
                            nombreespecie = "Cerdos";
                        }
                        else if (opc3 == 3)
                        {
                            peso = 150;
                            nombreespecie = "León";
                        }
                        else
                        {
                            peso = 0;
                        }
                    } //Caso 2. Mamiferos
                    else if (opc == 3)
                    {
                        Console.WriteLine("Elige una especie de aves\n1. Pinzon\n2. Aguila\n3. Halcón");
                        Console.WriteLine("Llevas un peso total de: {0}kg", pesototal);
                        opc3 = int.Parse(Console.ReadLine());
                        if (opc3 == 1)
                        {
                            peso = 0.7;
                            nombreespecie = "Pinzon";
                        }
                        else if (opc3 == 2)
                        {
                            peso = 10;
                            nombreespecie = "Aguila";
                        }
                        else if (opc3 == 3)
                        {
                            peso = 10;
                            nombreespecie = "Halcón";
                        }
                        else
                        {
                            peso = 0;
                        }
                    } //Caso 3. Aves
                    else if (opc == 4)
                    {
                        Console.WriteLine("Elige tu especie a introducir en el Arca de Noe\n1. Rana\n2. Salamandra \n3. Sapo");
                        Console.WriteLine("Llevas un peso total de: {0}kg", pesototal);
                        opc3 = int.Parse(Console.ReadLine());
                        if (opc3 == 1)
                        {
                            peso = 1;
                            nombreespecie = "Rana";
                        }
                        else if (opc3 == 2)
                        {
                            peso = 0.5;
                            nombreespecie = "Salamandra";
                        }
                        else if (opc3 == 3)
                        {
                            peso = 3;
                            nombreespecie = "Sapo";
                        }
                        else
                        {
                            peso = 0;
                        }
                    } //Caso 4. Anfibios
                    else if (opc == 5)
                    {
                        Console.WriteLine("Elige una especie de reptil\n1. Cocodrilo\n2. Serpiente\n3. Tortuga");
                        Console.WriteLine("Llevas un peso total de: {0}kg", pesototal);
                        opc3 = int.Parse(Console.ReadLine());
                        if (opc3 == 1)
                        {
                            peso = 200;
                            nombreespecie = "Cocodrilo";
                        }
                        else if (opc3 == 2)
                        {
                            peso = 25;
                            nombreespecie = "Serpiente";
                        }
                        else if (opc3 == 3)
                        {
                            peso = 100;
                            nombreespecie = "Tortuga";
                        }
                        else
                        {
                            peso = 0;
                        }
                    } //Caso 5. Reptiles
                    else
                    {
                        Console.WriteLine("Opcion invalida");
                    }
                    Console.Clear();
                    //Almacenamiento del nombre de la especie
                    especie[numanim] = nombreespecie;

                    //Almacenamiento del peso del animal
                    pesosregistrados[numanim] = peso;
                    pesototal = pesototal + peso;

                    //Almacenamiento del sexo del animal
                    Console.WriteLine("¿Cual es el sexo del animal?\n1. Macho\n2. Hembra");
                    opc4 = int.Parse(Console.ReadLine());
                    if (opc4 == 1)
                    {
                        sexo = "Macho";
                    }
                    else if (opc4 == 2)
                    {
                        sexo = "Hembra";
                    }
                    sexos[numanim] = sexo;
                    Console.Clear();

                    //Preguntar si añadimos otro animal
                    if (pesototal < 400)
                    {
                        Console.WriteLine("¿Deseas volver a ingresar otro animal?\n1. Si\n2. No");
                        Console.WriteLine("Llevas un peso total de: {0}kg", pesototal);
                        opc2 = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                    //Caso de que el usuario excede el limite
                    if (pesototal > 400)
                    {
                    Console.WriteLine("Haz superado el límite de peso, tienes {0}kg", pesototal);
                    pesototal = 0;
                    opc2 = 2;
                    }
                }
                while (opc2 == 1);

                //Preguntamos si decide volver a ingresar otro animal
                Console.WriteLine("¿Deseas repetir el juego?\n1. Si\n2. No");
                opc2 = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            while (opc2== 1);

            //Mostreo de animales que estan en el arca (solo se muestra
            Console.WriteLine("Haz subido al arca los siguientes animales que sobrevivirán al diluvio\n");
            for (int i = 1; i <= numanim; i++)
            {
                Console.WriteLine("{0}: {1}kg, {2}", especie[i], pesosregistrados[i], sexos[i]);
            }
            Console.WriteLine("\nHaz subido al arca {0} animales, con un peso total de {1} kilogramos",numanim, pesototal);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
