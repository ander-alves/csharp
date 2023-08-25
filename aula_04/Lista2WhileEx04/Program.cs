using System.Reflection;

namespace Lista2WhileEx04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, genero, categoria;
            string continua = "S";
            int
                backEnd = 0, mulherFront = 0, homem40Mais = 0, naoBinUnder30 = 0, outros = 0, soma = 0, total = 0;
            float media = 0;

            while (continua == "S")
            {
                Console.WriteLine("Informe a Sua Idade ");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe a Identidade de Gênero (Número Inteiro) \n1 – Mulher Cis\r\n2 – Homem Cis\r\n3 – Não Binário\r\n4 – Mulher Trans\r\n5 – Homem Trans\r\n6 – Outros\r\n");
                genero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pessoa Desenvolvedora (Número Inteiro) 1 – Backend \n2 – Frontend \n3 – Mobile \n4 – FullStack");
                categoria = Convert.ToInt32(Console.ReadLine());

                if (categoria == 1)
                    backEnd++;
                if (genero == 1 || genero == 4 && categoria == 2)
                    mulherFront++;
                if (genero == 2 || genero == 5 && categoria == 3 && idade > 40)
                    homem40Mais++;
                if (genero == 3 && categoria == 4 && idade < 30)
                    naoBinUnder30++;

                total = backEnd + mulherFront + homem40Mais + naoBinUnder30 + outros;
                soma = soma + idade;
                media = soma / total;
                Console.WriteLine("Deseja Continuar ? ");
                continua = Console.ReadLine().ToUpper();
            }

            Console.WriteLine($"Total de pessoas desenvolvedoras Backend : {backEnd}");
            Console.WriteLine($"Total de Mulheres Cis e Trans desenvolvedoras Frontend : {mulherFront}");
            Console.WriteLine($"Total de Homens Cis e Trans desenvolvedores Mobile maiores de 40 anos : {homem40Mais}");
            Console.WriteLine($"Total de Pessoas Não Binárias desenvolvedoras FullStack menores de 30 anos : {naoBinUnder30}");
            Console.WriteLine($"O número total de pessoas que responderam à pesquisa : {total}");
            Console.WriteLine($"A média de idade das pessoas que responderam à pesquisa : {media}");

        }
    }
}