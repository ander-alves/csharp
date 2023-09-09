using RevisãoPoo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisãoPoo.Repository
{
    public interface IProdutoRepository
    {
        //Metodos Crud
        public void CriarProduto(Produto produto);
        public void ListarTodos();
        public void BuscarPorId(int id);
        public void AtualizarProduto(Produto produto);
        public void Deletar(int id);
    }
}
