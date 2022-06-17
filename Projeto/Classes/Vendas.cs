using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Classes
{
    class Vendas
    {
        public string Id { get; set; }
        public string Cliente { get; set; }
        public string Endereco { get; set; }

        public List<Produtos> Produtos = new List<Produtos>();

        public List<Produtos> getListaProdutos()
        {
            return this.Produtos;
        }

        public void setProduto(Produtos produto)
        {
            this.Produtos.Add(produto);
        }
    }
}
