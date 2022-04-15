using ModeloLoja.Config;
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
        public Label labelSaldo;
        public ProdutoView(Produto _produto, Label _labelSaldo)
        {
            InitializeComponent();
            produto = _produto;
            labelSaldo = _labelSaldo;
        }

        private void btnComprarProduto_Click(object sender, EventArgs e)
        {
            if (produto.quantidade == 0)
            {
                MessageBox.Show("Este produto está em falta");
                return;
            }

            if (Database.usuarioLogado.Money < produto.preco)
            {
                MessageBox.Show("Saldo insuficiente para comprar esse produto");
                return;
            }
            else
            {
                Database.usuarioLogado.Money -= produto.preco;
                produto.quantidade -= 1;
                labelSaldo.Text = "Saldo: " + Database.usuarioLogado.Money.ToString("R$ #.00");
                Database.EditarProduto(produto);
                Database.EditarUsuario(Database.usuarioLogado);
                ProdutoView_Load(sender, e);
            }
        }

        private void ProdutoView_Load(object sender, EventArgs e)
        {
            lblNomeProduto.Text = produto.nome;
            lblDescricaoProduto.Text = produto.descricao;
            lblEstoque.Text = "Estoque: " + produto.quantidade.ToString();
            lblPrecoProduto.Text = produto.preco.ToString("R$ #.00");
            if (produto.imgPath != null && produto.imgPath != "")
            {
                picProduto.BackgroundImage = Image.FromFile(MainConfig.resourcesPath + produto.imgPath);
            }
        }
    }
}
