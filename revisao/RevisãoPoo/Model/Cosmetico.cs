using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RevisãoPoo.Model
{
    public class Cosmetico : Produto
    {
        private string fragancia;

        public Cosmetico(int id, string nome, int tipo, decimal preco, string fragancia) : base(id, nome, tipo, preco)
        {
            this.fragancia = fragancia;
        }
        public string getFragancia() { return fragancia; }
        public void setFragancia(string fragancia) { this.fragancia = fragancia; }
        public override void Visualizar()
        {
            base.Visualizar();
        }
    }
}
