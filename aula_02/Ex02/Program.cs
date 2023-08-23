namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4;

            Console.Write("Digite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            nota4 = float.Parse(Console.ReadLine());

            float media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine($"A média final é: {media:F2}");
        }
    }
}