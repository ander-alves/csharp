namespace Atividade02Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Stack<String> stack = new Stack<String>();
                int seletor = 0;

                do
                {
                    Console.WriteLine("\nInforme a Opção desejada :\n");
                    Console.WriteLine("**********************************************\n" +
                        "1 - ADICIONAR LIVROS NA PILHA\n" +
                        "2 - LISTAR TODOS OS LIVROS \n" +
                        "3 - RETIRAR LIVRO NA PILHA\n" +
                        "0 - SAIR\n" +
                        "*************************************************************\n" +
                        "Entre com a Opção desejada :\n");

                    seletor = Convert.ToInt32(Console.ReadLine());

                    switch (seletor)
                    {
                        case 1:
                            Console.WriteLine("\nInforme o nome Do Livro\n");
                            stack.Push(Console.ReadLine());
                            Console.WriteLine("\nLivro Adicionado\n");
                            break;
                        case 2:
                            Console.WriteLine("\nLista de Livros \n");
                            foreach (String s in stack) Console.WriteLine(s);
                            break;
                        case 3:
                            if (stack.Count != 0)
                            {
                                Console.WriteLine("\nO Livro foi removido\n");
                                stack.Pop();
                            }
                            else
                                Console.WriteLine("A Pilha esta Vazia");
                            break;
                        case 0:
                            Console.WriteLine("\nObrigado\n");
                            break;
                        default:
                            Console.WriteLine("\nUnknown value\n");
                            break;
                    }

                } while (seletor != 0);
            }
        }
    }
}