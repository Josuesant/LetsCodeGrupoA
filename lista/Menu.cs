using System;
using System.Collections.Generic;
using System.Linq;

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
        static ListaLigada gerenciarVagoes = new ListaLigada();

        public static void main() {

            Console.Clear();
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
            Console.WriteLine("Opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    gerenciarVagoes.InserirVagao(CriarVagao());
                    Console.WriteLine("Vagão adicionado!");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    var ultimoVagao = gerenciarVagoes.getUltimoVagao();
                    Console.WriteLine("ÚLTIMO VAGÃO\n");
                    ExibirVagao(ultimoVagao);
                    Console.ReadLine();
                    break;
                case "7":
                    Console.Clear();
                    AtualizarVagao();
                   break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
            }
            main();
        }

        private static  Vagao CriarVagao(){
            Console.WriteLine("NOVO VAGÃO\n");
            Console.WriteLine("Numero do Id: ");
            
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nome da carga: ");
            var carga = Console.ReadLine();
            Console.WriteLine("Peso da carga: ");
            var peso = int.Parse(Console.ReadLine());

            return new Vagao{ Id = id, Carga = carga, Peso = peso};
        }

        private static void ExibirVagao(Vagao vagao)
        {
            Console.WriteLine($"ID: {vagao.Id}");
            Console.WriteLine($"Carga: {vagao.Carga}");
            Console.WriteLine($"Peso: {vagao.Peso}");
        }

        private static void AtualizarVagao()
        {
            Console.WriteLine("ATUALIZAR VAGÃO\n");
            Console.Write("Digite o ID do vagão que deseja atualizar: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var vagao = gerenciarVagoes.getVagaoById(id);

            if (vagao == null)
                Console.WriteLine("Vagão não encontrado!");
            else
            {
                Console.WriteLine("Nova carga: ");
                vagao.Carga = Console.ReadLine();
                Console.WriteLine("Novo peso: ");
                vagao.Peso = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}