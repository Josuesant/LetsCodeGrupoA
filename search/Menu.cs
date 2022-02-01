using System;
using System.Collections.Generic;

namespace LetsCodeGrupoA.search
{
    public class Menu
    {
        public static void Iniciar()
        {
            Console.ReadLine();

            Console.WriteLine("Busca...");

            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Linear Search...");
            Console.WriteLine("2. Binary Search...");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");

            switch (Console.Read())
            {
                case '1':
                    Console.ReadLine();

                    ConstruirArray();

                    Console.WriteLine("Insira o valor de deseja buscar...");
                    Search.LinearSearch(Convert.ToInt32(Console.ReadLine()));
                    break;
                case '2':
                    Console.ReadLine();

                    ConstruirArray();

                    Console.WriteLine("Insira o valor de deseja buscar...");
                    Search.BinarySearch(Convert.ToInt32(Console.ReadLine()));
                    break;
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
            }
            Iniciar();
        }

        public static void ConstruirArray()
        {
            for (int i = 0; i < Search.elementos.Length; i++)
            {
                Console.WriteLine("Insira o numero da posição {0} ...", i);
                Search.elementos[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}