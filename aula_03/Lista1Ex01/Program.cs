namespace Lista1Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,resultado;

            Console.WriteLine("Insira o Valor de A ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o Valor de B ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o Valor de C ");
            c = Convert.ToInt32(Console.ReadLine());


            resultado = (b + a);

            Console.WriteLine(resultado >= c ? "A Soma de A + B é Maior do que C" : "A Soma de A + B é Menor do que C");
        }
    }
}