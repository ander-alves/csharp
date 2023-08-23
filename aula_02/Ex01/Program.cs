namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario,abono,novoSalario;

            Console.WriteLine("Digite o Salario");
            salario = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("O Valor do salario é " + salario);
            Console.WriteLine("Informe o Valor Do Abono");
            abono = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("O Valor do Abono é " + abono);
            novoSalario = salario + abono;
            Console.WriteLine("Informe o Valor Do Abono");
            Console.WriteLine(novoSalario);


        }
    }
}