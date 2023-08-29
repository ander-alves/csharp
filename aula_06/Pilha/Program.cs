namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();

            pilha.Push("Breno");
            pilha.Push("Anderson");
            pilha.Push("julia");
            pilha.Push("gaspar");

            pilha.Pop();


            foreach (var nome in pilha)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("Contens " + pilha.Contains("julia"));
            Console.WriteLine("Contens " + pilha.Contains("gaspar"));

            Console.WriteLine("O ultimo elemento que entrou " + pilha.Peek());


        }
    }
}