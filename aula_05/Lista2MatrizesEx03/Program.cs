namespace Lista2MatrizesEx03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int somaDiagonalPrincipal = 0;
            int somaDiagonalSecundaria = 0;


            Console.WriteLine("Elementos da Diagonal Principal:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Elementos da Diagonal Secundária:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(matriz[i, 2 - i] + " ");
            }
            Console.WriteLine("\n");

            for (int i = 0; i < 3; i++)
            {
                somaDiagonalPrincipal += matriz[i, i];
                somaDiagonalSecundaria += matriz[i, 2 - i];
            }

            Console.WriteLine($"Soma da Diagonal Principal: {somaDiagonalPrincipal}");
            Console.WriteLine($"Soma da Diagonal Secundária: {somaDiagonalSecundaria}");
        }
    }
}