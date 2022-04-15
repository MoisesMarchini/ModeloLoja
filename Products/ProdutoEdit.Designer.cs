
namespace ModeloLoja.Products
{
    partial class ProdutoEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPrecoProdutoEdit = new System.Windows.Forms.TextBox();
            this.txtDescProdutoEdit = new System.Windows.Forms.TextBox();
            this.txtNomeProdutoEdit = new System.Windows.Forms.TextBox();
            this.btnAddPicProduto = new System.Windows.Forms.Button();
            this.picProdutoEdit = new System.Windows.Forms.PictureBox();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutoEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrecoProdutoEdit
            // 
            this.txtPrecoProdutoEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPrecoProdutoEdit.Location = new System.Drawing.Point(377, 13);
            this.txtPrecoProdutoEdit.Name = "txtPrecoProdutoEdit";
            this.txtPrecoProdutoEdit.Size = new System.Drawing.Size(73, 20);
            this.txtPrecoProdutoEdit.TabIndex = 9;
            this.txtPrecoProdutoEdit.Text = "Custo";
            this.txtPrecoProdutoEdit.Leave += new System.EventHandler(this.txtPrecoProdutoEdit_Leave);
            // 
            // txtDescProdutoEdit
            // 
            this.txtDescProdutoEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDescProdutoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescProdutoEdit.Location = new System.Drawing.Point(141, 34);
            this.txtDescProdutoEdit.Multiline = true;
            this.txtDescProdutoEdit.Name = "txtDescProdutoEdit";
            this.txtDescProdutoEdit.Size = new System.Drawing.Size(230, 40);
            this.txtDescProdutoEdit.TabIndex = 8;
            this.txtDescProdutoEdit.Text = "Descrição";
            this.txtDescProdutoEdit.Leave += new System.EventHandler(this.txtDescProdutoEdit_Leave);
            // 
            // txtNomeProdutoEdit
            // 
            this.txtNomeProdutoEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNomeProdutoEdit.Location = new System.Drawing.Point(141, 13);
            this.txtNomeProdutoEdit.Name = "txtNomeProdutoEdit";
            this.txtNomeProdutoEdit.Size = new System.Drawing.Size(230, 20);
            this.txtNomeProdutoEdit.TabIndex = 7;
            this.txtNomeProdutoEdit.Text = "Nome do produto";
            this.txtNomeProdutoEdit.Leave += new System.EventHandler(this.txtNomeProdutoEdit_Leave);
            // 
            // btnAddPicProduto
            // 
            this.btnAddPicProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddPicProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPicProduto.Location = new System.Drawing.Point(10, 13);
            this.btnAddPicProduto.Name = "btnAddPicProduto";
            this.btnAddPicProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddPicProduto.Size = new System.Drawing.Size(22, 61);
            this.btnAddPicProduto.TabIndex = 5;
            this.btnAddPicProduto.Text = "+";
            this.btnAddPicProduto.UseVisualStyleBackColor = true;
            this.btnAddPicProduto.Click += new System.EventHandler(this.btnAddPicProduto_Click);
            // 
            // picProdutoEdit
            // 
            this.picProdutoEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picProdutoEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProdutoEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.picProdutoEdit.Location = new System.Drawing.Point(35, 13);
            this.picProdutoEdit.Name = "picProdutoEdit";
            this.picProdutoEdit.Size = new System.Drawing.Size(102, 61);
            this.picProdutoEdit.TabIndex = 0;
            this.picProdutoEdit.TabStop = false;
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalvarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProduto.Location = new System.Drawing.Point(377, 40);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSalvarProduto.Size = new System.Drawing.Size(73, 40);
            this.btnSalvarProduto.TabIndex = 6;
            this.btnSalvarProduto.Text = "Salvar";
            this.btnSalvarProduto.UseVisualStyleBackColor = true;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(10, 86);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExcluir.Size = new System.Drawing.Size(440, 26);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir Produto";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Estoque";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ProdutoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvarProduto);
            this.Controls.Add(this.txtPrecoProdutoEdit);
            this.Controls.Add(this.txtNomeProdutoEdit);
            this.Controls.Add(this.btnAddPicProduto);
            this.Controls.Add(this.picProdutoEdit);
            this.Controls.Add(this.txtDescProdutoEdit);
            this.Name = "ProdutoEdit";
            this.Size = new System.Drawing.Size(455, 115);
            this.Load += new System.EventHandler(this.ProdutoEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProdutoEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPrecoProdutoEdit;
        private System.Windows.Forms.TextBox txtDescProdutoEdit;
        private System.Windows.Forms.TextBox txtNomeProdutoEdit;
        private System.Windows.Forms.Button btnAddPicProduto;
        private System.Windows.Forms.PictureBox picProdutoEdit;
        private System.Windows.Forms.Button btnSalvarProduto;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox textBox1;
    }
}
