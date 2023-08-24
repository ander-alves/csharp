namespace Lista2Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome,nomeCargo;
            int cargo;
            float salario, novoSalario;

            Console.Write("Informe o Seu Nome : ");
            nome = Console.ReadLine();
            Console.Write("Informe o Codigo do Cargo: ");
            cargo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o Salario: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    novoSalario = salario * 1.1f;
                    nomeCargo = "Gerente";
                    break; 
                case 2:
                    novoSalario = salario * 1.07f;
                    nomeCargo = "Vendedor";
                    break;   
                case 3:
                    novoSalario = salario * 1.09f;
                    nomeCargo = "Supervisor";
                    break;      
                case 4:
                    novoSalario = salario * 1.06f;
                    nomeCargo = "Motorista";
                    break;  
                case 5:
                    novoSalario = salario * 1.05f;
                    nomeCargo = "Estoquista";
                    break;   
                case 6:
                    novoSalario = salario * 1.08f;
                    nomeCargo = "Tecnico de TI";
                    break;
                default:
                    Console.WriteLine("Código de cargo inválido.");
                    return;
            }
            Console.WriteLine($"Nome do Colaborador: {nome}");
            Console.WriteLine($"Cargo: {nomeCargo}");
            Console.WriteLine($"Novo Salario: {novoSalario}");

        }
    }
}