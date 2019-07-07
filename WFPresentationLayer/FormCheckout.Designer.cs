namespace WFPresentationLayer
{
    partial class FormCheckout
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
            this.btnPesquisarCheckin = new System.Windows.Forms.Button();
            this.dateTimeCheckoutDataSaida = new System.Windows.Forms.DateTimePicker();
            this.labelValorTotalPagar = new System.Windows.Forms.Label();
            this.txtnumeroCheckinCheckout = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.btnFinalizarHospedagem = new System.Windows.Forms.Button();
            this.lblAgora = new System.Windows.Forms.CheckBox();
            this.dataGridSelecionarCheckin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelecionarCheckin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisarCheckin
            // 
            this.btnPesquisarCheckin.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCheckin.Location = new System.Drawing.Point(301, 142);
            this.btnPesquisarCheckin.Name = "btnPesquisarCheckin";
            this.btnPesquisarCheckin.Size = new System.Drawing.Size(92, 20);
            this.btnPesquisarCheckin.TabIndex = 81;
            this.btnPesquisarCheckin.Text = "Pesquisar";
            this.btnPesquisarCheckin.UseVisualStyleBackColor = true;
            this.btnPesquisarCheckin.Click += new System.EventHandler(this.btnPesquisarCheckin_Click);
            // 
            // dateTimeCheckoutDataSaida
            // 
            this.dateTimeCheckoutDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCheckoutDataSaida.Location = new System.Drawing.Point(195, 193);
            this.dateTimeCheckoutDataSaida.Name = "dateTimeCheckoutDataSaida";
            this.dateTimeCheckoutDataSaida.Size = new System.Drawing.Size(77, 20);
            this.dateTimeCheckoutDataSaida.TabIndex = 80;
            // 
            // labelValorTotalPagar
            // 
            this.labelValorTotalPagar.AutoSize = true;
            this.labelValorTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotalPagar.Location = new System.Drawing.Point(200, 246);
            this.labelValorTotalPagar.Name = "labelValorTotalPagar";
            this.labelValorTotalPagar.Size = new System.Drawing.Size(72, 20);
            this.labelValorTotalPagar.TabIndex = 79;
            this.labelValorTotalPagar.Text = "R$ 0,00";
            // 
            // txtnumeroCheckinCheckout
            // 
            this.txtnumeroCheckinCheckout.Location = new System.Drawing.Point(195, 142);
            this.txtnumeroCheckinCheckout.Name = "txtnumeroCheckinCheckout";
            this.txtnumeroCheckinCheckout.Size = new System.Drawing.Size(62, 20);
            this.txtnumeroCheckinCheckout.TabIndex = 75;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(12, 246);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(137, 20);
            this.label56.TabIndex = 78;
            this.label56.Text = "Valor Total a Pagar:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(12, 193);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(102, 20);
            this.label57.TabIndex = 77;
            this.label57.Text = "Data da Saida:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(121, 49);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(99, 27);
            this.label58.TabIndex = 76;
            this.label58.Text = "Check-out";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold);
            this.label59.Location = new System.Drawing.Point(12, 142);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(146, 20);
            this.label59.TabIndex = 74;
            this.label59.Text = "Número do Check-in:";
            // 
            // btnFinalizarHospedagem
            // 
            this.btnFinalizarHospedagem.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarHospedagem.Location = new System.Drawing.Point(165, 361);
            this.btnFinalizarHospedagem.Name = "btnFinalizarHospedagem";
            this.btnFinalizarHospedagem.Size = new System.Drawing.Size(131, 29);
            this.btnFinalizarHospedagem.TabIndex = 73;
            this.btnFinalizarHospedagem.Text = "Finalizar Hospedagem ";
            this.btnFinalizarHospedagem.UseVisualStyleBackColor = true;
            this.btnFinalizarHospedagem.Click += new System.EventHandler(this.btnFinalizarHospedagem_Click);
            // 
            // lblAgora
            // 
            this.lblAgora.AutoSize = true;
            this.lblAgora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgora.Location = new System.Drawing.Point(301, 197);
            this.lblAgora.Name = "lblAgora";
            this.lblAgora.Size = new System.Drawing.Size(63, 19);
            this.lblAgora.TabIndex = 82;
            this.lblAgora.Text = "Agora";
            this.lblAgora.UseVisualStyleBackColor = true;
            this.lblAgora.CheckedChanged += new System.EventHandler(this.lblAgora_CheckedChanged);
            // 
            // dataGridSelecionarCheckin
            // 
            this.dataGridSelecionarCheckin.AllowUserToAddRows = false;
            this.dataGridSelecionarCheckin.AllowUserToDeleteRows = false;
            this.dataGridSelecionarCheckin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSelecionarCheckin.Location = new System.Drawing.Point(419, -1);
            this.dataGridSelecionarCheckin.Name = "dataGridSelecionarCheckin";
            this.dataGridSelecionarCheckin.ReadOnly = true;
            this.dataGridSelecionarCheckin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSelecionarCheckin.Size = new System.Drawing.Size(381, 450);
            this.dataGridSelecionarCheckin.TabIndex = 83;
            this.dataGridSelecionarCheckin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSelecionarCheckin_CellDoubleClick);
            // 
            // FormCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridSelecionarCheckin);
            this.Controls.Add(this.lblAgora);
            this.Controls.Add(this.btnPesquisarCheckin);
            this.Controls.Add(this.dateTimeCheckoutDataSaida);
            this.Controls.Add(this.labelValorTotalPagar);
            this.Controls.Add(this.txtnumeroCheckinCheckout);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.btnFinalizarHospedagem);
            this.Name = "FormCheckout";
            this.Text = "FormCheckout";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelecionarCheckin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisarCheckin;
        private System.Windows.Forms.DateTimePicker dateTimeCheckoutDataSaida;
        private System.Windows.Forms.Label labelValorTotalPagar;
        private System.Windows.Forms.TextBox txtnumeroCheckinCheckout;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Button btnFinalizarHospedagem;
        private System.Windows.Forms.CheckBox lblAgora;
        private System.Windows.Forms.DataGridView dataGridSelecionarCheckin;
    }
}