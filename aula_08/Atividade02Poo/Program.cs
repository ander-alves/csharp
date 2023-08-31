using Atividade02Poo.Model;

namespace Atividade02Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instanciando 02 Funcionarios.");
            Funcionario funcionario01 = new Funcionario("Anderson alves", 28, "Desenvolvedor Backend", 5000.00, "TI");
            Funcionario funcionario02 = new Funcionario("Joao", 19, "Designer Ui/Ux", 4000.00, "Design");

            Console.WriteLine("Informações do Funcionário 1:");
            funcionario01.Visualizar();

            Console.WriteLine("Informações do Funcionário 2:");
            funcionario02.Visualizar();
        }
    }
}