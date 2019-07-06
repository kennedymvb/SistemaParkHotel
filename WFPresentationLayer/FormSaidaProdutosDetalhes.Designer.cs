namespace WFPresentationLayer
{
    partial class FormSaidaProdutosDetalhes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaidaProdutosDetalhes));
            this.label21 = new System.Windows.Forms.Label();
            this.btnPesquisarCheckin = new System.Windows.Forms.Button();
            this.txtNumCheckin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnExibirEntradas = new System.Windows.Forms.Button();
            this.btnAdicionarAoLote = new System.Windows.Forms.Button();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQuantidadeEntrada = new System.Windows.Forms.TextBox();
            this.txtValorEntrada = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.dateTimeVenda = new System.Windows.Forms.DateTimePicker();
            this.label36 = new System.Windows.Forms.Label();
            this.dataGridDia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDia)).BeginInit();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(291, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 27);
            this.label21.TabIndex = 81;
            this.label21.Text = "Vendas";
            // 
            // btnPesquisarCheckin
            // 
            this.btnPesquisarCheckin.Location = new System.Drawing.Point(387, 89);
            this.btnPesquisarCheckin.Name = "btnPesquisarCheckin";
            this.btnPesquisarCheckin.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarCheckin.TabIndex = 118;
            this.btnPesquisarCheckin.Text = "Selecionar";
            this.btnPesquisarCheckin.UseVisualStyleBackColor = true;
            this.btnPesquisarCheckin.Click += new System.EventHandler(this.btnPesquisarCheckin_Click);
            // 
            // txtNumCheckin
            // 
            this.txtNumCheckin.Location = new System.Drawing.Point(214, 92);
            this.txtNumCheckin.Name = "txtNumCheckin";
            this.txtNumCheckin.Size = new System.Drawing.Size(118, 20);
            this.txtNumCheckin.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 116;
            this.label2.Text = "Selecionar Cliente";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(208, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 20);
            this.label15.TabIndex = 107;
            this.label15.Text = "Selecionar Produto";
            // 
            // btnExibirEntradas
            // 
            this.btnExibirEntradas.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirEntradas.Location = new System.Drawing.Point(418, 465);
            this.btnExibirEntradas.Name = "btnExibirEntradas";
            this.btnExibirEntradas.Size = new System.Drawing.Size(145, 22);
            this.btnExibirEntradas.TabIndex = 115;
            this.btnExibirEntradas.Text = "Exibir Entradas";
            this.btnExibirEntradas.UseVisualStyleBackColor = true;
            this.btnExibirEntradas.Click += new System.EventHandler(this.btnExibirEntradas_Click_1);
            // 
            // btnAdicionarAoLote
            // 
            this.btnAdicionarAoLote.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarAoLote.Location = new System.Drawing.Point(211, 465);
            this.btnAdicionarAoLote.Name = "btnAdicionarAoLote";
            this.btnAdicionarAoLote.Size = new System.Drawing.Size(181, 23);
            this.btnAdicionarAoLote.TabIndex = 114;
            this.btnAdicionarAoLote.Text = "Adicionar produto ao lote";
            this.btnAdicionarAoLote.UseVisualStyleBackColor = true;
            this.btnAdicionarAoLote.Click += new System.EventHandler(this.btnAdicionarAoLote_Click_1);
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(211, 157);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(121, 21);
            this.cmbProduto.TabIndex = 110;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(593, 464);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(153, 23);
            this.btnFinalizar.TabIndex = 113;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(210, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 108;
            this.label14.Text = "Quantidade";
            // 
            // txtQuantidadeEntrada
            // 
            this.txtQuantidadeEntrada.Location = new System.Drawing.Point(214, 227);
            this.txtQuantidadeEntrada.Name = "txtQuantidadeEntrada";
            this.txtQuantidadeEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeEntrada.TabIndex = 111;
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.Location = new System.Drawing.Point(211, 326);
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtValorEntrada.TabIndex = 112;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(207, 285);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(150, 20);
            this.label29.TabIndex = 109;
            this.label29.Text = "Valor total da Compra";
            // 
            // dateTimeVenda
            // 
            this.dateTimeVenda.Location = new System.Drawing.Point(335, 384);
            this.dateTimeVenda.Name = "dateTimeVenda";
            this.dateTimeVenda.Size = new System.Drawing.Size(123, 20);
            this.dateTimeVenda.TabIndex = 120;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(210, 384);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(105, 20);
            this.label36.TabIndex = 119;
            this.label36.Text = "Data da Venda:";
            // 
            // dataGridDia
            // 
            this.dataGridDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDia.Location = new System.Drawing.Point(673, 121);
            this.dataGridDia.Name = "dataGridDia";
            this.dataGridDia.Size = new System.Drawing.Size(240, 150);
            this.dataGridDia.TabIndex = 121;
            // 
            // FormSaidaProdutosDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 524);
            this.Controls.Add(this.dataGridDia);
            this.Controls.Add(this.dateTimeVenda);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.btnPesquisarCheckin);
            this.Controls.Add(this.txtNumCheckin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnExibirEntradas);
            this.Controls.Add(this.btnAdicionarAoLote);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtQuantidadeEntrada);
            this.Controls.Add(this.txtValorEntrada);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label21);
            this.Name = "FormSaidaProdutosDetalhes";
            this.Text = "FormEntradaProdutosDetalhes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnPesquisarCheckin;
        private System.Windows.Forms.TextBox txtNumCheckin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnExibirEntradas;
        private System.Windows.Forms.Button btnAdicionarAoLote;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtQuantidadeEntrada;
        private System.Windows.Forms.TextBox txtValorEntrada;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DateTimePicker dateTimeVenda;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DataGridView dataGridDia;
    }
}