﻿using System;

namespace RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {
            int largura, altura;
            int meio = 1;
            bool terminar = false;
            while (!terminar)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Insira as medidas do seu triângulo.");
                Console.Write("Largura: ");
                bool largurabool = Int32.TryParse(Console.ReadLine(), out largura);
                Console.Write("Altura: ");
                bool alturabool = Int32.TryParse(Console.ReadLine(), out altura);

                if(!largurabool || !alturabool)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Favor inserir um valor válido.");
                    Console.WriteLine("Pressione uma tecla para inserir outro valor.");
                    Console.WriteLine();
                    Console.ReadKey();
                }
                else
                {
                    int linhadecima = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    while (linhadecima <= largura)
                    {
                        Console.Write(". ");
                        linhadecima++;
                    }
                    Console.WriteLine();
                    int menosaltura = altura - 2;
                    while(meio <= menosaltura)
                    {
                        int xx = 1;
                        Console.Write(". ");
                        int menos = largura - 2;
                        while (xx <= menos)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(". ");
                            xx++;
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(". ");
                        Console.WriteLine();
                        meio++;
                    }
                    int linhadebaixo = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    while (linhadebaixo <= largura)
                    {
                        Console.Write(". ");
                        linhadebaixo++;
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    terminar = true;
                }
            }
        }
    }
}
