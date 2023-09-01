using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02Poo.Model
{
    public class Vendedor : Funcionario
    {
        private int comissao;
        public Vendedor(string nome, int idade, string cargo, double salario, string departamento,int comissao) : base(nome, idade, cargo, salario, departamento)
        {
            this.comissao = comissao;
        }

        public int GetComissao() {  return comissao; }
        public void SetComissao(int comissao) { this.comissao = comissao; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Porcentagem da Comissão: {comissao}%");
            Console.WriteLine();
        }
    }
}
