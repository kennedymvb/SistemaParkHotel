namespace WFPresentationLayer
{
    partial class FormUsuarios
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
            this.atualizarUsuario = new System.Windows.Forms.Button();
            this.dataGridViewAdministrador = new System.Windows.Forms.DataGridView();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.txtTelefoneUsuario = new System.Windows.Forms.TextBox();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.txtRGUsuario = new System.Windows.Forms.TextBox();
            this.txtEnderecoUsuario = new System.Windows.Forms.TextBox();
            this.txtCPFUsuario = new System.Windows.Forms.TextBox();
            this.txtnomeUsuario = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.btnConsultarFuncionarios = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdministrador)).BeginInit();
            this.SuspendLayout();
            // 
            // atualizarUsuario
            // 
            this.atualizarUsuario.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizarUsuario.Location = new System.Drawing.Point(133, 364);
            this.atualizarUsuario.Name = "atualizarUsuario";
            this.atualizarUsuario.Size = new System.Drawing.Size(118, 23);
            this.atualizarUsuario.TabIndex = 101;
            this.atualizarUsuario.Text = "Atualizar Usuário";
            this.atualizarUsuario.UseVisualStyleBackColor = true;
            this.atualizarUsuario.Click += new System.EventHandler(this.atualizarUsuario_Click);
            // 
            // dataGridViewAdministrador
            // 
            this.dataGridViewAdministrador.AllowUserToAddRows = false;
            this.dataGridViewAdministrador.AllowUserToDeleteRows = false;
            this.dataGridViewAdministrador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAdministrador.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAdministrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdministrador.Location = new System.Drawing.Point(463, 1);
            this.dataGridViewAdministrador.Name = "dataGridViewAdministrador";
            this.dataGridViewAdministrador.ReadOnly = true;
            this.dataGridViewAdministrador.RowHeadersVisible = false;
            this.dataGridViewAdministrador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdministrador.Size = new System.Drawing.Size(449, 448);
            this.dataGridViewAdministrador.TabIndex = 100;
            this.dataGridViewAdministrador.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdministrador_CellDoubleClick);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(41, 316);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(52, 20);
            this.label47.TabIndex = 99;
            this.label47.Text = "Senha:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(39, 290);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(54, 20);
            this.label48.TabIndex = 98;
            this.label48.Text = "Email:";
            // 
            // txtTelefoneUsuario
            // 
            this.txtTelefoneUsuario.Location = new System.Drawing.Point(105, 264);
            this.txtTelefoneUsuario.Name = "txtTelefoneUsuario";
            this.txtTelefoneUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtTelefoneUsuario.TabIndex = 97;
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Location = new System.Drawing.Point(105, 316);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaUsuario.TabIndex = 96;
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Location = new System.Drawing.Point(105, 290);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtEmailUsuario.TabIndex = 95;
            // 
            // txtRGUsuario
            // 
            this.txtRGUsuario.Location = new System.Drawing.Point(105, 158);
            this.txtRGUsuario.Name = "txtRGUsuario";
            this.txtRGUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtRGUsuario.TabIndex = 88;
            // 
            // txtEnderecoUsuario
            // 
            this.txtEnderecoUsuario.Location = new System.Drawing.Point(105, 229);
            this.txtEnderecoUsuario.Name = "txtEnderecoUsuario";
            this.txtEnderecoUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtEnderecoUsuario.TabIndex = 86;
            // 
            // txtCPFUsuario
            // 
            this.txtCPFUsuario.Location = new System.Drawing.Point(105, 192);
            this.txtCPFUsuario.Name = "txtCPFUsuario";
            this.txtCPFUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtCPFUsuario.TabIndex = 84;
            // 
            // txtnomeUsuario
            // 
            this.txtnomeUsuario.Location = new System.Drawing.Point(105, 127);
            this.txtnomeUsuario.Name = "txtnomeUsuario";
            this.txtnomeUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtnomeUsuario.TabIndex = 82;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(29, 264);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(64, 20);
            this.label41.TabIndex = 94;
            this.label41.Text = "Telefone:";
            // 
            // btnConsultarFuncionarios
            // 
            this.btnConsultarFuncionarios.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFuncionarios.Location = new System.Drawing.Point(257, 364);
            this.btnConsultarFuncionarios.Name = "btnConsultarFuncionarios";
            this.btnConsultarFuncionarios.Size = new System.Drawing.Size(158, 23);
            this.btnConsultarFuncionarios.TabIndex = 93;
            this.btnConsultarFuncionarios.Text = "Consultar Funcionários";
            this.btnConsultarFuncionarios.UseVisualStyleBackColor = true;
            this.btnConsultarFuncionarios.Click += new System.EventHandler(this.btnConsultarFuncionarios_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(230, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(207, 27);
            this.label20.TabIndex = 92;
            this.label20.Text = "Tela do Administrador";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(45, 127);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(48, 20);
            this.label46.TabIndex = 91;
            this.label46.Text = "Nome:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 90;
            this.button1.Text = "Cadastrar Usuário";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(44, 80);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(190, 27);
            this.label45.TabIndex = 89;
            this.label45.Text = "Cadastro de Usuários";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(56, 158);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(32, 20);
            this.label44.TabIndex = 87;
            this.label44.Text = "RG:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(23, 229);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(70, 20);
            this.label43.TabIndex = 85;
            this.label43.Text = "Endereço:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(56, 192);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(37, 20);
            this.label42.TabIndex = 83;
            this.label42.Text = "CPF:";
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.atualizarUsuario);
            this.Controls.Add(this.dataGridViewAdministrador);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.txtTelefoneUsuario);
            this.Controls.Add(this.txtSenhaUsuario);
            this.Controls.Add(this.txtEmailUsuario);
            this.Controls.Add(this.txtRGUsuario);
            this.Controls.Add(this.txtEnderecoUsuario);
            this.Controls.Add(this.txtCPFUsuario);
            this.Controls.Add(this.txtnomeUsuario);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.btnConsultarFuncionarios);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdministrador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button atualizarUsuario;
        private System.Windows.Forms.DataGridView dataGridViewAdministrador;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox txtTelefoneUsuario;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.TextBox txtRGUsuario;
        private System.Windows.Forms.TextBox txtEnderecoUsuario;
        private System.Windows.Forms.TextBox txtCPFUsuario;
        private System.Windows.Forms.TextBox txtnomeUsuario;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Button btnConsultarFuncionarios;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
    }
}