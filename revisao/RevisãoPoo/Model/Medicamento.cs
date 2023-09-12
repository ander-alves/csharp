using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisãoPoo.Model
{
    public class Medicamento : Produto
    {
        private string Generico { get; set; } = string.Empty;

        public Medicamento(int id, string nome, int tipo, decimal preco, string generico)
            : base(id, nome, tipo, preco)
        {
            Generico = generico;
        }

        public override void Visualizar()   
        {
            base.Visualizar();
            Console.WriteLine($"Nome Generico: " + Generico);
        }
    }
}
