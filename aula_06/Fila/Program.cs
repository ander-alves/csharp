namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Hello");
            fila.Enqueue("Breno");
            fila.Enqueue("Julia");
            fila.Enqueue("Leonardo");
            fila.Enqueue("Gaspar");
            fila.Enqueue("Cris");
            fila.Enqueue("Anderson");
            

            foreach (var item in fila) {
                Console.WriteLine(item);
            }

            fila.Enqueue("Gaspar");
            fila.Dequeue();

            Console.WriteLine("---Remove");
            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }

        }       
    }       
}           