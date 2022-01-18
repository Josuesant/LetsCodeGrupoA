using System;

namespace aula.pilha {
    public class PilhaRoots {
        public static void Menu(int[] initialStack) {
            Console.ReadLine();
            
            Console.WriteLine("Pilhas...");
            if(initialStack.Length <= 0) {
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
                    initialStack = Add(initialStack, Convert.ToInt32(Console.ReadLine()));
                    break;
                case '2':
                    Console.WriteLine("Removendo um valor da pilha...");
                    initialStack = Remove(initialStack);
                    break;
                case '3':
                    ShowValue(initialStack);
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

        public static int[] CreateStack() {
            Console.WriteLine("Iniciando Criação da Pilha...");

            Console.Write("Insira a quantidade de itens inicial da sua pilha: ");
            int[] numbers = new int[Int32.Parse(Console.ReadLine())];
            
            for(int i = 0; i < numbers.Length; i++) {
                Console.WriteLine("Insira o numero para a posição {0} da pilha...", i+1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }        

            return numbers;    
        }

        public static int[] Remove(int[] stackValues) {
            int[] newStack = new int[stackValues.Length - 1];

            for(int i = 0; i < stackValues.Length - 1; i++) {
                newStack[i] = stackValues[i];
            }

            return newStack;
        }

        public static int[] Add(int[] stackValues, int value) {
            int[] newStack = new int[stackValues.Length + 1];

            for(int i = 0; i < newStack.Length; i++) {
                if(i == newStack.Length - 1) newStack[i] = value;
                else newStack[i] = stackValues[i];

                /**
                * Maneira com Ternário
                * newStack[i] = (i == newStack.Length - 1 ? value : stackValues[i]);
                **/
            }

            return newStack;
        }
        
        public static void ShowStack(int[] stackValues) {
            for(int i = (stackValues.Length - 1); i >= 0; i--) {
                Console.WriteLine($"Numero da posição {stackValues.Length - i} da pilha é {stackValues[i]}");
            }
        }

        public static void ShowValue(int[] stackValues) {
            Console.WriteLine(stackValues[stackValues.Length - 1]);
        }
    }
}