using System;
using System.Collections.Generic;

namespace aula.pilha
{
    public class Pilha
    {
        public static void Menu(Stack<int> initialStack) {
            Console.ReadLine();
            
            Console.WriteLine("Pilhas...");
            if(initialStack.Count <= 0) {
                initialStack = CreateStack();
            }

            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Adicione novo valor a sua Pilha...");
            Console.WriteLine("2. Remova o valor da sua Pilha...");
            Console.WriteLine("3. Exibir a posição atual");
            Console.WriteLine("4. Exibir toda a pilha");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");
            switch (Console.Read())
            {
                case '1':
                    Console.ReadLine();
                    Console.WriteLine("Adicionando um valor da pilha...");
                    Console.WriteLine("Insira um outro numero...");
                    initialStack.Push(Convert.ToInt32(Console.ReadLine()));
                    break;
                case '2':
                    Console.WriteLine("Removendo um valor da pilha...");
                    initialStack.Pop();
                    break;
                case '3':
                    Console.WriteLine(initialStack.Peek());
                    break;
                case '4':
                    ShowStack(initialStack);
                    break;
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
            }
            Menu(initialStack);
        }

        public static Stack<int> CreateStack() {
            Console.WriteLine("Iniciando Criação da Pilha...");


            Stack<int> numbers = new Stack<int>();
            Console.Write("Insira a quantidade de itens inicial da sua pilha: ");
            int quantity = Int32.Parse(Console.ReadLine());
            
            for(int i = 1; i <= quantity; i++) {
                Console.WriteLine("Insira o numero para a posição {0} da pilha...", i);
                numbers.Push(Convert.ToInt32(Console.ReadLine()));
            }        

            return numbers;    
        }

        public static void ShowStack(Stack<int> stackValues) {
            int i = 1;
            foreach (var item in stackValues)
            {
                Console.WriteLine($"Numero da posição {i} da pilha é {item}");
                i++;
            }
        }
    }
}