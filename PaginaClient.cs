using ModeloLoja.Config;
using ModeloLoja.Products;
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

namespace ModeloLoja
{
    public partial class PaginaClient : Form
    {
        public Form formLogin;

        public PaginaClient(Form formlogin)
        {
            formLogin = formlogin;
            InitializeComponent();
        }

        private void PaginaClient_Load(object sender, EventArgs e)
        {
            formLogin.Hide();
            if (Database.usuarioLogado.administrador)
            {
                Text = "Início (Modo Administrador)";
                for (int i = 0; i < Database.dataTableProdutos.Rows.Count; i++)
                {
                    AddAdminControl(i);
                }
                panel1.Controls.Add(new NewProduct(panel1));
            }
            else
            {
                Text = "Início";
                for (int i = 0; i < Database.dataTableProdutos.Rows.Count; i++)
                {
                    AddClientControl(i);
                }
            }
            lblUsername.Text = "Usuário: "+ Database.usuarioLogado.Name;
            lblSaldo.Text = "Saldo: " + Database.usuarioLogado.Money.ToString("R$ #.00");
        }

        private void AddAdminControl(int i)
        {
            Produto p = new Produto((int)Database.dataTableProdutos.Rows[i].ItemArray[0]);
            panel1.Controls.Add(new ProdutoEdit(p));
        }
        private void AddClientControl(int i)
        {
            Produto p = new Produto((int)Database.dataTableProdutos.Rows[i].ItemArray[0]);
            panel1.Controls.Add(new ProdutoView(p));
        }

        private void PaginaClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            formLogin.Show();
        }

        private void panel1_ControlAdded(object sender, ControlEventArgs e)
        {
            panel1RearrangeControls();
        }
        private void panel1RearrangeControls()
        {
            int i = 0;
            panel1.Size = new Size(477, 348);
            foreach (var item in panel1.Controls)
            {
                Control control = panel1.Controls[i];
                control.Enabled = true;
                control.SetBounds(13, 3 + i * 90, control.Width, control.Height);
                i++;
            }
        }
    }
}
