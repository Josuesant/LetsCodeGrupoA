using System;

namespace LetsCodeGrupoA.sort
{
    public class Menu
    {
        public static void Iniciar()
        {
            Console.ReadLine();

            Console.WriteLine("Ordenação...");

            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Insertion Sort...");
            Console.WriteLine("2. Quick Sort...");
            Console.WriteLine("3. Merge Sort");
            Console.WriteLine("4. Bubble Sort");
            Console.WriteLine("5. Shell Sort");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");

            switch (Console.Read())
            {
                case '1':
                    Console.ReadLine();

                    ConstruirArray();

                    Sort.InsertionSort();

                    Exibicao();

                    break;
                case '2':
                    Console.ReadLine();

                    ConstruirArray();

                    Sort.Quicksort(Sort.elementos, 0, Sort.elementos.Length - 1);

                    Exibicao();

                    break;
                case '3':
                    Console.ReadLine();

                    ConstruirArray();

                    Sort.MergeSort_Recursive(Sort.elementos, 0, Sort.elementos.Length - 1);
                    
                    Exibicao();

                    break;
                case '4':
                    Console.ReadLine();

                    ConstruirArray();

                    Sort.BubbleSort();
                    
                    Exibicao();

                    break;
                case '5':
                    Console.ReadLine();

                    ConstruirArray();

                    Sort.ShellSort(Sort.elementos);
                    
                    Exibicao();

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
            for (int i = 0; i < Sort.elementos.Length; i++)
            {
                Console.WriteLine("Insira o numero da posição {0} ...", i);
                Sort.elementos[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void Exibicao()
        {
            Console.WriteLine("Valores ordenados...");
            for (int i = 0; i < Sort.elementos.Length; i++)
            {
                Console.WriteLine("Numero da posição {0} - {1}", i, Sort.elementos[i]);
            }
        }
    }
}