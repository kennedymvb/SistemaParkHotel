namespace WFPresentationLayer
{
    partial class FormSaidaProdutos
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
            this.dateTimeVenda = new System.Windows.Forms.DateTimePicker();
            this.label36 = new System.Windows.Forms.Label();
            this.btnSelecionarCliente = new System.Windows.Forms.Button();
            this.txtNumCheckin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.btnProximaPagina = new System.Windows.Forms.Button();
            this.dataGridDia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDia)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeVenda
            // 
            this.dateTimeVenda.Location = new System.Drawing.Point(441, 242);
            this.dateTimeVenda.Name = "dateTimeVenda";
            this.dateTimeVenda.Size = new System.Drawing.Size(123, 20);
            this.dateTimeVenda.TabIndex = 129;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(297, 242);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(105, 20);
            this.label36.TabIndex = 128;
            this.label36.Text = "Data da Venda:";
            // 
            // btnSelecionarCliente
            // 
            this.btnSelecionarCliente.Location = new System.Drawing.Point(441, 147);
            this.btnSelecionarCliente.Name = "btnSelecionarCliente";
            this.btnSelecionarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarCliente.TabIndex = 127;
            this.btnSelecionarCliente.Text = "Selecionar";
            this.btnSelecionarCliente.UseVisualStyleBackColor = true;
            this.btnSelecionarCliente.Click += new System.EventHandler(this.btnSelecionarCliente_Click_1);
            // 
            // txtNumCheckin
            // 
            this.txtNumCheckin.Location = new System.Drawing.Point(303, 150);
            this.txtNumCheckin.Name = "txtNumCheckin";
            this.txtNumCheckin.Size = new System.Drawing.Size(118, 20);
            this.txtNumCheckin.TabIndex = 126;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(299, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 125;
            this.label8.Text = "Selecionar Cliente";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(296, 43);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(152, 27);
            this.label34.TabIndex = 124;
            this.label34.Text = "Cadastro Vendas";
            // 
            // btnProximaPagina
            // 
            this.btnProximaPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximaPagina.Location = new System.Drawing.Point(323, 338);
            this.btnProximaPagina.Name = "btnProximaPagina";
            this.btnProximaPagina.Size = new System.Drawing.Size(125, 20);
            this.btnProximaPagina.TabIndex = 130;
            this.btnProximaPagina.Text = "Cadastrar Venda";
            this.btnProximaPagina.UseVisualStyleBackColor = true;
            this.btnProximaPagina.Click += new System.EventHandler(this.btnProximaPagina_Click_1);
            // 
            // dataGridDia
            // 
            this.dataGridDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDia.Location = new System.Drawing.Point(-9, 216);
            this.dataGridDia.Name = "dataGridDia";
            this.dataGridDia.Size = new System.Drawing.Size(10, 10);
            this.dataGridDia.TabIndex = 131;
            // 
            // FormSaidaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridDia);
            this.Controls.Add(this.btnProximaPagina);
            this.Controls.Add(this.dateTimeVenda);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.btnSelecionarCliente);
            this.Controls.Add(this.txtNumCheckin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label34);
            this.Name = "FormSaidaProdutos";
            this.Text = "FormSaidaProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeVenda;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btnSelecionarCliente;
        private System.Windows.Forms.TextBox txtNumCheckin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button btnProximaPagina;
        private System.Windows.Forms.DataGridView dataGridDia;
    }
}