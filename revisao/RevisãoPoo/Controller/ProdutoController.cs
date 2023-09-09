using RevisãoPoo.Model;
using RevisãoPoo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RevisãoPoo.Controller
{
    public class ProdutoController : IProdutoRepository
    {
        private readonly List<Produto> listaProdutos = new();
        private int id;
        public void AtualizarProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void BuscarPorId(int id)
        {
            var produto = BuscarNaCollection(id);
            if (produto != null)
            {
                produto.Visualizar();
            }
            else
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O Produto com ID: {id}, não Existe");
                Console.ResetColor();
                Console.WriteLine();

        }

        public void CriarProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public void ListarTodos()
        {
            foreach (var prod in listaProdutos)
            {
                prod.Visualizar();
            }
            throw new NotImplementedException();
        }

        public int GerarId()
        {
            return ++id;
        }

        public Produto? BuscarNaCollection(int id)
        {
            foreach (var prod in listaProdutos)
            {
                if (prod.getId() == id)
                    return prod;
            }
            return null;
        }
    }
}
