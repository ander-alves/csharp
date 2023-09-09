using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisãoPoo.Model
{
    public abstract class Produto
    {
        private int id;
        private string nome;
        private int tipo;
        private decimal preco;

        protected Produto(int id, string nome, int tipo, decimal preco)
        {
            this.id = id;
            this.nome = nome;
            this.tipo = tipo;
            this.preco = preco;
        }

        public int getId() { return id; }
        public void setId(int id) { this.id = id; }
        public string getNome() { return nome; }
        public void setNome(string nome) {  this.nome = nome; }
        public int getTipo() { return tipo; }
        public void setTipo(int tipo) { this.tipo = tipo; }
        public decimal getPreco() { return preco; }
        public void setPreco(decimal preco) { this.preco = preco; }


        public virtual void Visualizar()
        {

        }
       
    }
}
