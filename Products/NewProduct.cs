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
    public partial class NewProduct : UserControl
    {
        private Panel productParent;
        public NewProduct(Panel panel)
        {
            InitializeComponent();
            productParent = panel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productParent.Controls.Add(new ProdutoEdit(Database.NovoProduto(),productParent));
        }
    }
}
