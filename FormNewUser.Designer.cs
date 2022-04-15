
namespace ModeloLoja
{
    partial class FormNewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnViewPass = new System.Windows.Forms.Button();
            this.txtBoxUserPass = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.txtBoxUserPass2 = new System.Windows.Forms.TextBox();
            this.lblUserPassword2 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewPass
            // 
            this.btnViewPass.Location = new System.Drawing.Point(271, 58);
            this.btnViewPass.Name = "btnViewPass";
            this.btnViewPass.Size = new System.Drawing.Size(24, 20);
            this.btnViewPass.TabIndex = 13;
            this.btnViewPass.Text = "?";
            this.btnViewPass.UseVisualStyleBackColor = true;
            this.btnViewPass.MouseEnter += new System.EventHandler(this.btnViewPass_MouseEnter);
            this.btnViewPass.MouseLeave += new System.EventHandler(this.btnViewPass_MouseLeave);
            // 
            // txtBoxUserPass
            // 
            this.txtBoxUserPass.Location = new System.Drawing.Point(98, 57);
            this.txtBoxUserPass.MaxLength = 16;
            this.txtBoxUserPass.Name = "txtBoxUserPass";
            this.txtBoxUserPass.Size = new System.Drawing.Size(167, 20);
            this.txtBoxUserPass.TabIndex = 12;
            this.txtBoxUserPass.UseSystemPasswordChar = true;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.Location = new System.Drawing.Point(41, 55);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(50, 23);
            this.lblUserPassword.TabIndex = 11;
            this.lblUserPassword.Text = "Senha";
            this.lblUserPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(41, 29);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(50, 23);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "Usuário";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(97, 32);
            this.txtBoxUserName.MaxLength = 16;
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(198, 20);
            this.txtBoxUserName.TabIndex = 9;
            // 
            // txtBoxUserPass2
            // 
            this.txtBoxUserPass2.Location = new System.Drawing.Point(98, 83);
            this.txtBoxUserPass2.MaxLength = 16;
            this.txtBoxUserPass2.Name = "txtBoxUserPass2";
            this.txtBoxUserPass2.Size = new System.Drawing.Size(167, 20);
            this.txtBoxUserPass2.TabIndex = 15;
            this.txtBoxUserPass2.UseSystemPasswordChar = true;
            // 
            // lblUserPassword2
            // 
            this.lblUserPassword2.Location = new System.Drawing.Point(15, 81);
            this.lblUserPassword2.Name = "lblUserPassword2";
            this.lblUserPassword2.Size = new System.Drawing.Size(76, 23);
            this.lblUserPassword2.TabIndex = 14;
            this.lblUserPassword2.Text = "Repetir Senha";
            this.lblUserPassword2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(128, 129);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(128, 186);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 221);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtBoxUserPass2);
            this.Controls.Add(this.lblUserPassword2);
            this.Controls.Add(this.btnViewPass);
            this.Controls.Add(this.txtBoxUserPass);
            this.Controls.Add(this.lblUserPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtBoxUserName);
            this.MaximizeBox = false;
            this.Name = "FormNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Usuário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewUser_FormClosing);
            this.Load += new System.EventHandler(this.FormNewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewPass;
        private System.Windows.Forms.TextBox txtBoxUserPass;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.TextBox txtBoxUserPass2;
        private System.Windows.Forms.Label lblUserPassword2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
    }
}