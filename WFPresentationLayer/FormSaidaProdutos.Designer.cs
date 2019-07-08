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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaidaProdutos));
            this.dateTimeVenda = new System.Windows.Forms.DateTimePicker();
            this.label36 = new System.Windows.Forms.Label();
            this.btnSelecionarCliente = new System.Windows.Forms.Button();
            this.txtNumCheckin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.btnProximaPagina = new System.Windows.Forms.Button();
            this.dataGridSelecionarCheckin = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelecionarCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeVenda
            // 
            this.dateTimeVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeVenda.Location = new System.Drawing.Point(156, 254);
            this.dateTimeVenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeVenda.Name = "dateTimeVenda";
            this.dateTimeVenda.Size = new System.Drawing.Size(110, 22);
            this.dateTimeVenda.TabIndex = 129;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(29, 258);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(100, 17);
            this.label36.TabIndex = 128;
            this.label36.Text = "Data da Venda:";
            // 
            // btnSelecionarCliente
            // 
            this.btnSelecionarCliente.Location = new System.Drawing.Point(366, 191);
            this.btnSelecionarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelecionarCliente.Name = "btnSelecionarCliente";
            this.btnSelecionarCliente.Size = new System.Drawing.Size(100, 28);
            this.btnSelecionarCliente.TabIndex = 127;
            this.btnSelecionarCliente.Text = "Selecionar";
            this.btnSelecionarCliente.UseVisualStyleBackColor = true;
            this.btnSelecionarCliente.Click += new System.EventHandler(this.btnSelecionarCliente_Click_1);
            // 
            // txtNumCheckin
            // 
            this.txtNumCheckin.Location = new System.Drawing.Point(156, 194);
            this.txtNumCheckin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumCheckin.Name = "txtNumCheckin";
            this.txtNumCheckin.Size = new System.Drawing.Size(202, 22);
            this.txtNumCheckin.TabIndex = 126;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 199);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 125;
            this.label8.Text = "Selecionar Cliente";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(188, 29);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(264, 44);
            this.label34.TabIndex = 124;
            this.label34.Text = "Cadastro Vendas";
            // 
            // btnProximaPagina
            // 
            this.btnProximaPagina.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximaPagina.Location = new System.Drawing.Point(145, 406);
            this.btnProximaPagina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProximaPagina.Name = "btnProximaPagina";
            this.btnProximaPagina.Size = new System.Drawing.Size(167, 25);
            this.btnProximaPagina.TabIndex = 130;
            this.btnProximaPagina.Text = "Cadastrar Venda";
            this.btnProximaPagina.UseVisualStyleBackColor = true;
            this.btnProximaPagina.Click += new System.EventHandler(this.btnProximaPagina_Click_1);
            // 
            // dataGridSelecionarCheckin
            // 
            this.dataGridSelecionarCheckin.AllowUserToAddRows = false;
            this.dataGridSelecionarCheckin.AllowUserToDeleteRows = false;
            this.dataGridSelecionarCheckin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSelecionarCheckin.Location = new System.Drawing.Point(560, 1);
            this.dataGridSelecionarCheckin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridSelecionarCheckin.Name = "dataGridSelecionarCheckin";
            this.dataGridSelecionarCheckin.ReadOnly = true;
            this.dataGridSelecionarCheckin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSelecionarCheckin.Size = new System.Drawing.Size(508, 554);
            this.dataGridSelecionarCheckin.TabIndex = 131;
            this.dataGridSelecionarCheckin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSelecionarCheckin_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 132;
            this.pictureBox1.TabStop = false;
            // 
            // FormSaidaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridSelecionarCheckin);
            this.Controls.Add(this.btnProximaPagina);
            this.Controls.Add(this.dateTimeVenda);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.btnSelecionarCliente);
            this.Controls.Add(this.txtNumCheckin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label34);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSaidaProdutos";
            this.Text = "FormSaidaProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelecionarCheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridSelecionarCheckin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}