using System;

namespace LetsCodeGrupoA.sort
{
    public static class MenuSort
    {
        public static int[] Iniciar(bool retornarElementosParaBusca = false)
        {
            Console.Clear();
            Console.WriteLine("Ordenação...");
            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Insertion Sort...");
            Console.WriteLine("2. Quick Sort...");
            Console.WriteLine("3. Merge Sort");
            Console.WriteLine("4. Bubble Sort");
            Console.WriteLine("5. Shell Sort");
            Console.WriteLine("6. Retornar ao menu inicial");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");
            
            int[] elementosOrdenados = null;

            switch (Console.Read())
            {
                case '1':
                    Console.ReadLine();

                    elementosOrdenados = Sort.InsertionSort(ConstruirArray());

                    break;
                case '2':
                    Console.ReadLine();

                    var elementosQuick = ConstruirArray();

                    elementosOrdenados = Sort.QuickSort(elementosQuick, 0, elementosQuick.Length - 1);

                    break;
                case '3':
                    Console.ReadLine();

                    var elementosMerge = ConstruirArray();

                    elementosOrdenados = Sort.MergeSort_Recursive(elementosMerge, 0, elementosMerge.Length - 1);

                    break;
                case '4':
                    Console.ReadLine();

                    elementosOrdenados = Sort.BubbleSort(ConstruirArray());                    

                    break;
                case '5':
                    Console.ReadLine();

                    elementosOrdenados = Sort.ShellSort(ConstruirArray());

                    break;
                case '6':
                    Console.ReadLine();
                    return null;                    
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
            }

            Exibicao(elementosOrdenados);

            if (!retornarElementosParaBusca)
                Iniciar();

            return elementosOrdenados;
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

        public static void Exibicao(int[] elementos)
        {
            Console.Clear();
            Console.WriteLine("Valores ordenados...");

            for (int i = 0; i < elementos.Length; i++)            
                Console.WriteLine("Numero da posição {0} - {1}", i, elementos[i]);   
            
            Console.ReadLine();
        }
    }
}