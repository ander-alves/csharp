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
                somaDiagonalPrincipal += matriz[i, i];
            }
            Console.WriteLine("\n");

            Console.WriteLine("Elementos da Diagonal Secundária:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i + j == matriz.GetLength(0) - 1)
                    {
                        Console.Write(matriz[i, j] + " ");
                        somaDiagonalSecundaria += matriz[i, 2 - i];
                    }
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine($"Soma da Diagonal Principal: {somaDiagonalPrincipal}");
            Console.WriteLine($"Soma da Diagonal Secundária: {somaDiagonalSecundaria}");
        }
    }
}