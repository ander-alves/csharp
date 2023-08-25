namespace Lista6LoopEx01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            
            Console.WriteLine("Digite o primeiro número do intervalo");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número do intervalo");
            numero2 = int.Parse(Console.ReadLine());


            if(numero1 >= numero2)
            {
                Console.WriteLine("Intervalo inválido. O primeiro número deve ser menor que o segundo.");
                return;
            }
            Console.WriteLine($"Números múltiplos de 3 e 5 entre {numero1} e {numero2}:");

            for (int i = numero1; i <= numero2; i++)
            {
                if(i%3 == 0 && i%5 ==0 )
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}