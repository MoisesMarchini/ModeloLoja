
namespace ModeloLoja.Products
{
    partial class ProdutoView
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
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.lblPrecoProduto = new System.Windows.Forms.Label();
            this.btnComprarProduto = new System.Windows.Forms.Button();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoProduto.Location = new System.Drawing.Point(116, 27);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(253, 40);
            this.lblDescricaoProduto.TabIndex = 1;
            this.lblDescricaoProduto.Text = "Descrição";
            // 
            // lblPrecoProduto
            // 
            this.lblPrecoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoProduto.Location = new System.Drawing.Point(375, 6);
            this.lblPrecoProduto.Name = "lblPrecoProduto";
            this.lblPrecoProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrecoProduto.Size = new System.Drawing.Size(76, 25);
            this.lblPrecoProduto.TabIndex = 4;
            this.lblPrecoProduto.Text = "Preço";
            this.lblPrecoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnComprarProduto
            // 
            this.btnComprarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprarProduto.Location = new System.Drawing.Point(375, 34);
            this.btnComprarProduto.Name = "btnComprarProduto";
            this.btnComprarProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnComprarProduto.Size = new System.Drawing.Size(76, 33);
            this.btnComprarProduto.TabIndex = 3;
            this.btnComprarProduto.Text = "Comprar";
            this.btnComprarProduto.UseVisualStyleBackColor = true;
            this.btnComprarProduto.Click += new System.EventHandler(this.btnComprarProduto_Click);
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(116, 6);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(253, 25);
            this.lblNomeProduto.TabIndex = 2;
            this.lblNomeProduto.Text = "Nome do produto";
            this.lblNomeProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picProduto
            // 
            this.picProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picProduto.Location = new System.Drawing.Point(7, 6);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(102, 61);
            this.picProduto.TabIndex = 0;
            this.picProduto.TabStop = false;
            // 
            // lblEstoque
            // 
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(270, 50);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(99, 17);
            this.lblEstoque.TabIndex = 5;
            this.lblEstoque.Text = "Estoque";
            this.lblEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblDescricaoProduto);
            this.Controls.Add(this.lblPrecoProduto);
            this.Controls.Add(this.btnComprarProduto);
            this.Controls.Add(this.picProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.Name = "ProdutoView";
            this.Size = new System.Drawing.Size(455, 72);
            this.Load += new System.EventHandler(this.ProdutoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.Label lblPrecoProduto;
        private System.Windows.Forms.Button btnComprarProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.PictureBox picProduto;
        private System.Windows.Forms.Label lblEstoque;
    }
}
