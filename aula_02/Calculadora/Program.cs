namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1,numero2;
            string operador;

            Console.WriteLine("Digite o Valor do Numero 1 ");
            numero1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("O valor inteiro digitado foi: " + numero1);

            Console.WriteLine("Digite o Valor do Numero 2 ");
            numero2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("O valor inteiro digitado foi: " + numero2);

            Console.WriteLine($"{numero1} + {numero2} = " + (numero1 + numero2));
            Console.WriteLine($"{numero1} - {numero2} = " + (numero1 - numero2));
            Console.WriteLine($"{numero1} * {numero2} = " + (numero1 * numero2));
            Console.WriteLine($"{numero1} / {numero2} = " + (numero1 / numero2));
        }
    }
}