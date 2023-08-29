using System.Linq.Expressions;

namespace Atividade01Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<String> queue = new Queue<String>();
            int seletor = 0;

            do
            {
                Console.WriteLine("\nInforme a Opção desejada :\n");
                Console.WriteLine("**********************************************\n" +
                    "1 - ADICIONAR CLIENTES NA FILA\n" +
                    "2 - LISTAR TODOS OS CLIENTE \n" +
                    "3 - RETIRAR CLIENTES NA FILA\n" +
                    "0 - SAIR\n" +
                    "*************************************************************\n" +
                    "Entre com a Opção desejada :\n");

                seletor = Convert.ToInt32(Console.ReadLine());

                switch (seletor)
                {
                    case 1:
                        Console.WriteLine("\nInforme o nome Do Cliente\n");
                        queue.Enqueue(Console.ReadLine());
                        Console.WriteLine("\nCliente Adicionado\n");
                        break;
                    case 2:
                        Console.WriteLine("\nLista de Clientes \n");
                        foreach (String s in queue) Console.WriteLine(s);
                        break;
                    case 3:
                        if (queue.Count != 0)
                        {
                            Console.WriteLine("\nCliente foi removido\n");
                            queue.Dequeue();
                        }
                        else
                            Console.WriteLine("A Fila esta Vazia");
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