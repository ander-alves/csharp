namespace Pesquisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, esporte;
            string nome, continua = "S";
            Console.WriteLine("Hello, World!");

            do
            {
                Console.WriteLine("Digite o nome");
                nome = Console.ReadLine();
                
                Console.WriteLine("Digite a idade");
                idade  = Convert.ToInt32( Console.ReadLine());
                do
                {
                    Console.WriteLine("Digite o esporte a favorito (1-Futebol/2-Volei/3-Basquete/4-Outros)");
                    esporte = Convert.ToInt32(Console.ReadLine());
                } while (esporte < 1 || esporte > 4);

                Console.WriteLine("deseja Continuar ? S ou N");
                continua = Console.ReadLine().ToLower();
            } while (continua.Equals("S"));
        }
    }
}