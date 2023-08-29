namespace Lista1CollectionEx01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomesList = new List<string>();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Informe o nome {i}");
                nomesList.Add(Console.ReadLine());
            }
            foreach (var nome in nomesList)
            {
                Console.WriteLine(nome);
            }
            nomesList.Sort();

            Console.WriteLine("Ordenar as cores:\n");
            foreach (var nome in nomesList)
            {
                Console.WriteLine(nome);
            }
        }
    }
}