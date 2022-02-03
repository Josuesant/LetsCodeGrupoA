using System;
using System.Collections.Generic;

namespace LetsCodeGrupoA.search
{
    public static class MenuSearch
    {
        public static void Iniciar(int[] elementos)
        {

            Console.Clear();
            Console.WriteLine("Busca...");

            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Linear Search...");
            Console.WriteLine("2. Binary Search...");
            Console.WriteLine("0. Sair");
            Console.WriteLine("Opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Insira o valor de deseja buscar...");

                    try
                    {
                        var indexEncontrado = Search.LinearSearch(elementos, Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Busca feita com sucesso. O número " + elementos[indexEncontrado] + " foi encontrado no índice " + indexEncontrado);
                        Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Insira o valor de deseja buscar...");
                    try
                    {
                        var indexEncontradoBinary = Search.BinarySearch(elementos, Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Busca feita com sucesso " + "O número " + elementos[indexEncontradoBinary] + " foi encontrado no índice " + indexEncontradoBinary);
                        Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
            }
            
            Iniciar(elementos);
        }

        
        public static int[] ConstruirArray()
        {
            Console.Clear();
            Console.WriteLine("Insira o tamanho do array:");
            var tamanhoArray = Convert.ToInt32(Console.ReadLine());

            int[] elementos = new int[tamanhoArray];

            for (int i = 0; i < tamanhoArray; i++)
            {
                Console.WriteLine("Número da posição {0}: ", i);
                elementos[i] = Convert.ToInt32(Console.ReadLine());
            }

            return elementos;
        }
    }
}