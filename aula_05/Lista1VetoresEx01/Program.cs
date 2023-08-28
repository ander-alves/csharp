namespace Lista1VetoresEx01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int localizar;
            int posicao = 0;
            bool encontrado = false;

            Console.WriteLine("Digite o número que você deseja encontrar: ");
            localizar = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < vetor.Length; i++)
            {
                if (localizar == vetor[i])
                {
                    posicao = i;
                    encontrado = true;
                }
            }

            if (encontrado)
            {
                Console.WriteLine($"O número {localizar} está localizado na posição {posicao}");
            }
            else
            {
                Console.WriteLine($"O número {localizar} não foi encontrado!");
            }

            foreach (int i in vetor)
            {
                if (localizar == i)
                {
                    posicao = Array.IndexOf(vetor, i);
                    encontrado = true;
                    Console.WriteLine($"Encontrado no for each indice {posicao}");
                    break;
                }
            }
            if (!encontrado)

                Console.WriteLine($"O número {localizar} não foi encontrado no foreach!");
        }

    }
}
