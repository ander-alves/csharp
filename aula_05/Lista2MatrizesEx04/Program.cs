namespace Lista2MatrizesEx04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] mediasVetor = new float[10]; // Array para armazenar as médias
            float[,] notas = new float[10, 4]
            {
        { 4.0f, 5.0f, 7.0f, 3.0f },
        { 2.5f, 6.5f, 4.7f, 8.0f },
        { 10.0f, 8.5f, 9.5f, 8.0f },
        { 9.0f, 6.5f, 7.6f, 8.2f },
        { 5.0f, 5.0f, 5.0f, 6.3f },
        { 7.0f, 8.0f, 9.0f, 8.5f },
        { 5.5f, 3.5f, 2.5f, 1.0f },
        { 8.0f, 9.0f, 10.0f, 9.5f },
        { 5.6f, 5.8f, 6.5f, 7.0f },
        { 7.5f, 8.5f, 9.5f, 10.0f }
            };

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                float soma = 0;
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    soma += notas[i, j];
                }
                mediasVetor[i] = soma / notas.GetLength(1); // Calculando a média e armazenando no array
            }
            Console.WriteLine(Convert.ToString(mediasVetor));
        }
    }
}