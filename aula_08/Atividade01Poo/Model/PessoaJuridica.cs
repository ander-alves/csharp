using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01Poo.Model
{
    public class PessoaJuridica : Cliente
    {
        private string cnpj;
        public PessoaJuridica(string nome, int idade, string endereco, string telefone, string email, string cnpj) : base(nome, idade, endereco, telefone, email)
        {
            this.cnpj = cnpj;
        }

        public string GetCnpj() { return cnpj; }

        public void SetCnpj(string cnpj) { this.cnpj = cnpj; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"CNPJ: {cnpj}");
        }
    }
}
