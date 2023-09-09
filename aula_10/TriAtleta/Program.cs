namespace TriAtleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
           TriAtleta t1 = new TriAtleta("Victor");
            t1.Aquecer();
            t1.Correr();
            t1.Pedalar();
            t1.Nadar();
            t1.Cansou();
        }
    }
}