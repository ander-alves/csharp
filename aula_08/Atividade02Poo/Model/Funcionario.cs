using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02Poo.Model
{
    public class Funcionario
    {
        private string nome;
        private int idade;
        private string cargo;
        private double salario;
        private string departamento;

        public Funcionario(string nome, int idade, string cargo, double salario, string departamento)
        {
            this.nome = nome;
            this.idade = idade;
            this.cargo = cargo;
            this.salario = salario;
            this.departamento = departamento;
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

        public string GetCargo()
        {
            return cargo;
        }

        public void SetCargo(string cargo)
        {
            this.cargo = cargo;
        }

        public double GetSalario()
        {
            return salario;
        }

        public void SetSalario(double salario)
        {
            this.salario = salario;
        }

        public string GetDepartamento()
        {
            return departamento;
        }

        public void SetDepartamento(string departamento)
        {
            this.departamento = departamento;
        }

        public void Visualizar()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Cargo: {cargo}");
            Console.WriteLine($"Salário: {salario:C2}");
            Console.WriteLine($"Departamento: {departamento}");
            Console.WriteLine();
        }
    }
}
