using ModeloLoja.Scripts;
using ModeloLoja.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloLoja.Products
{
    public partial class ProdutoView : UserControl
    {
        public Produto produto;
        public ProdutoView(Produto _produto)
        {
            InitializeComponent();
            produto = _produto;
        }

        private void btnComprarProduto_Click(object sender, EventArgs e)
        {
            if (Database.usuarioLogado.Money < produto.preco)
            {
                MessageBox.Show("Saldo insuficiente para comprar esse produto");
                return;
            }
            else
            {
                Database.usuarioLogado.Money -= produto.preco;
                produto.quantidade -= 1;
                Database.EditarProduto(produto);
                Database.EditarUsuario(Database.usuarioLogado);
                ProdutoView_Load(sender, e);
            }
        }

        private void ProdutoView_Load(object sender, EventArgs e)
        {
            lblNomeProduto.Text = produto.nome;
            lblDescricaoProduto.Text = produto.descricao;
            lblEstoque.Text = "Estoque: " + produto.quantidade;
            lblPrecoProduto.Text = produto.preco.ToString("R$ #.00");
        }
    }
}
