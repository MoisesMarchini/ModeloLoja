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

namespace ModeloLoja
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            Database.ImportDatabase();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            MainConfig.SetDefaultSize(this, MainConfig.LoginFormSize);
        }

        private void btnViewPass_MouseEnter(object sender, EventArgs e)
        {
            txtBoxUserPass.UseSystemPasswordChar = false;
        }

        private void btnViewPass_MouseLeave(object sender, EventArgs e)
        {
            txtBoxUserPass.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Database.Logar(new Usuario(txtBoxUserName.Text, txtBoxUserPass.Text)))
            {
                MessageBox.Show("Logado ao servidor como "+ Database.usuarioLogado.Name);
                PaginaClient p = new PaginaClient(this);
                p.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FormNewUser cadastro = new FormNewUser();
            cadastro.formLogin = this;
            cadastro.ShowDialog();
        }
    }
}
