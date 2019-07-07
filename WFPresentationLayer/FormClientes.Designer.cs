namespace WFPresentationLayer
{
    partial class FormClientes
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
            this.BtnAtualizarClientes = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExibirClientes = new System.Windows.Forms.Button();
            this.txttelefone1Cliente = new System.Windows.Forms.TextBox();
            this.txttelefone2Cliente = new System.Windows.Forms.TextBox();
            this.txtrgCliente = new System.Windows.Forms.TextBox();
            this.txtemailCliente = new System.Windows.Forms.TextBox();
            this.txtcpfCliente = new System.Windows.Forms.TextBox();
            this.txtnomeCliente = new System.Windows.Forms.TextBox();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelrg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAtualizarClientes
            // 
            this.BtnAtualizarClientes.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizarClientes.Location = new System.Drawing.Point(309, 356);
            this.BtnAtualizarClientes.Name = "BtnAtualizarClientes";
            this.BtnAtualizarClientes.Size = new System.Drawing.Size(116, 23);
            this.BtnAtualizarClientes.TabIndex = 64;
            this.BtnAtualizarClientes.Text = "Atualizar Dados";
            this.BtnAtualizarClientes.UseVisualStyleBackColor = true;
            this.BtnAtualizarClientes.Click += new System.EventHandler(this.BtnAtualizarClientes_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(510, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(406, 453);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnExibirClientes
            // 
            this.btnExibirClientes.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirClientes.Location = new System.Drawing.Point(156, 356);
            this.btnExibirClientes.Name = "btnExibirClientes";
            this.btnExibirClientes.Size = new System.Drawing.Size(123, 23);
            this.btnExibirClientes.TabIndex = 62;
            this.btnExibirClientes.Text = "Exibir Clientes";
            this.btnExibirClientes.UseVisualStyleBackColor = true;
            this.btnExibirClientes.Click += new System.EventHandler(this.btnExibirClientes_Click);
            // 
            // txttelefone1Cliente
            // 
            this.txttelefone1Cliente.Location = new System.Drawing.Point(214, 233);
            this.txttelefone1Cliente.Name = "txttelefone1Cliente";
            this.txttelefone1Cliente.Size = new System.Drawing.Size(125, 20);
            this.txttelefone1Cliente.TabIndex = 60;
            // 
            // txttelefone2Cliente
            // 
            this.txttelefone2Cliente.Location = new System.Drawing.Point(214, 270);
            this.txttelefone2Cliente.Name = "txttelefone2Cliente";
            this.txttelefone2Cliente.Size = new System.Drawing.Size(125, 20);
            this.txttelefone2Cliente.TabIndex = 58;
            // 
            // txtrgCliente
            // 
            this.txtrgCliente.Location = new System.Drawing.Point(214, 307);
            this.txtrgCliente.Name = "txtrgCliente";
            this.txtrgCliente.Size = new System.Drawing.Size(125, 20);
            this.txtrgCliente.TabIndex = 55;
            // 
            // txtemailCliente
            // 
            this.txtemailCliente.Location = new System.Drawing.Point(214, 200);
            this.txtemailCliente.Name = "txtemailCliente";
            this.txtemailCliente.Size = new System.Drawing.Size(125, 20);
            this.txtemailCliente.TabIndex = 53;
            // 
            // txtcpfCliente
            // 
            this.txtcpfCliente.Location = new System.Drawing.Point(214, 161);
            this.txtcpfCliente.Name = "txtcpfCliente";
            this.txtcpfCliente.Size = new System.Drawing.Size(125, 20);
            this.txtcpfCliente.TabIndex = 51;
            // 
            // txtnomeCliente
            // 
            this.txtnomeCliente.Location = new System.Drawing.Point(214, 119);
            this.txtnomeCliente.Name = "txtnomeCliente";
            this.txtnomeCliente.Size = new System.Drawing.Size(125, 20);
            this.txtnomeCliente.TabIndex = 49;
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCliente.Location = new System.Drawing.Point(13, 356);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(123, 23);
            this.btnCadastroCliente.TabIndex = 61;
            this.btnCadastroCliente.Text = "Cadastrar Cliente";
            this.btnCadastroCliente.UseVisualStyleBackColor = true;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(127, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Telefone 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(127, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "Telefone 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(187, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 27);
            this.label7.TabIndex = 56;
            this.label7.Text = "Cadastro de Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "CPF:";
            // 
            // labelrg
            // 
            this.labelrg.AutoSize = true;
            this.labelrg.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrg.Location = new System.Drawing.Point(143, 307);
            this.labelrg.Name = "labelrg";
            this.labelrg.Size = new System.Drawing.Size(32, 20);
            this.labelrg.TabIndex = 50;
            this.labelrg.Text = "RG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nome:";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.BtnAtualizarClientes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExibirClientes);
            this.Controls.Add(this.txttelefone1Cliente);
            this.Controls.Add(this.txttelefone2Cliente);
            this.Controls.Add(this.txtrgCliente);
            this.Controls.Add(this.txtemailCliente);
            this.Controls.Add(this.txtcpfCliente);
            this.Controls.Add(this.txtnomeCliente);
            this.Controls.Add(this.btnCadastroCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelrg);
            this.Controls.Add(this.label3);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAtualizarClientes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExibirClientes;
        private System.Windows.Forms.TextBox txttelefone1Cliente;
        private System.Windows.Forms.TextBox txttelefone2Cliente;
        private System.Windows.Forms.TextBox txtrgCliente;
        private System.Windows.Forms.TextBox txtemailCliente;
        private System.Windows.Forms.TextBox txtcpfCliente;
        private System.Windows.Forms.TextBox txtnomeCliente;
        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelrg;
        private System.Windows.Forms.Label label3;
    }
}