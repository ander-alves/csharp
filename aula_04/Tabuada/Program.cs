namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tabuada//
            int tabuada,contador=0;

            Console.WriteLine("Informe Qual Tabuada quer ver");
            tabuada = Convert.ToInt32( Console.ReadLine());

            for (int i = 0; i <=10 ; i++)
            {
                Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
            }

            while(contador <=10)
            {
                Console.WriteLine($"{tabuada} x {contador} = {tabuada * contador}");
                contador++;
            }
        }
    }
}