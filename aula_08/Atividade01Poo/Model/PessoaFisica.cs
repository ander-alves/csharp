using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01Poo.Model
{
    public class PessoaFisica : Cliente
    {
        string cpf;
        public PessoaFisica(string nome, int idade, string endereco, string telefone, string email, string cpf) : base(nome, idade, endereco, telefone, email)
        {
            this.cpf = cpf;
        }

        public string GetCpf() { return cpf; }

        public void SetCpf(string cpf) { this.cpf = cpf; }

        public override void Visualizar() 
        {
            base.Visualizar();
            Console.WriteLine($"CPF: {cpf}");
        }

    }
}
