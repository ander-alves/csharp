using Atividade01Poo.Model;

namespace Atividade01Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Instanciando abaixo 01 Clientes");

            Cliente cliente01 = new Cliente("Cliente 01", 25, "Endereço SP", "11-6580-9847", "cliente1@atividadegen.com.br");
            Cliente cliente02 = new Cliente("Cliente 02", 18, "Endereço RJ", "11-9980-9247", "cliente2@atividadegen.com.br");

            Console.WriteLine("Informações do Cliente 1:");
            cliente01.Visualizar();

            Console.WriteLine("Informações do Cliente 2:");
            cliente02.Visualizar();
            */
            PessoaFisica pessoa01 = new PessoaFisica("pessoa Fisica", 33, "endereço", "5135154843", "aqui tem email", "cpf aqui ");
            pessoa01.Visualizar();

            Console.WriteLine();

            PessoaJuridica juridica01 = new PessoaJuridica("pessoa Juridica", 05, "endereço juridico ", "5135154843", "aqui tem email", "cnpj aqui ");
            juridica01.Visualizar();
        }
    }
}