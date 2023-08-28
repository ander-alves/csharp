namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] vetor02 = new int[5];
            string[] vetor03 = new string[5];

            /* for (int i = 0; i < 10; i++)
             {
                 Console.WriteLine($"O vetor01 com indice {i} = {vetor01[i]} ");
             }

             for (int i = 0; i < 5; i++)
             {
                 Console.Write($"Informe o Valor do Vetor02 no indice {i} = ");
                 vetor02[i] = Convert.ToInt32(Console.ReadLine());
             }

             for (int i = 0; i < 5; i++)
             {
                 Console.WriteLine($"O vetor02 com indice {i} = {vetor02[i]} ");
             }

             Array.Sort( vetor02 );
             Console.WriteLine("Vetor ordenado Com sort \n");

             for (int i = 0; i < vetor02.Length; i++)
             {
                 Console.WriteLine($"O vetor02 com indice {i} = {vetor02[i]} ");
             }

             Array.Reverse(vetor02);
             Console.WriteLine("Vetor ordenado Com Reverse \n");

             for (int i = 0; i < vetor02.Length; i++)
             {
                 Console.WriteLine($"O vetor02 com indice {i} = {vetor02[i]} ");
             }*/

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Informe o Valor do Vetor03 no indice {i} = ");
                vetor03[i] = Convert.ToString(Console.ReadLine());
            }

            Array.Sort(vetor03);

            for (int i = 0; i < vetor03.Length; i++)
            {
                Console.WriteLine($"O vetor02 com indice {i} = {vetor03[i]} ");
            }

            Console.WriteLine("A posição 02 é igual a  " + Array.IndexOf(vetor03, 02));


        }

    }
}