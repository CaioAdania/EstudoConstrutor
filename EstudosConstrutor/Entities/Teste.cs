using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosConstrutor.Entities
{
    internal class Teste
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        /*public Teste()
        {
                    quando queremos uma sobrecarga vazia, optamos por isso
        }*/

        public Teste(string nome, double preco,int quantidade) //construtor
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Teste(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5; /*Neste caso, não existe necessidade de colocar Quantidade = 0, pois por padrão
                             Quantidade ja recebe seu valor 0 caso não seja declarado*/
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
