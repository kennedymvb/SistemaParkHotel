namespace WFPresentationLayer
{
    partial class FormProdutos
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
            this.label17 = new System.Windows.Forms.Label();
            this.btnAtualizarProdutos = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.labelValorTotalProdutos = new System.Windows.Forms.Label();
            this.btnCatalogoProdutos = new System.Windows.Forms.Button();
            this.btnCadastroProdutos = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtvalorunitarioproduto = new System.Windows.Forms.TextBox();
            this.txtdescricaoproduto = new System.Windows.Forms.TextBox();
            this.txtnomeproduto = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(25, 238);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(173, 20);
            this.label17.TabIndex = 84;
            this.label17.Text = "Valor unitário de venda: ";
            // 
            // btnAtualizarProdutos
            // 
            this.btnAtualizarProdutos.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarProdutos.Location = new System.Drawing.Point(168, 348);
            this.btnAtualizarProdutos.Name = "btnAtualizarProdutos";
            this.btnAtualizarProdutos.Size = new System.Drawing.Size(132, 23);
            this.btnAtualizarProdutos.TabIndex = 83;
            this.btnAtualizarProdutos.Text = "Atualizar Produto";
            this.btnAtualizarProdutos.UseVisualStyleBackColor = true;
            this.btnAtualizarProdutos.Click += new System.EventHandler(this.btnAtualizarProdutos_Click);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(559, 3);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.Size = new System.Drawing.Size(342, 444);
            this.dataGridViewProdutos.TabIndex = 82;
            this.dataGridViewProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellDoubleClick);
            // 
            // labelValorTotalProdutos
            // 
            this.labelValorTotalProdutos.AutoSize = true;
            this.labelValorTotalProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotalProdutos.Location = new System.Drawing.Point(164, 290);
            this.labelValorTotalProdutos.Name = "labelValorTotalProdutos";
            this.labelValorTotalProdutos.Size = new System.Drawing.Size(18, 20);
            this.labelValorTotalProdutos.TabIndex = 81;
            this.labelValorTotalProdutos.Text = "0";
            // 
            // btnCatalogoProdutos
            // 
            this.btnCatalogoProdutos.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogoProdutos.Location = new System.Drawing.Point(321, 348);
            this.btnCatalogoProdutos.Name = "btnCatalogoProdutos";
            this.btnCatalogoProdutos.Size = new System.Drawing.Size(132, 23);
            this.btnCatalogoProdutos.TabIndex = 80;
            this.btnCatalogoProdutos.Text = "Exibir produtos";
            this.btnCatalogoProdutos.UseVisualStyleBackColor = true;
            this.btnCatalogoProdutos.Click += new System.EventHandler(this.btnCatalogoProdutos_Click);
            // 
            // btnCadastroProdutos
            // 
            this.btnCadastroProdutos.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroProdutos.Location = new System.Drawing.Point(20, 348);
            this.btnCadastroProdutos.Name = "btnCadastroProdutos";
            this.btnCadastroProdutos.Size = new System.Drawing.Size(132, 23);
            this.btnCadastroProdutos.TabIndex = 79;
            this.btnCadastroProdutos.Text = "Cadastrar Produto";
            this.btnCadastroProdutos.UseVisualStyleBackColor = true;
            this.btnCadastroProdutos.Click += new System.EventHandler(this.btnCadastroProdutos_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(25, 292);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 20);
            this.label19.TabIndex = 78;
            this.label19.Text = "Valor em estoque";
            // 
            // txtvalorunitarioproduto
            // 
            this.txtvalorunitarioproduto.Location = new System.Drawing.Point(204, 238);
            this.txtvalorunitarioproduto.Name = "txtvalorunitarioproduto";
            this.txtvalorunitarioproduto.Size = new System.Drawing.Size(125, 20);
            this.txtvalorunitarioproduto.TabIndex = 77;
            // 
            // txtdescricaoproduto
            // 
            this.txtdescricaoproduto.Location = new System.Drawing.Point(158, 201);
            this.txtdescricaoproduto.Name = "txtdescricaoproduto";
            this.txtdescricaoproduto.Size = new System.Drawing.Size(125, 20);
            this.txtdescricaoproduto.TabIndex = 75;
            // 
            // txtnomeproduto
            // 
            this.txtnomeproduto.Location = new System.Drawing.Point(138, 164);
            this.txtnomeproduto.Name = "txtnomeproduto";
            this.txtnomeproduto.Size = new System.Drawing.Size(125, 20);
            this.txtnomeproduto.TabIndex = 74;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(25, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 20);
            this.label16.TabIndex = 76;
            this.label16.Text = "Descrição Produto:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(25, 164);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 20);
            this.label18.TabIndex = 73;
            this.label18.Text = "Nome Produto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(133, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 27);
            this.label13.TabIndex = 72;
            this.label13.Text = "Cadastro de Produtos";
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnAtualizarProdutos);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.labelValorTotalProdutos);
            this.Controls.Add(this.btnCatalogoProdutos);
            this.Controls.Add(this.btnCadastroProdutos);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtvalorunitarioproduto);
            this.Controls.Add(this.txtdescricaoproduto);
            this.Controls.Add(this.txtnomeproduto);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Name = "FormProdutos";
            this.Text = "FormProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAtualizarProdutos;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.Label labelValorTotalProdutos;
        private System.Windows.Forms.Button btnCatalogoProdutos;
        private System.Windows.Forms.Button btnCadastroProdutos;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtvalorunitarioproduto;
        private System.Windows.Forms.TextBox txtdescricaoproduto;
        private System.Windows.Forms.TextBox txtnomeproduto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
    }
}