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
            if (Database.usuarioLogado.administrador)
            {
                Text = "Início (Modo Administrador)";
                panel1.Controls.Add(new NewProduct(panel1));
                for (int i = 0; i < Database.dataTableProdutos.Rows.Count; i++)
                {
                    AddAdminControl(i);
                }
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
            Produto p = new Produto(Database.dataTableProdutos.Rows[i]);
            panel1.Controls.Add(new ProdutoEdit(p));
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
            panel1.Size = new Size(477, 348);
            foreach (var item in panel1.Controls)
            {
                Control control = panel1.Controls[i];
                control.Enabled = true;
                if (Database.usuarioLogado.administrador)
                {
                    if (i != 0)
                    {
                        control.SetBounds(13, 3 + (i * (control.Height + 10)) - 70, control.Width, control.Height);
                    }
                    else
                    {
                        control.SetBounds(13, 3 + (i * (control.Height + 10)), control.Width, control.Height);
                    }
                }
                else
                {
                    control.SetBounds(13, 3 + (i * (control.Height + 10)), control.Width, control.Height);
                }

                i++;
            }
        }
    }
}
