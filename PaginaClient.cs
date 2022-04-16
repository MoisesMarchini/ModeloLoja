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
            MainConfig.SetDefaultSize(this, MainConfig.DefaultLayoutSize);
            LoadProducts();
            lblUsername.Text = "Usuário: "+ Database.usuarioLogado.Name;
            lblSaldo.Text = "Saldo: " + Database.usuarioLogado.Money.ToString("R$ #.00");
        }

        private void AddAdminControl(int i)
        {
            Produto p = new Produto(Database.dataTableProdutos.Rows[i]);
            panel1.Controls.Add(new ProdutoEdit(p, panel1));
        }
        private void AddClientControl(int i)
        {
            Produto p = new Produto(Database.dataTableProdutos.Rows[i]);
            panel1.Controls.Add(new ProdutoView(p, lblSaldo));
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
            panel1.ScrollControlIntoView(panel1.Controls[0]);
            foreach (Control control in panel1.Controls)
            {
                control.Enabled = true;

                int multiplier = (i * control.Height + 10);
                if (Database.usuarioLogado.administrador)
                {
                    if (i != 0)
                    {
                        multiplier = (i * control.Height + 10) - 70;
                    }
                }

                control.SetBounds(13, 3 + (multiplier), control.Width, control.Height);

                i++;
            }
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minhasComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LoadProducts()
        {
            bool admin = Database.usuarioLogado.administrador;
            Text = admin? "Início (Modo Administrador)" : "Início";
            if (admin)
            {
                panel1.Controls.Add(new NewProduct(panel1));
                minhasComprasToolStripMenuItem.Visible = false;
                toolStripSeparator1.Visible = false;
                for (int i = 0; i < Database.dataTableProdutos.Rows.Count; i++)
                {
                    AddAdminControl(i);
                }
            }
            else
            {
                minhasComprasToolStripMenuItem.Visible = true;
                toolStripSeparator1.Visible = true;
                for (int i = 0; i < Database.dataTableProdutos.Rows.Count; i++)
                {
                    AddClientControl(i);
                }
            }
        }
    }
}
