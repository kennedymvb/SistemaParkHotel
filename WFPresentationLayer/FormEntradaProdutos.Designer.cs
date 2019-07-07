namespace WFPresentationLayer
{
    partial class FormEntradaProdutos
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
            this.label55 = new System.Windows.Forms.Label();
            this.dateTimeEntrada = new System.Windows.Forms.DateTimePicker();
            this.btnProximaPagina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(243, 80);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(159, 20);
            this.label55.TabIndex = 108;
            this.label55.Text = "Data da compra do Lote";
            // 
            // dateTimeEntrada
            // 
            this.dateTimeEntrada.Location = new System.Drawing.Point(421, 80);
            this.dateTimeEntrada.Name = "dateTimeEntrada";
            this.dateTimeEntrada.Size = new System.Drawing.Size(136, 20);
            this.dateTimeEntrada.TabIndex = 111;
            // 
            // btnProximaPagina
            // 
            this.btnProximaPagina.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximaPagina.Location = new System.Drawing.Point(353, 304);
            this.btnProximaPagina.Name = "btnProximaPagina";
            this.btnProximaPagina.Size = new System.Drawing.Size(150, 22);
            this.btnProximaPagina.TabIndex = 110;
            this.btnProximaPagina.Text = "Próxima Página";
            this.btnProximaPagina.UseVisualStyleBackColor = true;
            this.btnProximaPagina.Click += new System.EventHandler(this.btnProximaPagina_Click);
            // 
            // FormEntradaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.dateTimeEntrada);
            this.Controls.Add(this.btnProximaPagina);
            this.Name = "FormEntradaProdutos";
            this.Text = "FormEntradaProdutos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.DateTimePicker dateTimeEntrada;
        private System.Windows.Forms.Button btnProximaPagina;
    }
}