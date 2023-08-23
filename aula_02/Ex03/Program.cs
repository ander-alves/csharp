    namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salarioBruto, adicionalNoturno, horasExtras, descontos;

            Console.Write("Digite o Salário Bruto: ");
            salarioBruto = float.Parse(Console.ReadLine());

            Console.Write("Digite o Adicional Noturno: ");
            adicionalNoturno = float.Parse(Console.ReadLine());

            Console.Write("Digite as Horas Extras: ");
            horasExtras = float.Parse(Console.ReadLine());

            Console.Write("Digite os Descontos: ");
            descontos = float.Parse(Console.ReadLine());

            float salarioLiquido = salarioBruto + adicionalNoturno + (horasExtras * 5) - descontos;

            Console.WriteLine($"O Salário Líquido é: {salarioLiquido:C}");
        }
    }
}