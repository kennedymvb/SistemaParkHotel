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
            this.label21 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.LblValorUnitarioCompra = new System.Windows.Forms.Label();
            this.btnExibirEntradas = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAdicionarAoLote = new System.Windows.Forms.Button();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQuantidadeEntrada = new System.Windows.Forms.TextBox();
            this.txtValorEntrada = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btnApagarRegistro = new System.Windows.Forms.Button();
            this.lblProdutosLote = new System.Windows.Forms.Label();
            this.dataGridDia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDia)).BeginInit();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(296, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(189, 27);
            this.label21.TabIndex = 81;
            this.label21.Text = "Entrada de Produtos";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(132, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 20);
            this.label15.TabIndex = 107;
            this.label15.Text = "Selecionar Produto";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(136, 100);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(121, 21);
            this.cmbFornecedor.TabIndex = 112;
            // 
            // LblValorUnitarioCompra
            // 
            this.LblValorUnitarioCompra.AutoSize = true;
            this.LblValorUnitarioCompra.BackColor = System.Drawing.Color.Transparent;
            this.LblValorUnitarioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorUnitarioCompra.Location = new System.Drawing.Point(260, 364);
            this.LblValorUnitarioCompra.Name = "LblValorUnitarioCompra";
            this.LblValorUnitarioCompra.Size = new System.Drawing.Size(15, 15);
            this.LblValorUnitarioCompra.TabIndex = 117;
            this.LblValorUnitarioCompra.Text = "0";
            // 
            // btnExibirEntradas
            // 
            this.btnExibirEntradas.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirEntradas.Location = new System.Drawing.Point(340, 397);
            this.btnExibirEntradas.Name = "btnExibirEntradas";
            this.btnExibirEntradas.Size = new System.Drawing.Size(145, 22);
            this.btnExibirEntradas.TabIndex = 119;
            this.btnExibirEntradas.Text = "Exibir Entradas";
            this.btnExibirEntradas.UseVisualStyleBackColor = true;
            this.btnExibirEntradas.Click += new System.EventHandler(this.btnExibirEntradas_Click_1);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(132, 364);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(106, 20);
            this.label37.TabIndex = 116;
            this.label37.Text = "Valor unitário ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(132, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 20);
            this.label12.TabIndex = 109;
            this.label12.Text = "Selecionar Fornecedor";
            // 
            // btnAdicionarAoLote
            // 
            this.btnAdicionarAoLote.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarAoLote.Location = new System.Drawing.Point(136, 396);
            this.btnAdicionarAoLote.Name = "btnAdicionarAoLote";
            this.btnAdicionarAoLote.Size = new System.Drawing.Size(181, 23);
            this.btnAdicionarAoLote.TabIndex = 118;
            this.btnAdicionarAoLote.Text = "Adicionar produto ao lote";
            this.btnAdicionarAoLote.UseVisualStyleBackColor = true;
            this.btnAdicionarAoLote.Click += new System.EventHandler(this.btnAdicionarAoLote_Click_1);
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(136, 174);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(121, 21);
            this.cmbProduto.TabIndex = 111;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(511, 396);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(153, 23);
            this.btnFinalizar.TabIndex = 115;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(132, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 108;
            this.label14.Text = "Quantidade";
            // 
            // txtQuantidadeEntrada
            // 
            this.txtQuantidadeEntrada.Location = new System.Drawing.Point(136, 241);
            this.txtQuantidadeEntrada.Name = "txtQuantidadeEntrada";
            this.txtQuantidadeEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeEntrada.TabIndex = 113;
            this.txtQuantidadeEntrada.TextChanged += new System.EventHandler(this.txtQuantidadeEntrada_TextChanged);
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.Location = new System.Drawing.Point(136, 326);
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtValorEntrada.TabIndex = 114;
            this.txtValorEntrada.TextChanged += new System.EventHandler(this.txtValorEntrada_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(132, 290);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(150, 20);
            this.label29.TabIndex = 110;
            this.label29.Text = "Valor total da Compra";
            // 
            // btnApagarRegistro
            // 
            this.btnApagarRegistro.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarRegistro.Location = new System.Drawing.Point(525, 286);
            this.btnApagarRegistro.Name = "btnApagarRegistro";
            this.btnApagarRegistro.Size = new System.Drawing.Size(107, 22);
            this.btnApagarRegistro.TabIndex = 128;
            this.btnApagarRegistro.Text = "Apagar Registro";
            this.btnApagarRegistro.UseVisualStyleBackColor = true;
            this.btnApagarRegistro.Click += new System.EventHandler(this.btnApagarRegistro_Click);
            // 
            // lblProdutosLote
            // 
            this.lblProdutosLote.AutoSize = true;
            this.lblProdutosLote.BackColor = System.Drawing.Color.Transparent;
            this.lblProdutosLote.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutosLote.Location = new System.Drawing.Point(465, 54);
            this.lblProdutosLote.Name = "lblProdutosLote";
            this.lblProdutosLote.Size = new System.Drawing.Size(111, 20);
            this.lblProdutosLote.TabIndex = 127;
            this.lblProdutosLote.Text = "Produtos do lote";
            // 
            // dataGridDia
            // 
            this.dataGridDia.AllowUserToAddRows = false;
            this.dataGridDia.AllowUserToDeleteRows = false;
            this.dataGridDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDia.Location = new System.Drawing.Point(469, 77);
            this.dataGridDia.Name = "dataGridDia";
            this.dataGridDia.ReadOnly = true;
            this.dataGridDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDia.Size = new System.Drawing.Size(331, 203);
            this.dataGridDia.TabIndex = 126;
            // 
            // FormEntradaProdutosDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApagarRegistro);
            this.Controls.Add(this.lblProdutosLote);
            this.Controls.Add(this.dataGridDia);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.LblValorUnitarioCompra);
            this.Controls.Add(this.btnExibirEntradas);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAdicionarAoLote);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtQuantidadeEntrada);
            this.Controls.Add(this.txtValorEntrada);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label21);
            this.Name = "FormEntradaProdutosDetalhes";
            this.Text = "FormEntradaProdutosDetalhes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label LblValorUnitarioCompra;
        private System.Windows.Forms.Button btnExibirEntradas;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAdicionarAoLote;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtQuantidadeEntrada;
        private System.Windows.Forms.TextBox txtValorEntrada;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnApagarRegistro;
        private System.Windows.Forms.Label lblProdutosLote;
        private System.Windows.Forms.DataGridView dataGridDia;
    }
}