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
            var buscaProduto = BuscarNaCollection(produto.Id);

            if (buscaProduto is not null)
            {
                var index = listaProdutos.IndexOf(buscaProduto);

                listaProdutos[index] = produto;

                Console.WriteLine($"O Produto numero {produto.Id} foi atualizado com sucesso!");
            }
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
            listaProdutos.Add(produto);
            Console.WriteLine($"Produto: {produto.Id}, foi Criado com Sucesso.");
        }

        public void Deletar(int id)
        {
            var produto = BuscarNaCollection(id);

            if (produto != null)
            {
                if (listaProdutos.Remove(produto) == true)
                    Console.WriteLine("\nO Produto foi deletado com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nO Produto não foi encontrado!");
                Console.ResetColor();
            }
        }

        public void ListarTodos()
        {
            foreach (var prod in listaProdutos)
            {
                prod.Visualizar();
            }
        }

        public int GerarId()
        {
            return ++id;
        }

        public Produto? BuscarNaCollection(int id)
        {
            foreach (var prod in listaProdutos)
            {
                if (prod.Id == id)
                    return prod;
            }
            return null;
        }
    }
}
