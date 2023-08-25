namespace Lista3DoWhileEx05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0 , numero;


            do
            {
                Console.WriteLine("escreva um numero Inteiro");
                numero = Convert.ToInt32(Console.ReadLine());
                
                if (numero >=0)
                {
                    soma = soma + numero;
                }

            } while (numero != 0);
           
            Console.WriteLine($"A soma dos números positivos é {soma}");

        }
    }
}