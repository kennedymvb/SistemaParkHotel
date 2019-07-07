namespace WFPresentationLayer
{
    partial class FormQuartos
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
            this.dataGridViewQuartos = new System.Windows.Forms.DataGridView();
            this.btnExibirQuartos = new System.Windows.Forms.Button();
            this.cmbTipoQuarto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.CadastrarQuarto = new System.Windows.Forms.Button();
            this.label52 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuartos
            // 
            this.dataGridViewQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuartos.Location = new System.Drawing.Point(450, 2);
            this.dataGridViewQuartos.Name = "dataGridViewQuartos";
            this.dataGridViewQuartos.Size = new System.Drawing.Size(437, 454);
            this.dataGridViewQuartos.TabIndex = 65;
            // 
            // btnExibirQuartos
            // 
            this.btnExibirQuartos.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirQuartos.Location = new System.Drawing.Point(176, 305);
            this.btnExibirQuartos.Name = "btnExibirQuartos";
            this.btnExibirQuartos.Size = new System.Drawing.Size(118, 23);
            this.btnExibirQuartos.TabIndex = 64;
            this.btnExibirQuartos.Text = "Exibir Quartos";
            this.btnExibirQuartos.UseVisualStyleBackColor = true;
            this.btnExibirQuartos.Click += new System.EventHandler(this.btnExibirQuartos_Click);
            // 
            // cmbTipoQuarto
            // 
            this.cmbTipoQuarto.FormattingEnabled = true;
            this.cmbTipoQuarto.Items.AddRange(new object[] {
            "Solteiro",
            "Casal"});
            this.cmbTipoQuarto.Location = new System.Drawing.Point(149, 191);
            this.cmbTipoQuarto.Name = "cmbTipoQuarto";
            this.cmbTipoQuarto.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoQuarto.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Valor Diária:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Tipo de Quarto:";
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Location = new System.Drawing.Point(129, 231);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(121, 20);
            this.txtValorDiaria.TabIndex = 60;
            // 
            // CadastrarQuarto
            // 
            this.CadastrarQuarto.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarQuarto.Location = new System.Drawing.Point(38, 305);
            this.CadastrarQuarto.Name = "CadastrarQuarto";
            this.CadastrarQuarto.Size = new System.Drawing.Size(118, 23);
            this.CadastrarQuarto.TabIndex = 59;
            this.CadastrarQuarto.Text = "Cadastrar Quarto";
            this.CadastrarQuarto.UseVisualStyleBackColor = true;
            this.CadastrarQuarto.Click += new System.EventHandler(this.CadastrarQuarto_Click);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(74, 84);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(176, 27);
            this.label52.TabIndex = 58;
            this.label52.Text = "Cadastro de Quarto";
            // 
            // FormQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.dataGridViewQuartos);
            this.Controls.Add(this.btnExibirQuartos);
            this.Controls.Add(this.cmbTipoQuarto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorDiaria);
            this.Controls.Add(this.CadastrarQuarto);
            this.Controls.Add(this.label52);
            this.Name = "FormQuartos";
            this.Text = "FormQuartos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuartos;
        private System.Windows.Forms.Button btnExibirQuartos;
        private System.Windows.Forms.ComboBox cmbTipoQuarto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorDiaria;
        private System.Windows.Forms.Button CadastrarQuarto;
        private System.Windows.Forms.Label label52;
    }
}