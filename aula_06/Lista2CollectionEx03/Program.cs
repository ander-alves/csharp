namespace Lista2CollectionEx03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hashListInt = new HashSet<int>();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Informe o Valor de Entrada {i}");

                hashListInt.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("\nForeach Com a Hash \n");
            foreach (int i in hashListInt)
            {
                Console.WriteLine(i);
            }
        }
    }
}