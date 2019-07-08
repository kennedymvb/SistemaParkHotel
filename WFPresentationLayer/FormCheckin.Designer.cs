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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckin));
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridReservas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisarReserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartosLivres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientesCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeDataSaida
            // 
            this.dateTimeDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeDataSaida.Location = new System.Drawing.Point(213, 260);
            this.dateTimeDataSaida.Name = "dateTimeDataSaida";
            this.dateTimeDataSaida.Size = new System.Drawing.Size(80, 20);
            this.dateTimeDataSaida.TabIndex = 105;
            // 
            // lblAgora
            // 
            this.lblAgora.AutoSize = true;
            this.lblAgora.BackColor = System.Drawing.Color.Transparent;
            this.lblAgora.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgora.Location = new System.Drawing.Point(224, 193);
            this.lblAgora.Name = "lblAgora";
            this.lblAgora.Size = new System.Drawing.Size(56, 18);
            this.lblAgora.TabIndex = 104;
            this.lblAgora.Text = "Agora";
            this.lblAgora.UseVisualStyleBackColor = false;
            // 
            // btnPendenciasCheckout
            // 
            this.btnPendenciasCheckout.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendenciasCheckout.Location = new System.Drawing.Point(192, 612);
            this.btnPendenciasCheckout.Name = "btnPendenciasCheckout";
            this.btnPendenciasCheckout.Size = new System.Drawing.Size(149, 23);
            this.btnPendenciasCheckout.TabIndex = 103;
            this.btnPendenciasCheckout.Text = "Pendências de checkout";
            this.btnPendenciasCheckout.UseVisualStyleBackColor = true;
            this.btnPendenciasCheckout.Click += new System.EventHandler(this.btnPendenciasCheckout_Click);
            // 
            // txtQuartoCheckin
            // 
            this.txtQuartoCheckin.Location = new System.Drawing.Point(226, 296);
            this.txtQuartoCheckin.Name = "txtQuartoCheckin";
            this.txtQuartoCheckin.Size = new System.Drawing.Size(67, 20);
            this.txtQuartoCheckin.TabIndex = 102;
            // 
            // btnPesquisarQuartosLivres
            // 
            this.btnPesquisarQuartosLivres.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarQuartosLivres.Location = new System.Drawing.Point(114, 293);
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
            this.txtNumCliente.Location = new System.Drawing.Point(226, 384);
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
            this.ckbNaoTem.BackColor = System.Drawing.Color.Transparent;
            this.ckbNaoTem.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNaoTem.Location = new System.Drawing.Point(226, 465);
            this.ckbNaoTem.Name = "ckbNaoTem";
            this.ckbNaoTem.Size = new System.Drawing.Size(69, 18);
            this.ckbNaoTem.TabIndex = 97;
            this.ckbNaoTem.Text = "Não tem";
            this.ckbNaoTem.UseVisualStyleBackColor = false;
            this.ckbNaoTem.CheckedChanged += new System.EventHandler(this.ckbNaoTem_CheckedChanged);
            // 
            // txtNumReserva
            // 
            this.txtNumReserva.Location = new System.Drawing.Point(114, 462);
            this.txtNumReserva.Name = "txtNumReserva";
            this.txtNumReserva.Size = new System.Drawing.Size(92, 20);
            this.txtNumReserva.TabIndex = 96;
            // 
            // BtnPesquisarCliente
            // 
            this.BtnPesquisarCliente.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisarCliente.Location = new System.Drawing.Point(114, 381);
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
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 14);
            this.label4.TabIndex = 94;
            this.label4.Text = "Data Prevista Saida: ";
            // 
            // dateTimeDataPSaidaCheckin
            // 
            this.dateTimeDataPSaidaCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataPSaidaCheckin.Location = new System.Drawing.Point(114, 260);
            this.dateTimeDataPSaidaCheckin.Name = "dateTimeDataPSaidaCheckin";
            this.dateTimeDataPSaidaCheckin.Size = new System.Drawing.Size(84, 20);
            this.dateTimeDataPSaidaCheckin.TabIndex = 93;
            // 
            // btnFazerCheckin
            // 
            this.btnFazerCheckin.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazerCheckin.Location = new System.Drawing.Point(57, 612);
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
            this.dateTimeCheckinDataentrada.Location = new System.Drawing.Point(114, 189);
            this.dateTimeCheckinDataentrada.Name = "dateTimeCheckinDataentrada";
            this.dateTimeCheckinDataentrada.Size = new System.Drawing.Size(84, 20);
            this.dateTimeCheckinDataentrada.TabIndex = 91;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.Color.Transparent;
            this.label60.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(5, 465);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(115, 14);
            this.label60.TabIndex = 90;
            this.label60.Text = "Número da Reserva: ";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(12, 390);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(107, 14);
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
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(128, 24);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(123, 35);
            this.label51.TabIndex = 87;
            this.label51.Text = "Check-in";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(46, 192);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(69, 14);
            this.label50.TabIndex = 86;
            this.label50.Text = "Dia Entrada";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridReservas
            // 
            this.dataGridReservas.AllowUserToAddRows = false;
            this.dataGridReservas.AllowUserToDeleteRows = false;
            this.dataGridReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReservas.Location = new System.Drawing.Point(365, 433);
            this.dataGridReservas.Name = "dataGridReservas";
            this.dataGridReservas.ReadOnly = true;
            this.dataGridReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReservas.Size = new System.Drawing.Size(553, 188);
            this.dataGridReservas.TabIndex = 108;
            this.dataGridReservas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReservas_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 109;
            this.label1.Text = "Quarto: ";
            // 
            // btnPesquisarReserva
            // 
            this.btnPesquisarReserva.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarReserva.Location = new System.Drawing.Point(114, 500);
            this.btnPesquisarReserva.Name = "btnPesquisarReserva";
            this.btnPesquisarReserva.Size = new System.Drawing.Size(92, 23);
            this.btnPesquisarReserva.TabIndex = 110;
            this.btnPesquisarReserva.Text = "Pesquisar Check-in";
            this.btnPesquisarReserva.UseVisualStyleBackColor = true;
            this.btnPesquisarReserva.Click += new System.EventHandler(this.btnPesquisarReserva_Click);
            // 
            // FormCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(919, 647);
            this.Controls.Add(this.btnPesquisarReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridReservas);
            this.Controls.Add(this.pictureBox2);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCheckin";
            this.Text = "FormCheckin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartosLivres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientesCheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservas)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridReservas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisarReserva;
    }
}