namespace Lista2WhileEx03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, menor21 = 0 , maior50 = 0;

            Console.WriteLine("Digite uma idade");
            idade = Convert.ToInt32(Console.ReadLine());

            while (idade >=0)
            {
                if (idade < 21)
                {
                    menor21++;
                }
                if (idade > 50)
                {
                    maior50++;
                }
                Console.WriteLine("Digite uma idade");
                idade = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Total de pessoas menores de 21 anos: {menor21}");
            Console.WriteLine($"Total de pessoas Maiores de 50 anos: {maior50}");
            
            
        }
    }
}