using System;
using System.Collections.Generic;

namespace aula.lista
{
    /**
        Criar um menu com as opções
            1 - Adicionar um novo vagão
            2 - Exibir o último vagão
            3 - Exibir todos os vagões
            4 - Buscar por id dentro do trem
            5 - Buscar por nome dentro do trem
            6 - Buscar por peso dentro do trem
            7 - Atualizar as informações de um vagão
            8 - Excluir um vagão
            0 - Sair
    **/

    public class Menu
    {
        public static void main() {
            // Console.ReadLine();
            
            // Console.WriteLine("Filas...");
            // if(initialQueue.Count <= 0) {
            //     initialQueue = CreateQueue();
            // }
            ListaLigada gerenciarVagoes = new ListaLigada();


            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Adicionar um novo vagão");
            Console.WriteLine("2. Exibir o último vagão");
            Console.WriteLine("3. Exibir todos os vagões");
            Console.WriteLine("4. Buscar por id dentro do trem");
            Console.WriteLine("5. Buscar por nome dentro do trem");
            Console.WriteLine("6. Buscar por peso dentro do trem");
            Console.WriteLine("7. Atualizar as informações de um vagão");
            Console.WriteLine("8. Excluir um vagão");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");

            switch (Console.Read())
            {
                case '1':
                    gerenciarVagoes.InserirVagao(CriarVagao());
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

        public static  Vagao CriarVagao(){
            Console.WriteLine("Numero do Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome da carga: ");
            var carga = Console.ReadLine();
            Console.WriteLine("Peso da carga: ");
            var peso = int.Parse(Console.ReadLine());

            return new Vagao{Id=id, Carga=carga, Peso=peso};
        }
    }
}