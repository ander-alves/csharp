using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02Poo.Model
{
    internal class Gerente : Funcionario
    {
        private int unidade;
        public Gerente(string nome, int idade, string cargo, double salario, string departamento, int unidade) : base(nome, idade, cargo, salario, departamento)
        {
            this.unidade = unidade;
        }

        public int GetUnidade() { return unidade; }
        public void SetUnidade(int unidade) { this.unidade = unidade; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Numero da Unidade : {unidade}");
            Console.WriteLine();
        }
    }
}
