using ModeloLoja.Scripts;
using ModeloLoja.Config;
using ModeloLoja.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloLoja.Products
{
    public partial class ProdutoEdit : UserControl
    {
        public Produto produto;
        private string resourcesPath = MainConfig.resourcesPath;

        public ProdutoEdit(Produto _produto)
        {
            InitializeComponent();
            produto = _produto;
        }

        private void txtNomeProdutoEdit_Leave(object sender, EventArgs e)
        {
            produto.nome = txtNomeProdutoEdit.Text;
        }
        private void txtDescProdutoEdit_Leave(object sender, EventArgs e)
        {
            produto.descricao = txtDescProdutoEdit.Text;
        }
        private void txtPrecoProdutoEdit_Leave(object sender, EventArgs e)
        {
            try
            {
                produto.preco = double.Parse(txtPrecoProdutoEdit.Text);
                txtPrecoProdutoEdit.Text = produto.preco.ToString("R$ #.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deve ser introduzido um valor\n"+ex.Message);
            }
        }

        private void ProdutoEdit_Load(object sender, EventArgs e)
        {
            txtNomeProdutoEdit.TabIndex = 1;
            txtDescProdutoEdit.TabIndex = 2;
            txtPrecoProdutoEdit.TabIndex = 3;
            txtNomeProdutoEdit.Text = produto.nome;
            txtDescProdutoEdit.Text = produto.descricao;
            textBox1.Text = "Estoque: " + produto.quantidade.ToString();
            txtPrecoProdutoEdit.Text = produto.preco.ToString("R$ #.00");
            if (produto.imgPath != null && produto.imgPath != "")
            {
                picProdutoEdit.BackgroundImage = Image.FromFile(resourcesPath+produto.imgPath);
            }
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            Database.EditarProduto(produto);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Database.ExcluirProduto(produto);
            this.DestroyHandle();
        }

        private void btnAddPicProduto_Click(object sender, EventArgs e)
        {
            OpenFileDialog newPic = new OpenFileDialog();
            newPic.InitialDirectory = resourcesPath;
            newPic.Filter = "Jpeg files (*.jpeg)|*.jpeg";
            newPic.DefaultExt = ".jpeg";
            if (newPic.ShowDialog() == DialogResult.OK)
            {
                if (newPic.FileName.StartsWith(resourcesPath))
                {
                    produto.imgPath = newPic.FileName.Remove(0,resourcesPath.Length);
                    picProdutoEdit.BackgroundImage = Image.FromFile(newPic.FileName);
                }
                else
                {
                    MessageBox.Show("A imagem tem que estar no diretório: " + resourcesPath);
                }
            }
        }

        private void txtPrecoProdutoEdit_Enter(object sender, EventArgs e)
        {
            txtPrecoProdutoEdit.Text = produto.preco.ToString();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = produto.quantidade.ToString();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                produto.quantidade = int.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deve ser introduzido um valor inteiro\n" + ex.Message);
            }
            textBox1.Text = "Estoque: " + produto.quantidade.ToString();
        }
    }
}
