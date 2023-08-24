namespace Rh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float salarioAtual, novoSalario, reajuste;
            int cargo;
            Console.WriteLine("Informe o seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Olá "+ nome+ " Informe o seu Cargo : ");
            cargo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o seu Salario Atual");
            salarioAtual = Convert.ToSingle(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    reajuste = (salarioAtual * 7) / 100;
                    break;                
                case 2:
                    reajuste = (salarioAtual * 9) / 100;
                    break;                
                case 3:
                    reajuste = (salarioAtual * 5) / 100;
                    break;                
                default :
                    reajuste = (salarioAtual * 12) / 100;
                    break; 
            }
            novoSalario = salarioAtual + reajuste;
            Console.WriteLine("Valor novo");
            Console.WriteLine(novoSalario);
        }
    }
}