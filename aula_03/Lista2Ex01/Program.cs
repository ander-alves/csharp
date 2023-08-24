namespace Lista2Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int produto, quantidade;
            float valorTotal;
            Console.WriteLine("Informe o Numero do produto");
            produto = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Informe a Quantidade");
            quantidade = (Convert.ToInt32(Console.ReadLine()));


            switch (produto)
            {
                case 1:
                    valorTotal = quantidade * 10;
                    Console.WriteLine("Produto: Cachorro Quente");
                    Console.WriteLine($"Valor total : R$ {valorTotal:F2}");
                    break;
                case 2:
                    valorTotal = quantidade * 15;
                    Console.WriteLine("Produto: X - Salada");
                    Console.WriteLine($"Valor total : R$ {valorTotal:F2}");
                    break;  
                case 3:
                    valorTotal = quantidade * 18;
                    Console.WriteLine("Produto: X - Bacon");
                    Console.WriteLine($"Valor total : R$ {valorTotal:F2}");
                    break;   
                case 4:
                    valorTotal = quantidade * 12;
                    Console.WriteLine("Produto: Bauru");
                    Console.WriteLine($"Valor total : R$ {valorTotal:F2}");
                    break; 
                case 5:
                    valorTotal = quantidade * 08;
                    Console.WriteLine("Produto: Refrigerante");
                    Console.WriteLine($"Valor total : R$ {valorTotal:F2}");
                    break;
                 case 6:
                    valorTotal = quantidade * 13;
                    Console.WriteLine("Produto: Suco de Laranja");
                    Console.WriteLine($"Valor total : R$ {valorTotal:F2}");
                    break;
                default:
                    Console.WriteLine("Código de produto inválido.");
                    return;
            }        
        }
    }
}