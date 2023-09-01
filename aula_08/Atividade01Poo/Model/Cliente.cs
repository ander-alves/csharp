using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01Poo.Model
{
    public class Cliente
    {
        private string nome;
        private int idade;
        private string endereco;
        private string telefone;
        private string email;

        public Cliente(string nome, int idade, string endereco, string telefone, string email)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
            this.telefone = telefone;
            this.email = email;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public string GetEndereco()
        {
            return endereco;
        }

        public void SetEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public string GetTelefone()
        {
            return telefone;
        }

        public void SetTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public virtual void Visualizar()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Endereço: {endereco}");
            Console.WriteLine($"Telefone: {telefone}");
            Console.WriteLine($"Email: {email}");
        }
    }
}
