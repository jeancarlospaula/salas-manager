using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Projeto.Classes;
using Newtonsoft.Json;
using System.IO;

namespace Projeto
{
    public partial class Form1 : Form
    {
        List<Vendas> listaVendas = new List<Vendas>();
        List<Produtos> listaProdutosTotal = new List<Produtos>();
        Vendas venda = new Vendas();

        public Form1()
        {
            InitializeComponent();
            this.CarregarDadosMemoria();
        }

#region Módulo Vendas
        private void btnSalvarVenda_Click(object sender, EventArgs e)
        {
            Boolean existemCamposVazios = this.verificaCamposVaziosVendas();

            if (existemCamposVazios)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            Vendas venda = this.getFormDataVendas();

            Boolean vendaExistente = listaVendas == null || listaVendas.Count == 0 ? false : this.verificaExistenciaVenda(venda.Id);

            if (vendaExistente)
            {
                MessageBox.Show("Já existe uma venda com identificador " + venda.Id);
                return;
            }

            listaVendas.Add(venda);
            this.limpaCamposForm();

            MessageBox.Show("Venda salva com sucesso!");

            dataGridVendas.DataSource = this.getDataVendas();

            this.SalvarVendasJSON();
        }

        private Vendas getFormDataVendas()
        {
            Vendas venda = new Vendas();

            venda.Id = txtVendaId.Text;
            venda.Cliente = txtVendaCliente.Text;
            venda.Endereco = txtVendaEndereco.Text;

            return venda;
        }

        private DataTable getDataVendas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Cliente");
            dt.Columns.Add("Endereço");

            foreach (Vendas venda in listaVendas)
            {
                dt.Rows.Add(venda.Id, venda.Cliente, venda.Endereco);
            }

            return dt;
        }
        private Boolean verificaExistenciaVenda(string id)
        {
            return listaVendas.Exists(venda => venda.Id == id);
        }

        private Vendas getVendaById(string id)
        {
            return listaVendas.Find(venda => venda.Id == id);
        }

        private Boolean verificaCamposVaziosVendas()
        {
            return String.IsNullOrEmpty(txtVendaId.Text) || String.IsNullOrEmpty(txtVendaCliente.Text) || String.IsNullOrEmpty(txtVendaEndereco.Text);
        }

        private void SalvarVendasJSON()
        {
            string vendasJSON = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

            File.WriteAllText("DB_Vendas.json", vendasJSON);
        }
#endregion

#region Módulo Produtos
        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            Boolean existemCamposVazios = this.verificaCamposVaziosProdutos();

            if (existemCamposVazios)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            Produtos produto = this.getFormDataProdutos();

            Boolean vendaProdutoExistente = verificaExistenciaVenda(produto.VendaId);

            if (!vendaProdutoExistente)
            {
                MessageBox.Show("Não existe nenhuma venda com identificardor " + produto.VendaId);
                return;
            }

            Boolean produtoJaExistente = verificaProdutoEmVenda(produto.VendaId, produto.Id);

            if (produtoJaExistente)
            {
                MessageBox.Show("Já existe um produto com identificador " + produto.Id + " para a venda com identificador " + produto.VendaId);
                return;
            }

            Vendas venda = getVendaById(produto.VendaId);
            venda.setProduto(produto);
            listaProdutosTotal.Add(produto);

            this.limpaCamposForm();

            MessageBox.Show("Produto salvo com sucesso!");

            dataGridProdutos.DataSource = this.getDataProdutos();

            this.SalvarProdutosJSON();
        }

        private Produtos getFormDataProdutos()
        {
            Produtos produto = new Produtos();

            produto.Id = txtProdutoId.Text;
            produto.Nome = txtProdutoNome.Text;
            produto.Descricao = txtProdutoDescricao.Text;
            produto.Quantidade = int.Parse(txtProdutoQuantidade.Text);
            produto.VendaId = txtProdutoVenda.Text;

            return produto;
        }

        private DataTable getDataProdutos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Produto");
            dt.Columns.Add("Quantidade");
            dt.Columns.Add("Descrição");
            dt.Columns.Add("Venda ID");

            foreach (Produtos produto in listaProdutosTotal)
            {
                dt.Rows.Add(produto.Id, produto.Nome, produto.Quantidade, produto.Descricao, produto.VendaId);
            }

            return dt;
        }

        private Boolean verificaProdutoEmVenda(string idVenda, string idProduto)
        {
            Vendas venda = this.getVendaById(idVenda);
            List<Produtos> listaProdutos = venda.getListaProdutos();

            return listaProdutos.Exists(produto => produto.Id == idProduto);
        }

        private Boolean verificaCamposVaziosProdutos()
        {
            return String.IsNullOrEmpty(txtProdutoId.Text) || String.IsNullOrEmpty(txtProdutoNome.Text) || String.IsNullOrEmpty(txtProdutoQuantidade.Text) || String.IsNullOrEmpty(txtProdutoDescricao.Text) || String.IsNullOrEmpty(txtProdutoVenda.Text);
        }

        private void SalvarProdutosJSON()
        {
            string produtosJSON = JsonConvert.SerializeObject(listaProdutosTotal, Formatting.Indented);

            File.WriteAllText("DB_Produtos.json", produtosJSON);
        }
