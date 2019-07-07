namespace WFPresentationLayer
{
    partial class FormCheckin
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
            this.dateTimeDataSaida = new System.Windows.Forms.DateTimePicker();
            this.lblAgora = new System.Windows.Forms.CheckBox();
            this.btnPendenciasCheckout = new System.Windows.Forms.Button();
            this.txtQuartoCheckin = new System.Windows.Forms.TextBox();
            this.btnPesquisarQuartosLivres = new System.Windows.Forms.Button();
            this.dataGridViewQuartosLivres = new System.Windows.Forms.DataGridView();
            this.txtNumCliente = new System.Windows.Forms.TextBox();
            this.dataGridViewClientesCheckin = new System.Windows.Forms.DataGridView();
            this.ckbNaoTem = new System.Windows.Forms.CheckBox();
            this.txtNumReserva = new System.Windows.Forms.TextBox();
            this.BtnPesquisarCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeDataPSaidaCheckin = new System.Windows.Forms.DateTimePicker();
            this.btnFazerCheckin = new System.Windows.Forms.Button();
            this.dateTimeCheckinDataentrada = new System.Windows.Forms.DateTimePicker();
            this.label60 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartosLivres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientesCheckin)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeDataSaida
            // 
            this.dateTimeDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeDataSaida.Location = new System.Drawing.Point(243, 178);
            this.dateTimeDataSaida.Name = "dateTimeDataSaida";
            this.dateTimeDataSaida.Size = new System.Drawing.Size(80, 20);
            this.dateTimeDataSaida.TabIndex = 105;
            // 
            // lblAgora
            // 
            this.lblAgora.AutoSize = true;
            this.lblAgora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgora.Location = new System.Drawing.Point(254, 149);
            this.lblAgora.Name = "lblAgora";
            this.lblAgora.Size = new System.Drawing.Size(63, 19);
            this.lblAgora.TabIndex = 104;
            this.lblAgora.Text = "Agora";
            this.lblAgora.UseVisualStyleBackColor = true;
            // 
            // btnPendenciasCheckout
            // 
            this.btnPendenciasCheckout.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendenciasCheckout.Location = new System.Drawing.Point(174, 361);
            this.btnPendenciasCheckout.Name = "btnPendenciasCheckout";
            this.btnPendenciasCheckout.Size = new System.Drawing.Size(149, 23);
            this.btnPendenciasCheckout.TabIndex = 103;
            this.btnPendenciasCheckout.Text = "Pendências de checkout";
            this.btnPendenciasCheckout.UseVisualStyleBackColor = true;
            this.btnPendenciasCheckout.Click += new System.EventHandler(this.btnPendenciasCheckout_Click);
            // 
            // txtQuartoCheckin
            // 
            this.txtQuartoCheckin.Location = new System.Drawing.Point(256, 214);
            this.txtQuartoCheckin.Name = "txtQuartoCheckin";
            this.txtQuartoCheckin.Size = new System.Drawing.Size(67, 20);
            this.txtQuartoCheckin.TabIndex = 102;
            // 
            // btnPesquisarQuartosLivres
            // 
            this.btnPesquisarQuartosLivres.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarQuartosLivres.Location = new System.Drawing.Point(144, 211);
            this.btnPesquisarQuartosLivres.Name = "btnPesquisarQuartosLivres";
            this.btnPesquisarQuartosLivres.Size = new System.Drawing.Size(92, 23);
            this.btnPesquisarQuartosLivres.TabIndex = 101;
            this.btnPesquisarQuartosLivres.Text = "Pesquisar Cliente";
            this.btnPesquisarQuartosLivres.UseVisualStyleBackColor = true;
            this.btnPesquisarQuartosLivres.Click += new System.EventHandler(this.btnPesquisarQuartosLivres_Click);
            // 
            // dataGridViewQuartosLivres
            // 
            this.dataGridViewQuartosLivres.AllowUserToAddRows = false;
            this.dataGridViewQuartosLivres.AllowUserToDeleteRows = false;
            this.dataGridViewQuartosLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuartosLivres.Location = new System.Drawing.Point(365, 227);
            this.dataGridViewQuartosLivres.Name = "dataGridViewQuartosLivres";
            this.dataGridViewQuartosLivres.ReadOnly = true;
            this.dataGridViewQuartosLivres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuartosLivres.Size = new System.Drawing.Size(553, 188);
            this.dataGridViewQuartosLivres.TabIndex = 100;
            this.dataGridViewQuartosLivres.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuartosLivres_CellDoubleClick);
            // 
            // txtNumCliente
            // 
            this.txtNumCliente.Location = new System.Drawing.Point(256, 257);
            this.txtNumCliente.Name = "txtNumCliente";
            this.txtNumCliente.Size = new System.Drawing.Size(67, 20);
            this.txtNumCliente.TabIndex = 99;
            // 
            // dataGridViewClientesCheckin
            // 
            this.dataGridViewClientesCheckin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientesCheckin.Location = new System.Drawing.Point(365, 12);
            this.dataGridViewClientesCheckin.Name = "dataGridViewClientesCheckin";
            this.dataGridViewClientesCheckin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientesCheckin.Size = new System.Drawing.Size(553, 186);
            this.dataGridViewClientesCheckin.TabIndex = 98;
            this.dataGridViewClientesCheckin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientesCheckin_CellDoubleClick);
            // 
            // ckbNaoTem
            // 
            this.ckbNaoTem.AutoSize = true;
            this.ckbNaoTem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.ckbNaoTem.Location = new System.Drawing.Point(256, 298);
            this.ckbNaoTem.Name = "ckbNaoTem";
            this.ckbNaoTem.Size = new System.Drawing.Size(80, 19);
            this.ckbNaoTem.TabIndex = 97;
            this.ckbNaoTem.Text = "Não tem";
            this.ckbNaoTem.UseVisualStyleBackColor = true;
            this.ckbNaoTem.CheckedChanged += new System.EventHandler(this.ckbNaoTem_CheckedChanged);
            // 
            // txtNumReserva
            // 
            this.txtNumReserva.Location = new System.Drawing.Point(144, 295);
            this.txtNumReserva.Name = "txtNumReserva";
            this.txtNumReserva.Size = new System.Drawing.Size(92, 20);
            this.txtNumReserva.TabIndex = 96;
            // 
            // BtnPesquisarCliente
            // 
            this.BtnPesquisarCliente.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisarCliente.Location = new System.Drawing.Point(144, 254);
            this.BtnPesquisarCliente.Name = "BtnPesquisarCliente";
            this.BtnPesquisarCliente.Size = new System.Drawing.Size(92, 23);
            this.BtnPesquisarCliente.TabIndex = 95;
            this.BtnPesquisarCliente.Text = "Pesquisar Cliente";
            this.BtnPesquisarCliente.UseVisualStyleBackColor = true;
            this.BtnPesquisarCliente.Click += new System.EventHandler(this.BtnPesquisarCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 94;
            this.label4.Text = "Data Prevista Saida: ";
            // 
            // dateTimeDataPSaidaCheckin
            // 
            this.dateTimeDataPSaidaCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataPSaidaCheckin.Location = new System.Drawing.Point(144, 178);
            this.dateTimeDataPSaidaCheckin.Name = "dateTimeDataPSaidaCheckin";
            this.dateTimeDataPSaidaCheckin.Size = new System.Drawing.Size(84, 20);
            this.dateTimeDataPSaidaCheckin.TabIndex = 93;
            // 
            // btnFazerCheckin
            // 
            this.btnFazerCheckin.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazerCheckin.Location = new System.Drawing.Point(19, 361);
            this.btnFazerCheckin.Name = "btnFazerCheckin";
            this.btnFazerCheckin.Size = new System.Drawing.Size(105, 23);
            this.btnFazerCheckin.TabIndex = 92;
            this.btnFazerCheckin.Text = "Fazer Check-in";
            this.btnFazerCheckin.UseVisualStyleBackColor = true;
            this.btnFazerCheckin.Click += new System.EventHandler(this.btnFazerCheckin_Click);
            // 
            // dateTimeCheckinDataentrada
            // 
            this.dateTimeCheckinDataentrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCheckinDataentrada.Location = new System.Drawing.Point(156, 145);
            this.dateTimeCheckinDataentrada.Name = "dateTimeCheckinDataentrada";
            this.dateTimeCheckinDataentrada.Size = new System.Drawing.Size(80, 20);
            this.dateTimeCheckinDataentrada.TabIndex = 91;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(6, 295);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(140, 20);
            this.label60.TabIndex = 90;
            this.label60.Text = "Número da Reserva: ";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(6, 257);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(132, 20);
            this.label53.TabIndex = 89;
            this.label53.Text = "Número do Cliente:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(-53, 226);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(61, 20);
            this.label54.TabIndex = 88;
            this.label54.Text = "Quarto: ";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(183, 82);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(90, 27);
            this.label51.TabIndex = 87;
            this.label51.Text = "Check-in";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(6, 148);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(89, 20);
            this.label50.TabIndex = 86;
            this.label50.Text = "Dia Entrada";
            // 
            // FormCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.dateTimeDataSaida);
            this.Controls.Add(this.lblAgora);
            this.Controls.Add(this.btnPendenciasCheckout);
            this.Controls.Add(this.txtQuartoCheckin);
            this.Controls.Add(this.btnPesquisarQuartosLivres);
            this.Controls.Add(this.dataGridViewQuartosLivres);
            this.Controls.Add(this.txtNumCliente);
            this.Controls.Add(this.dataGridViewClientesCheckin);
            this.Controls.Add(this.ckbNaoTem);
            this.Controls.Add(this.txtNumReserva);
            this.Controls.Add(this.BtnPesquisarCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeDataPSaidaCheckin);
            this.Controls.Add(this.btnFazerCheckin);
            this.Controls.Add(this.dateTimeCheckinDataentrada);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label50);
            this.Name = "FormCheckin";
            this.Text = "FormCheckin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartosLivres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientesCheckin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeDataSaida;
        private System.Windows.Forms.CheckBox lblAgora;
        private System.Windows.Forms.Button btnPendenciasCheckout;
        private System.Windows.Forms.TextBox txtQuartoCheckin;
        private System.Windows.Forms.Button btnPesquisarQuartosLivres;
        private System.Windows.Forms.DataGridView dataGridViewQuartosLivres;
        private System.Windows.Forms.TextBox txtNumCliente;
        private System.Windows.Forms.DataGridView dataGridViewClientesCheckin;
        private System.Windows.Forms.CheckBox ckbNaoTem;
        private System.Windows.Forms.TextBox txtNumReserva;
        private System.Windows.Forms.Button BtnPesquisarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeDataPSaidaCheckin;
        private System.Windows.Forms.Button btnFazerCheckin;
        private System.Windows.Forms.DateTimePicker dateTimeCheckinDataentrada;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
    }
}