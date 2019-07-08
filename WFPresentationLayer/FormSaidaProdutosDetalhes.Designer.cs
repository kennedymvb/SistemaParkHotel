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
            this.label15 = new System.Windows.Forms.Label();
            this.btnAdicionarAoLote = new System.Windows.Forms.Button();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQuantidadeProdutos = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.dataGridDia = new System.Windows.Forms.DataGridView();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.lblProdutosLote = new System.Windows.Forms.Label();
            this.btnApagarRegistro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(167, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 35);
            this.label21.TabIndex = 81;
            this.label21.Text = "Vendas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(34, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 14);
            this.label15.TabIndex = 107;
            this.label15.Text = "Selecionar Produto:";
            // 
            // btnAdicionarAoLote
            // 
            this.btnAdicionarAoLote.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarAoLote.Location = new System.Drawing.Point(200, 440);
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
            this.cmbProduto.Location = new System.Drawing.Point(148, 161);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(121, 21);
            this.cmbProduto.TabIndex = 110;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(460, 440);
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
            this.label14.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(70, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 14);
            this.label14.TabIndex = 108;
            this.label14.Text = "Quantidade:";
            // 
            // txtQuantidadeProdutos
            // 
            this.txtQuantidadeProdutos.Location = new System.Drawing.Point(148, 202);
            this.txtQuantidadeProdutos.Name = "txtQuantidadeProdutos";
            this.txtQuantidadeProdutos.Size = new System.Drawing.Size(121, 20);
            this.txtQuantidadeProdutos.TabIndex = 111;
            this.txtQuantidadeProdutos.TextChanged += new System.EventHandler(this.txtQuantidadeProdutos_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(23, 244);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(122, 14);
            this.label29.TabIndex = 109;
            this.label29.Text = "Valor total da Compra:";
            // 
            // dataGridDia
            // 
            this.dataGridDia.AllowUserToAddRows = false;
            this.dataGridDia.AllowUserToDeleteRows = false;
            this.dataGridDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDia.Location = new System.Drawing.Point(628, 80);
            this.dataGridDia.Name = "dataGridDia";
            this.dataGridDia.ReadOnly = true;
            this.dataGridDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDia.Size = new System.Drawing.Size(331, 203);
            this.dataGridDia.TabIndex = 121;
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCompra.Location = new System.Drawing.Point(173, 244);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(18, 19);
            this.lblValorCompra.TabIndex = 122;
            this.lblValorCompra.Text = "0";
            // 
            // lblProdutosLote
            // 
            this.lblProdutosLote.AutoSize = true;
            this.lblProdutosLote.BackColor = System.Drawing.Color.Transparent;
            this.lblProdutosLote.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutosLote.Location = new System.Drawing.Point(624, 57);
            this.lblProdutosLote.Name = "lblProdutosLote";
            this.lblProdutosLote.Size = new System.Drawing.Size(92, 14);
            this.lblProdutosLote.TabIndex = 124;
            this.lblProdutosLote.Text = "Produtos do lote";
            // 
            // btnApagarRegistro
            // 
            this.btnApagarRegistro.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarRegistro.Location = new System.Drawing.Point(684, 289);
            this.btnApagarRegistro.Name = "btnApagarRegistro";
            this.btnApagarRegistro.Size = new System.Drawing.Size(107, 22);
            this.btnApagarRegistro.TabIndex = 125;
            this.btnApagarRegistro.Text = "Apagar Registro";
            this.btnApagarRegistro.UseVisualStyleBackColor = true;
            this.btnApagarRegistro.Click += new System.EventHandler(this.btnApagarRegistro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 133;
            this.pictureBox1.TabStop = false;
            // 
            // FormSaidaProdutosDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(957, 524);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnApagarRegistro);
            this.Controls.Add(this.lblProdutosLote);
            this.Controls.Add(this.lblValorCompra);
            this.Controls.Add(this.dataGridDia);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnAdicionarAoLote);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtQuantidadeProdutos);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSaidaProdutosDetalhes";
            this.Text = "FormEntradaProdutosDetalhes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAdicionarAoLote;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtQuantidadeProdutos;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridView dataGridDia;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Label lblProdutosLote;
        private System.Windows.Forms.Button btnApagarRegistro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}