#endregion

        private void limpaCamposForm()
        {
            txtProdutoNome.Text = "";
            txtProdutoQuantidade.Text = "";
            txtProdutoVenda.Text = "";
            txtVendaCliente.Text = "";
            txtProdutoDescricao.Text = "";
            txtVendaEndereco.Text = "";
            txtVendaId.Text = "";
            txtProdutoId.Text = "";
        }

        private void CarregarDadosMemoria()
        {
            if (File.Exists("DB_Vendas.json"))
            {
                string vendasJSON = File.ReadAllText("DB_Vendas.json");
                listaVendas = JsonConvert.DeserializeObject<List<Vendas>>(vendasJSON);

                if(listaVendas != null && listaVendas.Count > 0)
                    dataGridVendas.DataSource = this.getDataVendas();
            }

            if (File.Exists("DB_Produtos.json"))
            {
                string produtosJSON = File.ReadAllText("DB_Produtos.json");
                listaProdutosTotal = JsonConvert.DeserializeObject<List<Produtos>>(produtosJSON);

                if (listaProdutosTotal != null && listaProdutosTotal.Count > 0)
                    dataGridProdutos.DataSource = this.getDataProdutos();
            }

            if(listaVendas != null && listaVendas.Count > 0)
            {
                foreach(Vendas venda in listaVendas)
                {
                    listaProdutosTotal.ForEach(produto =>
                    {
                        if (produto.VendaId == venda.Id)
                        {
                            venda.setProduto(produto);
                        }
                    });
                }
            }
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFinalizarId.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            string vendaId = txtFinalizarId.Text;

            Boolean vendaExistente = this.verificaExistenciaVenda(vendaId);

            if (!vendaExistente)
            {
                MessageBox.Show("Não existe nenhuma venda com identificardor " + vendaId);
                return;
            }

            Vendas venda = this.getVendaById(vendaId);

            List<Produtos> produtosFinalizados = new List<Produtos>();

            listaProdutosTotal.ForEach(produto => { 
                if(produto.VendaId == venda.Id)
                {
                    produtosFinalizados.Add(produto);
                }
            });

            produtosFinalizados.ForEach(produto =>
            {
                listaProdutosTotal.Remove(produto);
            });

            listaVendas.Remove(venda);

            this.SalvarProdutosJSON();
            this.SalvarVendasJSON();

            string produtosFinalizadosJSON = JsonConvert.SerializeObject(produtosFinalizados, Formatting.Indented);
            string JSON = $"{{\"venda\":{{\"Id\":\"{venda.Id}\", \"Cliente\": \"{venda.Cliente}\", \"Endereço\": \"{venda.Endereco}\", \"situação\": \"FINALIZADA\"}}, \"produtos\": {produtosFinalizadosJSON}}}";

            File.WriteAllText("VENDA_" + venda.Id + "_FINALIZADA.json", JSON);

            MessageBox.Show("A venda " + venda.Id + " foi finalizada com sucesso!");

            if(listaProdutosTotal.Count > 0)
            {
                dataGridProdutos.DataSource = this.getDataProdutos();
            }
            else
            {
                dataGridProdutos.DataSource = null;
            }

            if (listaVendas.Count > 0)
            {
                dataGridVendas.DataSource = this.getDataVendas();
            }
            else
            {
                dataGridVendas.DataSource = null;
            }
        }

        private void txtLimparDados_Click(object sender, EventArgs e)
        {
            if (File.Exists("DB_Produtos.json"))
            {
                File.WriteAllText("DB_Produtos.json", "");
            }

            if (File.Exists("DB_Vendas.json"))
            {
                File.WriteAllText("DB_Vendas.json", "");
            }

            MessageBox.Show("Banco de dados reiniciado com sucesso!");

            dataGridProdutos.DataSource = new DataGrid();
            dataGridVendas.DataSource = new DataGrid();

            listaVendas = new List<Vendas>();
            listaProdutosTotal = new List<Produtos>();

            this.limpaCamposForm();
        }
    }
}
