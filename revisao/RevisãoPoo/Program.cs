using RevisãoPoo.Controller;
using RevisãoPoo.Model;
using System;

namespace RevisãoPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProdutoController controller = new ProdutoController();

            int opcao, id, tipo, aniversario, numero, numeroDestino;
            string? nome, generico, cosmetico, fragancia;
            decimal saldo, limite, valor, preco;

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
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
                                        Console.WriteLine("Digite o Numero do ID para o Produto: ");
                                        id = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Digite o Nome do Produto: ");
                                        nome = Console.ReadLine();

                                        nome ??= string.Empty;

                                        do
                                        {
                                            Console.WriteLine("Digite o tipo de Produto (1 - Medicamento ou 2 - Cosmetico)");
                                            tipo = Convert.ToInt32(Console.ReadLine());
                                        } while (tipo != 1 && tipo != 2);

                                        Console.WriteLine("Digite o Saldo da Conta (R$): ");
                                        saldo = Convert.ToDecimal(Console.ReadLine());

                                        switch (tipo)
                                        {
                                            case 1:
                                                Console.WriteLine("Digite o nome do Generico (R$): ");
                                                generico = Console.ReadLine();
                                                controller.CriarProduto(new Medicamento(controller.GerarId(),nome,tipo,preco, generico));
                                                break;

                                            case 2:
                                                Console.WriteLine("Digite o dia do Aniversario da Conta ");
                                                fragancia = Console.ReadLine();
                                                controller.CriarProduto(new Cosmetico(controller.GerarId(),nome,tipo,preco,fragancia));
                                                break;
                                        }

                                        KeyPress();
                                        break;
                            /*        case 2:
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Listar todas as Contas\n\n");
                                        Console.ResetColor();

                                        contas.ListarTodas();

                                        KeyPress();
                                        break;
                                    case 3:
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("Consultar dados da Conta - por número\n\n");
                                        Console.ResetColor();

                                        Console.WriteLine("Digite o Numero da Conta: ");

                                        numero = Convert.ToInt32(Console.ReadLine());
                                        contas.ProcurarPorNumero(numero);

                                        KeyPress();
                                        break;
                                    case 4:
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Atualizar dados da Conta\n\n");
                                        Console.ResetColor();

                                        Console.WriteLine("Digite o número da Conta: ");
                                        numero = Convert.ToInt32(Console.ReadLine());

                                        var conta = contas.BuscarNaCollection(numero);

                                        if (conta is not null)
                                        {
                                            Console.WriteLine("Digite o Número da Agência: ");
                                            agencia = Convert.ToInt32(Console.ReadLine());

                                            Console.WriteLine("Digite o Nome do Titular: ");
                                            titular = Console.ReadLine();

                                            titular ??= string.Empty;

                                            Console.WriteLine("Digite o Saldo da Conta: ");
                                            saldo = Convert.ToDecimal(Console.ReadLine());

                                            tipo = conta.GetTipo();

                                            switch (tipo)
                                            {
                                                case 1:
                                                    Console.WriteLine("Digite o Limite da Conta: ");
                                                    limite = Convert.ToDecimal(Console.ReadLine());

                                                    contas.Atualizar(new ContaCorrente(numero, agencia, tipo, titular, saldo, limite));
                                                    break;
                                                case 2:
                                                    Console.WriteLine("Digite o dia do Aniversário da Conta: ");
                                                    aniversario = Convert.ToInt32(Console.ReadLine());

                                                    contas.Atualizar(new ContaPoupanca(numero, agencia, tipo, titular, saldo, aniversario));
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine($"A conta numero {numero} não foi encontrada!");
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

                                        numero = Convert.ToInt32(Console.ReadLine());
                                        contas.Deletar(numero);

                                        KeyPress();
                                        break;
                                    case 6:
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Saque\n\n");
                                        Console.ResetColor();

                                        Console.WriteLine("Digite o Numero da Conta: ");
                                        numero = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine("Digite o Valor do Saque (R$): ");
                                        valor = Convert.ToDecimal(Console.ReadLine());

                                        contas.Sacar(numero, valor);

                                        KeyPress();
                                        break;
                                    case 7:
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Depósito\n\n");
                                        Console.ResetColor();

                                        Console.WriteLine("Digite o Numero da Conta: ");
                                        numero = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine("Digite o Valor do Deposito (R$): ");
                                        valor = Convert.ToDecimal(Console.ReadLine());

                                        contas.Depositar(numero, valor);

                                        KeyPress();
                                        break;
                                    case 8:
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Transferência entre Contas\n\n");
                                        Console.ResetColor();

                                        Console.WriteLine("Digite o Numero da Conta de Origem: ");
                                        numero = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine("Digite o Numero da Conta de Destino: ");
                                        numeroDestino = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine("Digite o Valor da Transferencia (R$): ");
                                        valor = Convert.ToDecimal(Console.ReadLine());

                                        contas.Transferir(numero, numeroDestino, valor);

                                */
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
    }
}