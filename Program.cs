using System;
using System.Collections.Generic;
using LetsCodeGrupoA.search;
using LetsCodeGrupoA.sort;

namespace aula
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Ordenar array");
            Console.WriteLine("2. Buscar array");            
            Console.WriteLine("0. Sair");
            Console.WriteLine("Opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    MenuSort.Iniciar();
                    break;
                case "2":
                    var elementosOrdenados = MenuSort.Iniciar(true);
                    MenuSearch.Iniciar(elementosOrdenados);
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
            }
            Main();
        }
    }
}