namespace Lista1Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            bool primeiraVezDoador = false;

            Console.Write("Informe o Seu Nome : ");
            nome = Console.ReadLine();
            Console.Write("Informe o Sua Idade : ");
            idade =Convert.ToInt32( Console.ReadLine());
            Console.Write("Já Doou Sangue antes ?");
            primeiraVezDoador = Convert.ToBoolean(Console.ReadLine());


            if (idade >= 18 && idade <= 69)
            {
                if (idade >= 60 && idade <= 69 && primeiraVezDoador)
                {
                    Console.WriteLine($"{nome} Não Apto para doar sangue.");
                }
                else
                {
                    Console.WriteLine($"{nome} Está Apto para doar sangue.");
                }
            }
            else
            {
                Console.WriteLine($"{nome} Não Apto para doar sangue.");
            }
        }
    }
}