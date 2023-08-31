namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero, numero2;

            Console.WriteLine("Digite o primeiro número:");
            numero = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"{numero} + {numero2} = " + Somar(numero, numero2));
            Console.WriteLine($"{numero} - {numero2} = " + Subtrair(numero, numero2));
            Console.WriteLine($"{numero} * {numero2} = " + Multiplicar(numero, numero2));
            Console.WriteLine($"{numero} / {numero2} = " + Dividir(numero, numero2));
            Console.WriteLine($"{numero} ^ {numero2} = " + Potencia(numero, numero2));
            Console.WriteLine($"Raiz quadrada de {numero} = " + Raiz(numero));


        }

        private static float Raiz(float numero)
        {
            return (float)Math.Sqrt(numero);
        }

        private static float Potencia(float numero, float numero2)
        {
            return (float)Math.Pow(numero, numero2);
        }

        private static float Dividir(float numero, float numero2)
        {
            if (numero2 == 0)
            {
                Console.WriteLine("Nao Existe divisao por 0");
            }
            return numero / numero2;
        }

        private static float Multiplicar(float numero, float numero2)
        {
            return numero * numero2;
        }

        private static float Somar(float argumento, float dados2)
        {
            return argumento + dados2;
        }
        private static float Subtrair(float numero, float numero2)
        {
            return numero - numero2;
        }

    }
}