namespace WFPresentationLayer
{
    partial class FormFornecedores
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
            this.dataGridViewFornecedor = new System.Windows.Forms.DataGridView();
            this.btnAtualizarFornecedor = new System.Windows.Forms.Button();
            this.btnConsultarFornecedor = new System.Windows.Forms.Button();
            this.txtEmailFornecedor = new System.Windows.Forms.TextBox();
            this.txtcnpjFornecedor = new System.Windows.Forms.TextBox();
            this.txtNomecontatoFornecedor = new System.Windows.Forms.TextBox();
            this.txtTelefoneFornecedor = new System.Windows.Forms.TextBox();
            this.txtrazaoSocial = new System.Windows.Forms.TextBox();
            this.btncadastrarFornecedor = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFornecedor
            // 
            this.dataGridViewFornecedor.AllowUserToAddRows = false;
            this.dataGridViewFornecedor.AllowUserToDeleteRows = false;
            this.dataGridViewFornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFornecedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedor.Location = new System.Drawing.Point(482, 3);
            this.dataGridViewFornecedor.Name = "dataGridViewFornecedor";
            this.dataGridViewFornecedor.ReadOnly = true;
            this.dataGridViewFornecedor.RowHeadersVisible = false;
            this.dataGridViewFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFornecedor.Size = new System.Drawing.Size(406, 445);
            this.dataGridViewFornecedor.TabIndex = 62;
            this.dataGridViewFornecedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFornecedor_CellDoubleClick);
            // 
            // btnAtualizarFornecedor
            // 
            this.btnAtualizarFornecedor.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarFornecedor.Location = new System.Drawing.Point(291, 339);
            this.btnAtualizarFornecedor.Name = "btnAtualizarFornecedor";
            this.btnAtualizarFornecedor.Size = new System.Drawing.Size(105, 23);
            this.btnAtualizarFornecedor.TabIndex = 61;
            this.btnAtualizarFornecedor.Text = "Atualizar";
            this.btnAtualizarFornecedor.UseVisualStyleBackColor = true;
            this.btnAtualizarFornecedor.Click += new System.EventHandler(this.btnAtualizarFornecedor_Click);
            // 
            // btnConsultarFornecedor
            // 
            this.btnConsultarFornecedor.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFornecedor.Location = new System.Drawing.Point(162, 339);
            this.btnConsultarFornecedor.Name = "btnConsultarFornecedor";
            this.btnConsultarFornecedor.Size = new System.Drawing.Size(102, 23);
            this.btnConsultarFornecedor.TabIndex = 60;
            this.btnConsultarFornecedor.Text = "Consultar Fornecedores";
            this.btnConsultarFornecedor.UseVisualStyleBackColor = true;
            this.btnConsultarFornecedor.Click += new System.EventHandler(this.btnConsultarFornecedor_Click);
            // 
            // txtEmailFornecedor
            // 
            this.txtEmailFornecedor.Location = new System.Drawing.Point(192, 278);
            this.txtEmailFornecedor.Name = "txtEmailFornecedor";
            this.txtEmailFornecedor.Size = new System.Drawing.Size(130, 20);
            this.txtEmailFornecedor.TabIndex = 58;
            // 
            // txtcnpjFornecedor
            // 
            this.txtcnpjFornecedor.Location = new System.Drawing.Point(201, 171);
            this.txtcnpjFornecedor.Name = "txtcnpjFornecedor";
            this.txtcnpjFornecedor.Size = new System.Drawing.Size(121, 20);
            this.txtcnpjFornecedor.TabIndex = 55;
            // 
            // txtNomecontatoFornecedor
            // 
            this.txtNomecontatoFornecedor.Location = new System.Drawing.Point(222, 208);
            this.txtNomecontatoFornecedor.Name = "txtNomecontatoFornecedor";
            this.txtNomecontatoFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtNomecontatoFornecedor.TabIndex = 53;
            // 
            // txtTelefoneFornecedor
            // 
            this.txtTelefoneFornecedor.Location = new System.Drawing.Point(201, 243);
            this.txtTelefoneFornecedor.Name = "txtTelefoneFornecedor";
            this.txtTelefoneFornecedor.Size = new System.Drawing.Size(121, 20);
            this.txtTelefoneFornecedor.TabIndex = 51;
            // 
            // txtrazaoSocial
            // 
            this.txtrazaoSocial.Location = new System.Drawing.Point(202, 137);
            this.txtrazaoSocial.Name = "txtrazaoSocial";
            this.txtrazaoSocial.Size = new System.Drawing.Size(120, 20);
            this.txtrazaoSocial.TabIndex = 49;
            // 
            // btncadastrarFornecedor
            // 
            this.btncadastrarFornecedor.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrarFornecedor.Location = new System.Drawing.Point(34, 339);
            this.btncadastrarFornecedor.Name = "btncadastrarFornecedor";
            this.btncadastrarFornecedor.Size = new System.Drawing.Size(103, 23);
            this.btncadastrarFornecedor.TabIndex = 59;
            this.btncadastrarFornecedor.Text = "Cadastrar Fornecedor";
            this.btncadastrarFornecedor.UseVisualStyleBackColor = true;
            this.btncadastrarFornecedor.Click += new System.EventHandler(this.btncadastrarFornecedor_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(138, 278);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(54, 20);
            this.label28.TabIndex = 57;
            this.label28.Text = "Email:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(125, 88);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(197, 27);
            this.label26.TabIndex = 56;
            this.label26.Text = "Cadastro Fornecedores";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(136, 172);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 20);
            this.label25.TabIndex = 54;
            this.label25.Text = "CNPJ:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(128, 243);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 20);
            this.label24.TabIndex = 52;
            this.label24.Text = "Telefone:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(80, 208);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 20);
            this.label23.TabIndex = 50;
            this.label23.Text = "Nome Para Contato:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(100, 137);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 20);
            this.label22.TabIndex = 48;
            this.label22.Text = "Razão Social:";
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.dataGridViewFornecedor);
            this.Controls.Add(this.btnAtualizarFornecedor);
            this.Controls.Add(this.btnConsultarFornecedor);
            this.Controls.Add(this.txtEmailFornecedor);
            this.Controls.Add(this.txtcnpjFornecedor);
            this.Controls.Add(this.txtNomecontatoFornecedor);
            this.Controls.Add(this.txtTelefoneFornecedor);
            this.Controls.Add(this.txtrazaoSocial);
            this.Controls.Add(this.btncadastrarFornecedor);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Name = "FormFornecedores";
            this.Text = "FormFornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFornecedor;
        private System.Windows.Forms.Button btnAtualizarFornecedor;
        private System.Windows.Forms.Button btnConsultarFornecedor;
        private System.Windows.Forms.TextBox txtEmailFornecedor;
        private System.Windows.Forms.TextBox txtcnpjFornecedor;
        private System.Windows.Forms.TextBox txtNomecontatoFornecedor;
        private System.Windows.Forms.TextBox txtTelefoneFornecedor;
        private System.Windows.Forms.TextBox txtrazaoSocial;
        private System.Windows.Forms.Button btncadastrarFornecedor;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
    }
}