using System.Diagnostics.CodeAnalysis;

namespace Lista1Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra1, palavra2, palavra3;

            Console.WriteLine("Digite a Primeira palavra");
            palavra1 = Console.ReadLine();
            Console.WriteLine("Digite a Segunda palavra");
            palavra2 = Console.ReadLine();
            Console.WriteLine("Digite a Terceira palavra");
            palavra3 = Console.ReadLine();
           /* Console.WriteLine(palavra1);
            Console.WriteLine(palavra2);
            Console.WriteLine(palavra3);*/

            if (palavra1 !=null && palavra2 !=null && palavra3 !=null) 
            {
                if (palavra1.Equals("vertebrado"))
                {
                    if (palavra2.Equals("ave"))
                    {
                        if (palavra3.Equals("carnivoro"))
                        {
                            Console.WriteLine("Aguia");
                        }
                        else
                        {
                            Console.WriteLine("Pomba");
                        }

                    }
                    else // aqui verifica se é ave 
                    {
                        if (palavra3.Equals("onivoro"))
                        {
                            Console.WriteLine("homem");
                        }
                        else
                        {
                            Console.WriteLine("vaca");
                        }
                    }
                }
                else //se cair aqui é invertebrado//
                {
                    if (palavra2.Equals("inseto"))
                    {
                        if (palavra3.Equals("hematofago"))
                        {
                            Console.WriteLine("pulga");
                        }
                        else
                        {
                            Console.WriteLine("Pomba");
                        }

                    }
                    else // inseto 
                    {
                        if (palavra3.Equals("hematofago"))
                        {
                            Console.WriteLine("sanguessuga");
                        }
                        else
                        {
                            Console.WriteLine("minhoca");
                        }

                    }
                }

            } else
            {
                Console.WriteLine("As palavras nao podem ser nulas ");
            }
        }
    }
}