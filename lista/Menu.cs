using System;
using System.Collections.Generic;
using System.Linq;

namespace aula.lista
{
    /**
        Criar um menu com as opções
            1 - Adicionar um novo vagão - OK
            2 - Exibir o último vagão - OK
            3 - Exibir todos os vagões - OK
            4 - Buscar por id dentro do trem - OK
            5 - Buscar por nome dentro do trem - OK
            6 - Buscar por peso dentro do trem - OK
            7 - Atualizar as informações de um vagão - OK
            8 - Excluir um vagão - OK
            0 - Sair - OK
    **/

    public class Menu
    {
        static ListaLigada gerenciarVagoes = new ListaLigada();

        public static void main()
        {
            ExibirOpcoes();

            switch (Console.ReadLine())
            {
                case "1":
                    AdicionarVagao();
                    break;
                case "2":
                    ExibirUltimoVagao();
                    break;
                case "3":
                    ExibirTodosVagoes();
                    break;
                case "4":
                    BuscarVagaoPorId();
                    break;
                case "5":
                    BuscarVagaoPorCarga();
                    break;
                case "6":
                    BuscarVagaoPorPeso();
                    break;
                case "7":
                    AtualizarVagao();
                    break;
		        case "8":
                    ExcluirVagao();
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
        private static void ExibirOpcoes()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Adicionar um novo vagão");

            if (gerenciarVagoes.Trem != null)
            {
                Console.WriteLine("2. Exibir o último vagão");
                Console.WriteLine("3. Exibir todos os vagões");
                Console.WriteLine("4. Buscar por id dentro do trem");
                Console.WriteLine("5. Buscar por nome dentro do trem");
                Console.WriteLine("6. Buscar por peso dentro do trem");
                Console.WriteLine("7. Atualizar as informações de um vagão");
                Console.WriteLine("8. Excluir um vagão");
            }

            Console.WriteLine("0. Sair");
            Console.WriteLine("Opção: ");
        }

        private static void AdicionarVagao()
        {
            Console.Clear();
            Console.WriteLine("NOVO VAGÃO\n");
            Console.WriteLine("Numero do Id: ");

            int id = Convert.ToInt32(Console.ReadLine());
            var vagao = gerenciarVagoes.GetVagaoById(id);
            
            if(vagao is not null)
                Console.WriteLine("Já existe um vagão com esse Id");
            else
            {
                gerenciarVagoes.InserirVagao(CriarVagao(id));
                Console.WriteLine("Vagão adicionado!");
            }

            Console.ReadLine();
        }

        private static Vagao CriarVagao(int id)
        {
            Console.WriteLine("Nome da carga: ");
            var carga = Console.ReadLine();
            Console.WriteLine("Peso da carga: ");
            var peso = int.Parse(Console.ReadLine());

            return new Vagao { Id = id, Carga = carga, Peso = peso };
        }

        private static void ExibirUltimoVagao()
        {
            Console.Clear();

            var ultimoVagao = gerenciarVagoes.GetUltimoVagao();

            Console.WriteLine("ÚLTIMO VAGÃO\n");
            ExibirVagao(ultimoVagao);

            Console.ReadLine();
        }

        private static void ExibirVagao(Vagao vagao)
        {
            Console.WriteLine($"ID: {vagao.Id}");
            Console.WriteLine($"Carga: {vagao.Carga}");
            Console.WriteLine($"Peso: {vagao.Peso}");
        }

        private static void ExibirTodosVagoes()
        {
            Console.Clear();

            var listaVagoes = gerenciarVagoes.GetVagoes();
            Console.WriteLine("TODOS OS VAGÕES:");

            foreach (var vagao in listaVagoes)            
                ExibirVagao(vagao);

            Console.ReadLine();
        }

        public static void BuscarVagaoPorId()
        {
            Console.Clear();

            Console.Write("ID: ");

            var id = Convert.ToInt32(Console.ReadLine());
            var vagao = gerenciarVagoes.GetVagaoById(id);

            if (vagao != null)
                ExibirVagao(vagao);
            else
                Console.WriteLine("Vagão não encontrado!");

            Console.ReadLine();
        }

        public static void BuscarVagaoPorCarga()
        {
            Console.Clear();

            Console.Write("Carga: ");
            var carga = Console.ReadLine();
            var vagoes = gerenciarVagoes.GetVagaoByName(carga);

            if(vagoes.Any())
                foreach (var vagao in vagoes)            
                    ExibirVagao(vagao);
            else
                Console.WriteLine("Vagão não encontrado!");

            Console.ReadLine();
        }

        public static void BuscarVagaoPorPeso()
        {
            Console.Clear();

            Console.Write("Peso: ");
            var peso = Convert.ToInt32(Console.ReadLine());
            var vagoes = gerenciarVagoes.GetVagaoByPeso(peso);
            
            if (vagoes.Any())
                foreach (var vagao in vagoes)
                    ExibirVagao(vagao);
            else
                Console.WriteLine("Vagão não encontrado!");

            Console.ReadLine();
        }

        private static void AtualizarVagao()
        {
            Console.Clear();

            Console.WriteLine("ATUALIZAR VAGÃO\n");
            Console.Write("Digite o ID do vagão que deseja atualizar: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var vagao = gerenciarVagoes.GetVagaoById(id);

            if (vagao == null)
                Console.WriteLine("Vagão não encontrado!");
            else
            {
                Console.WriteLine("Nova carga: ");
                vagao.Carga = Console.ReadLine();
                Console.WriteLine("Novo peso: ");
                vagao.Peso = int.Parse(Console.ReadLine());
                Console.WriteLine("Vagão atualizao!");
            }
            Console.ReadLine();
        }

        private static void ExcluirVagao()
        {
            Console.Clear();
            Console.Write("Digite o ID do vagão que deseja excluir: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var vagao = gerenciarVagoes.GetVagaoById(id);

            if (vagao == null)
                Console.WriteLine("Vagão não encontrado!");
            else
            {
                gerenciarVagoes.DeletarVagao(vagao);
                Console.WriteLine("Vagão excluído!");
            }
            
            Console.ReadLine();
        }
    }
}