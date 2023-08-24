namespace PlanoSaude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If Encadeado
            string? nome;
            int idade;
            float valor;

            Console.WriteLine("Informe o seu nome : ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a sua Idade : ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade > 0 && idade <= 10)
            {
                Console.WriteLine("A Mensalidade é igual a R$ 100,00");
            }
            else if (idade > 10 && idade <= 29)
            {
                Console.WriteLine("A Mensalidade é igual a R$ 200,00");
            } else if (idade > 29 && idade <= 45)
            {
                Console.WriteLine("A Mensalidade é igual a R$ 300,00");
            } else if (idade > 45 && idade <= 59)
            {
                Console.WriteLine("A Mensalidade é igual a R$ 500,00");
            }else if (idade > 59 && idade <= 65)
            {
                Console.WriteLine("A Mensalidade é igual a R$ 600,00");
            }
            else {
                Console.WriteLine("A Mensalidade é igual a R$ 1000,00");
            }

        }
    }
}