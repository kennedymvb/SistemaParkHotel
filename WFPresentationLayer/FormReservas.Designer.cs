namespace WFPresentationLayer
{
    partial class FormReservas
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
            this.dataGridViewReservas = new System.Windows.Forms.DataGridView();
            this.btnConsultarReservas = new System.Windows.Forms.Button();
            this.btncadastrarReservas = new System.Windows.Forms.Button();
            this.dateTimeSaidaReserva = new System.Windows.Forms.DateTimePicker();
            this.DateTimeChegadaReserva = new System.Windows.Forms.DateTimePicker();
            this.label32 = new System.Windows.Forms.Label();
            this.txtnumQuartoReserva = new System.Windows.Forms.TextBox();
            this.txtnumClienteReserva = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservas.Location = new System.Drawing.Point(407, 0);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.Size = new System.Drawing.Size(517, 451);
            this.dataGridViewReservas.TabIndex = 54;
            this.dataGridViewReservas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservas_CellDoubleClick);
            // 
            // btnConsultarReservas
            // 
            this.btnConsultarReservas.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarReservas.Location = new System.Drawing.Point(195, 302);
            this.btnConsultarReservas.Name = "btnConsultarReservas";
            this.btnConsultarReservas.Size = new System.Drawing.Size(142, 23);
            this.btnConsultarReservas.TabIndex = 53;
            this.btnConsultarReservas.Text = "Consultar Reservas";
            this.btnConsultarReservas.UseVisualStyleBackColor = true;
            this.btnConsultarReservas.Click += new System.EventHandler(this.btnConsultarReservas_Click);
            // 
            // btncadastrarReservas
            // 
            this.btncadastrarReservas.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrarReservas.Location = new System.Drawing.Point(34, 302);
            this.btncadastrarReservas.Name = "btncadastrarReservas";
            this.btncadastrarReservas.Size = new System.Drawing.Size(144, 23);
            this.btncadastrarReservas.TabIndex = 52;
            this.btncadastrarReservas.Text = "Cadastrar Reservas";
            this.btncadastrarReservas.UseVisualStyleBackColor = true;
            this.btncadastrarReservas.Click += new System.EventHandler(this.btncadastrarReservas_Click);
            // 
            // dateTimeSaidaReserva
            // 
            this.dateTimeSaidaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSaidaReserva.Location = new System.Drawing.Point(237, 209);
            this.dateTimeSaidaReserva.Name = "dateTimeSaidaReserva";
            this.dateTimeSaidaReserva.Size = new System.Drawing.Size(100, 20);
            this.dateTimeSaidaReserva.TabIndex = 51;
            // 
            // DateTimeChegadaReserva
            // 
            this.DateTimeChegadaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeChegadaReserva.Location = new System.Drawing.Point(237, 172);
            this.DateTimeChegadaReserva.Name = "DateTimeChegadaReserva";
            this.DateTimeChegadaReserva.Size = new System.Drawing.Size(100, 20);
            this.DateTimeChegadaReserva.TabIndex = 50;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(65, 213);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(95, 20);
            this.label32.TabIndex = 49;
            this.label32.Text = "Dia da Saída:";
            // 
            // txtnumQuartoReserva
            // 
            this.txtnumQuartoReserva.Location = new System.Drawing.Point(237, 245);
            this.txtnumQuartoReserva.Name = "txtnumQuartoReserva";
            this.txtnumQuartoReserva.Size = new System.Drawing.Size(100, 20);
            this.txtnumQuartoReserva.TabIndex = 48;
            // 
            // txtnumClienteReserva
            // 
            this.txtnumClienteReserva.Location = new System.Drawing.Point(237, 137);
            this.txtnumClienteReserva.Name = "txtnumClienteReserva";
            this.txtnumClienteReserva.Size = new System.Drawing.Size(100, 20);
            this.txtnumClienteReserva.TabIndex = 46;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(65, 250);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(129, 20);
            this.label33.TabIndex = 47;
            this.label33.Text = "Número do Quarto:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(65, 137);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(132, 20);
            this.label31.TabIndex = 45;
            this.label31.Text = "Número do Cliente:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(65, 172);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(113, 20);
            this.label30.TabIndex = 44;
            this.label30.Text = "Dia da Chegada:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(64, 79);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(164, 27);
            this.label27.TabIndex = 43;
            this.label27.Text = "Cadastro Reservas";
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.dataGridViewReservas);
            this.Controls.Add(this.btnConsultarReservas);
            this.Controls.Add(this.btncadastrarReservas);
            this.Controls.Add(this.dateTimeSaidaReserva);
            this.Controls.Add(this.DateTimeChegadaReserva);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.txtnumQuartoReserva);
            this.Controls.Add(this.txtnumClienteReserva);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label27);
            this.Name = "FormReservas";
            this.Text = "FormReservas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReservas;
        private System.Windows.Forms.Button btnConsultarReservas;
        private System.Windows.Forms.Button btncadastrarReservas;
        private System.Windows.Forms.DateTimePicker dateTimeSaidaReserva;
        private System.Windows.Forms.DateTimePicker DateTimeChegadaReserva;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtnumQuartoReserva;
        private System.Windows.Forms.TextBox txtnumClienteReserva;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label27;
    }
}