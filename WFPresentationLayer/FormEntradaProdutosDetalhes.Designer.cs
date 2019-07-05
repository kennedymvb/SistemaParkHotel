namespace WFPresentationLayer
{
    partial class FormEntradaProdutosDetalhes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntradaProdutosDetalhes));
            this.btnAdicionarAoLote = new System.Windows.Forms.Button();
            this.LblValorUnitarioCompra = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.btnCadastrarEntrada = new System.Windows.Forms.Button();
            this.txtValorEntrada = new System.Windows.Forms.TextBox();
            this.txtQuantidadeEntrada = new System.Windows.Forms.TextBox();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdicionarAoLote
            // 
            this.btnAdicionarAoLote.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarAoLote.Location = new System.Drawing.Point(186, 341);
            this.btnAdicionarAoLote.Name = "btnAdicionarAoLote";
            this.btnAdicionarAoLote.Size = new System.Drawing.Size(181, 23);
            this.btnAdicionarAoLote.TabIndex = 96;
            this.btnAdicionarAoLote.Text = "Adicionar produto ao lote";
            this.btnAdicionarAoLote.UseVisualStyleBackColor = true;
            this.btnAdicionarAoLote.Click += new System.EventHandler(this.btnAdicionarAoLote_Click);
            // 
            // LblValorUnitarioCompra
            // 
            this.LblValorUnitarioCompra.AutoSize = true;
            this.LblValorUnitarioCompra.BackColor = System.Drawing.Color.Transparent;
            this.LblValorUnitarioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorUnitarioCompra.Location = new System.Drawing.Point(369, 277);
            this.LblValorUnitarioCompra.Name = "LblValorUnitarioCompra";
            this.LblValorUnitarioCompra.Size = new System.Drawing.Size(15, 15);
            this.LblValorUnitarioCompra.TabIndex = 95;
            this.LblValorUnitarioCompra.Text = "0";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(218, 276);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(106, 20);
            this.label37.TabIndex = 94;
            this.label37.Text = "Valor unitário ";
            // 
            // btnCadastrarEntrada
            // 
            this.btnCadastrarEntrada.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEntrada.Location = new System.Drawing.Point(393, 341);
            this.btnCadastrarEntrada.Name = "btnCadastrarEntrada";
            this.btnCadastrarEntrada.Size = new System.Drawing.Size(153, 23);
            this.btnCadastrarEntrada.TabIndex = 92;
            this.btnCadastrarEntrada.Text = "Finalizar";
            this.btnCadastrarEntrada.UseVisualStyleBackColor = true;
            this.btnCadastrarEntrada.Click += new System.EventHandler(this.btnCadastrarEntrada_Click_1);
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.Location = new System.Drawing.Point(362, 234);
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtValorEntrada.TabIndex = 91;
            // 
            // txtQuantidadeEntrada
            // 
            this.txtQuantidadeEntrada.Location = new System.Drawing.Point(293, 197);
            this.txtQuantidadeEntrada.Name = "txtQuantidadeEntrada";
            this.txtQuantidadeEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeEntrada.TabIndex = 90;
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(364, 161);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(121, 21);
            this.cmbFornecedor.TabIndex = 89;
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(344, 122);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(121, 21);
            this.cmbProduto.TabIndex = 88;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(206, 234);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(150, 20);
            this.label29.TabIndex = 87;
            this.label29.Text = "Valor total da Compra";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(208, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 20);
            this.label12.TabIndex = 84;
            this.label12.Text = "Selecionar Fornecedor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(201, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 83;
            this.label14.Text = "Quantidade";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(208, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 20);
            this.label15.TabIndex = 82;
            this.label15.Text = "Selecionar Produto";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(276, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(189, 27);
            this.label21.TabIndex = 81;
            this.label21.Text = "Entrada de Produtos";
            // 
            // FormEntradaProdutosDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdicionarAoLote);
            this.Controls.Add(this.LblValorUnitarioCompra);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.btnCadastrarEntrada);
            this.Controls.Add(this.txtValorEntrada);
            this.Controls.Add(this.txtQuantidadeEntrada);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label21);
            this.Name = "FormEntradaProdutosDetalhes";
            this.Text = "FormEntradaProdutosDetalhes";
            this.Load += new System.EventHandler(this.FormEntradaProdutosDetalhes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarAoLote;
        private System.Windows.Forms.Label LblValorUnitarioCompra;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btnCadastrarEntrada;
        private System.Windows.Forms.TextBox txtValorEntrada;
        private System.Windows.Forms.TextBox txtQuantidadeEntrada;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
    }
}