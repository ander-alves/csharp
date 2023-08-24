namespace Lista1Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Insira um Numero Inteiro");
            numero = Convert.ToInt32(Console.ReadLine());
            
            if (numero%2 == 0)
            {
                Console.Write("O Numero " +  numero + " é Par e ");
            } else
            {
                Console.Write("O Numero " +  numero + " é Impar e ");
            }
            if (numero > 0)
            {
                Console.Write("Positivo");
            } else if (numero < 0){
                Console.Write("Negativo.");
            } else
            {
                Console.Write("é número é zero.");
            }
        }
    }
}