namespace Lista1LoopEx02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int par =0 , impar=0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Escreva um Numero");
                numero =Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    par++;

                }
                else
                    impar++;
            }
            Console.WriteLine($"Total de números pares {par}");
            Console.WriteLine($"Total de números impar {impar}");
        }
    }
}