namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4;

            Console.Write("Digite o valor de n1: ");
            n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor de n2: ");
            n2 = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor de n3: ");
            n3 = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor de n4: ");
            n4 = float.Parse(Console.ReadLine());

            float diferenca = (n1 * n2) - (n3 * n4);

            Console.WriteLine($"A diferença entre o produto de n1 e n2 pelo produto de n3 e n4 é: {diferenca}");
        }
    }
}