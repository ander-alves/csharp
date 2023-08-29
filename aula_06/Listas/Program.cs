namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();

            notas.Add(7.5);
            notas.Add(5.0);
            notas.Add(4.0);
            notas.Add(7.0);
            notas.Add(10.0);

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            Console.WriteLine("Posição de nota 4.0 é = " + notas.IndexOf(4.0));

            Console.WriteLine("A nota 4.0 Existe ? " + notas.Contains(4.0));
            
            Console.WriteLine("-------------PARA REMOVER O 4.0--------");
            notas.Remove(4.0);
            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            Console.WriteLine("-----------PARA ORDENAR EM SORT----------");
            notas.Sort();
            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            Console.WriteLine("------------PARA ORDENAR EM REVERSE---------");
            notas.Reverse();
            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }
        }
    }
}