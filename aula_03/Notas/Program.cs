namespace Notas
{
    internal class Program
    {
        // If ternario
        static void Main(string[] args)
        {
            float nota1, nota2, media;
            Console.WriteLine("Informe a Nota 1 :");
            nota1 = Convert.ToSingle(Console.ReadLine());  
            Console.WriteLine("Informe a Nota 2 :");
            nota2 = Convert.ToSingle(Console.ReadLine());

            media = (nota1 + nota2) /2 ;
            // simplifica o if, coloca condicao, dpois ? ação de verdade depois : ação de false
            Console.WriteLine(media >= 6 ? "Aprovado" : "Reprovado");
        }
    }
}