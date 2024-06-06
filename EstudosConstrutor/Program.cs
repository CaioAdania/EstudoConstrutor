using EstudosConstrutor.Entities;
using System.Globalization;

namespace EstudosConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Teste t = new Teste(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + t);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado: ");
            int adcQtde = int.Parse(Console.ReadLine());
            t.AdicionarProdutos(adcQtde);
            Console.WriteLine(t);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido: ");
            int rtrQtde = int.Parse(Console.ReadLine());
            t.RemoverProdutos(rtrQtde);
            Console.WriteLine(t);
        }
    }
}
