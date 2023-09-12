using RevisãoPoo.Controller;
using RevisãoPoo.Model;
using System;

namespace RevisãoPoo
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {

            ProdutoController controller = new ProdutoController();

            int opcao, id, tipo;
            string? nome, generico, fragancia;
            decimal valor;

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                LogoMarca();
                Console.WriteLine("                                                     ");
                Console.WriteLine("=====================================================");
                Console.WriteLine("                                                     ");
                Console.WriteLine("            1 - Criar Produto                        ");
                Console.WriteLine("            2 - Listar todos os produtos             ");
                Console.WriteLine("            3 - Buscar produto por IDro              ");
                Console.WriteLine("            4 - Atualizar Produto                    ");
                Console.WriteLine("            5 - Apagar Produto                       ");
                Console.WriteLine("            9 - Sair                                 ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("=====================================================");
                Console.WriteLine("                                                     ");
                Console.WriteLine("Entre com a opção desejada:                          ");
                Console.WriteLine("                                                     ");
                Console.ResetColor();

                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDigite valores inteiros!");
                    opcao = 0;
                    Console.ResetColor();
                }

                if (opcao == 9)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nVolte Sempre");
                    Sobre();
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Criar Produto\n\n");
                        Console.ResetColor();
                        id = controller.GerarId();
                        Console.WriteLine("Digite o Nome do Produto: ");
                        nome = Console.ReadLine();

                        nome ??= string.Empty;

                        Console.WriteLine("Digite o Valor do Produto: ");
                        valor = Convert.ToDecimal(Console.ReadLine());

                        do
                        {
                            Console.WriteLine("Digite o tipo de Produto (1 - Medicamento ou 2 - Cosmetico)");
                            tipo = Convert.ToInt32(Console.ReadLine());
                        } while (tipo != 1 && tipo != 2);

                        switch (tipo)
                        {
                            case 1:
                                Console.WriteLine("Digite o nome do Generico : ");
                                generico = Console.ReadLine();
                                controller.CriarProduto(new Medicamento(id, nome, tipo, valor, generico));

                                break;

                            case 2:
                                Console.WriteLine("Digite a Fragancia");
                                fragancia = Console.ReadLine();
                                controller.CriarProduto(new Cosmetico(id, nome, tipo, valor, fragancia));
                                break;
                        }

                        KeyPress();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Listar todos os Produtos\n\n");
                        Console.ResetColor();

                        controller.ListarTodos();

                        KeyPress();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Consultar Produtos - por número\n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o Numero do Produto: ");

                        id = Convert.ToInt32(Console.ReadLine());
                        controller.BuscarPorId(id);

                        KeyPress();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Atualizar dados do Produto\n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número do Produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        var produto = controller.BuscarNaCollection(id);

                        if (produto is not null)
                        {
                            Console.WriteLine("Digite o Nome do Produto: ");
                            nome = Console.ReadLine();

                            tipo = produto.Tipo;

                            valor = Convert.ToDecimal(Console.ReadLine());

                            switch (tipo)
                            {
                                case 1:
                                    Console.WriteLine("Digite o nome do Generico: ");
                                    generico = Console.ReadLine();

                                    controller.AtualizarProduto((new Medicamento(id, nome, tipo, valor, generico)));
                                    break;
                                case 2:
                                    Console.WriteLine("Digite o tipo de fragancia: ");
                                    fragancia = Console.ReadLine();

                                    controller.AtualizarProduto(new Cosmetico(id, nome, tipo, valor, fragancia));
                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"O produto numero {id} não foi encontrada!");
                            Console.ResetColor();
                        }

                        KeyPress();
                        break;
                    case 5:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Apagar a Conta\n\n");
                        Console.ResetColor();
                        Console.WriteLine("Digite o Numero da Conta: ");

                        id = Convert.ToInt32(Console.ReadLine());
                        controller.Deletar(id);

                        KeyPress();
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpção Inválida!\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                }
            }
        }

        static void Sobre()
        {
            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Projeto Desenvolvido por: Anderson Alves");
            Console.WriteLine("Email: alves_anderson@outlook.com");
            Console.WriteLine("Generation Brasil - generation@generation.org");
            Console.WriteLine("github.com/ander-alves");
            Console.WriteLine("*********************************************************");

        }

        static void KeyPress()
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nPressione Enter para Continuar...");
                consoleKeyInfo = Console.ReadKey();

            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }


        static void LogoMarca()
        {
            Console.WriteLine("  ____            _           _____                               _           \r\n" +
                " |  _ \\ _____   _(_)___  __ _|  ___|_ _ _ __ _ __ ___   __ _  ___(_) __ _ ___ \r\n" +
                " | |_) / _ \\ \\ / / / __|/ _` | |_ / _` | '__| '_ ` _ \\ / _` |/ __| |/ _` / __|\r\n" +
                " |  _ <  __/\\ V /| \\__ \\ (_| |  _| (_| | |  | | | | | | (_| | (__| | (_| \\__ \\\r\n" +
                " |_| \\_\\___| \\_/ |_|___/\\__,_|_|  \\__,_|_|  |_| |_| |_|\\__,_|\\___|_|\\__,_|___/\r\n" +
                "                                                                              ");

        }
    }
}

