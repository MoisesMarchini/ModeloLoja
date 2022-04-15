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
    public partial class ProdutoEdit : UserControl
    {
        public Produto produto;
        public ProdutoEdit(Produto _produto)
        {
            InitializeComponent();
            produto = _produto;
        }

        private void lblNomeProdutoEdit_Click(object sender, EventArgs e)
        {
            lblNomeProdutoEdit.Visible = false;
            txtNomeProdutoEdit.Text = lblNomeProdutoEdit.Text;
            txtNomeProdutoEdit.Focus();
        }
        private void txtNomeProdutoEdit_Leave(object sender, EventArgs e)
        {
            lblNomeProdutoEdit.Text = txtNomeProdutoEdit.Text;
            produto.nome = lblNomeProdutoEdit.Text;
            lblNomeProdutoEdit.Visible = true;
        }
        private void lblDescProdutoEdit_Click(object sender, EventArgs e)
        {
            lblDescProdutoEdit.Visible = false;
            txtDescProdutoEdit.Text = lblDescProdutoEdit.Text;
            txtDescProdutoEdit.Focus();
        }
        private void txtDescProdutoEdit_Leave(object sender, EventArgs e)
        {
            lblDescProdutoEdit.Text = txtDescProdutoEdit.Text;
            produto.descricao = lblDescProdutoEdit.Text;
            lblDescProdutoEdit.Visible = true;
        }
        private void lblPrecoProdutoEdit_Click(object sender, EventArgs e)
        {
            lblPrecoProdutoEdit.Visible = false;
            txtPrecoProdutoEdit.Text = lblPrecoProdutoEdit.Text;
            txtPrecoProdutoEdit.Focus();
        }
        private void txtPrecoProdutoEdit_Leave(object sender, EventArgs e)
        {
            try
            {
                produto.preco = int.Parse(txtPrecoProdutoEdit.Text);
                lblPrecoProdutoEdit.Text = produto.preco.ToString("R$ #.00");
            }
            catch (Exception ex)
            {
                produto.preco = 12;
                MessageBox.Show("Deve ser introduzido um valor\n"+ex.Message);
            }
            lblPrecoProdutoEdit.Visible = true;
        }

        private void ProdutoEdit_Load(object sender, EventArgs e)
        {
            lblNomeProdutoEdit.Text = produto.nome;
            lblDescProdutoEdit.Text = produto.descricao;
            lblPrecoProdutoEdit.Text = produto.preco.ToString("R$ #.00");
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            Database.EditarProduto(produto);
        }
    }
}
