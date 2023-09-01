namespace Transportes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transporte t1 = new Transporte(5);

            t1.Visualizar();

            Console.WriteLine("");

            Terrestre t2 = new Terrestre(5,10,50);
            t2.Visualizar();

            Automovel auto1 = new Automovel(5,4,100,"preto",4,"Placa : Aqui",5);
            auto1.Visualizar();

        }
    }
}