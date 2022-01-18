using System;
using System.Collections.Generic;

namespace aula.fila
{
    public class Fila
    {
        const int limitQueue = 20; 
        public static void Menu(Queue<int> initialQueue) {
            Console.ReadLine();
            
            Console.WriteLine("Filas...");
            if(initialQueue.Count <= 0) {
                initialQueue = CreateQueue();
            }

            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Adicione novo valor a sua Fila...");
            Console.WriteLine("2. Remova o valor da sua fila...");
            Console.WriteLine("3. Exibir a posição atual");
            Console.WriteLine("4. Exibir toda a fila");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");

            switch (Console.Read())
            {
                case '1':
                    Console.ReadLine();
                    if(initialQueue.Count >= limitQueue)
                        Console.WriteLine("Não é possível inserir mais valores, por favor remova");
                    else {
                        Console.WriteLine("Adicionando um valor da fila...");
                        Console.WriteLine("Insira um outro numero...");
                        initialQueue.Enqueue(Convert.ToInt32(Console.ReadLine()));
                    }
                    break;
                case '2':
                    Console.WriteLine("Removendo um valor da fila...");
                    initialQueue.Dequeue();
                    break;
                case '3':
                    Console.WriteLine(initialQueue.Peek());
                    break;
                case '4':
                    ShowQueue(initialQueue);
                    break;
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
            }
            Menu(initialQueue);
        }

        public static Queue<int> CreateQueue() {
            Console.WriteLine("Iniciando Criação da fila...");
            
            Queue<int> numbers = new Queue<int>();
            int quantity = 0;

            do {
                Console.Write("Insira a quantidade de itens inicial da sua fila (no máximo {0}): ", limitQueue);
                quantity = Int32.Parse(Console.ReadLine());
                if(quantity <= limitQueue)
                    for(int i = 1; i <= quantity; i++) {
                        Console.WriteLine("Insira o numero para a posição {0} da fila...", i);
                        numbers.Enqueue(Convert.ToInt32(Console.ReadLine()));
                    }
                else Console.WriteLine("Por favor, insira até {0} itens", limitQueue);
            } while(quantity > limitQueue);

            return numbers;    
        }

        public static void ShowQueue(Queue<int> queueValues) {
            int i = 1;
            foreach (var item in queueValues)
            {
                Console.WriteLine($"Numero da posição {i} da fila é {item}");
                i++;
            }
        }
    }
}