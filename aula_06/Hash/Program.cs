namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setNomes = new HashSet<string>()
            {
                "Anderson",
                "Ingrid",
                "String",
                "Anderson",
            };

            foreach (var variavelCriada in setNomes)
            {
                Console.WriteLine(variavelCriada);
            }

            setNomes.Add("Cris");
            setNomes.Add(null);
            setNomes.Add("julia");

            foreach (var variavelCriada in setNomes)
            {
                Console.WriteLine(variavelCriada);
            }

            Console.WriteLine(" O nome Anderson existe ? " + setNomes.Contains("Anderson"));
            setNomes.Remove("String");
            setNomes.Add("Gabriel");

            foreach (var variavelCriada in setNomes)
            {
                Console.WriteLine(variavelCriada);
            }


            //Convertendo a Hash para uma List, para que seja feita uma comparação e ordenada 
            List<string> hashlist = setNomes.ToList();

            hashlist.Sort();
            Console.WriteLine("ordenada");
            foreach (var variavelCriada in hashlist)
            {
                Console.WriteLine(variavelCriada);
            }

        }
    }
}