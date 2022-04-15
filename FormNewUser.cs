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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloLoja
{
    public partial class FormNewUser : Form
    {
        public Form formLogin;
        public FormNewUser()
        {
            InitializeComponent();
            Database.ImportDatabase();
        }

        private void FormNewUser_Load(object sender, EventArgs e)
        {
            formLogin.Hide();
            MainConfig.SetDefaultSize(this, MainConfig.LoginFormSize);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtBoxUserName.Text.Length < 5)
            {
                MessageBox.Show("O nome de usuário precisa ter pelo menos 5 caracteres", "Nome de usuário curto");
                return;
            }
            if (txtBoxUserPass.Text.Length < 6)
            {
                MessageBox.Show("A senha precisa ter pelo menos 6 caracteres", "Senha curta");
                return;
            }
            if (txtBoxUserPass.Text != txtBoxUserPass2.Text)
            {
                MessageBox.Show("A confirmação de senha tem que ser igual a senha", "Senha diferente da Confirmação");
                return;
            }
            if (Database.Cadastrar(new Usuario(txtBoxUserName.Text, txtBoxUserPass.Text)))
            {
                MessageBox.Show("Cadastro criado com sucesso");
                Close();
            }
        }

        private void btnViewPass_MouseEnter(object sender, EventArgs e)
        {
            txtBoxUserPass.UseSystemPasswordChar = false;
        }

        private void btnViewPass_MouseLeave(object sender, EventArgs e)
        {
            txtBoxUserPass.UseSystemPasswordChar = true;
        }

        private void FormNewUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            formLogin.Show();
        }
    }
}
