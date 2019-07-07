namespace WFPresentationLayer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnFazerCheckout = new System.Windows.Forms.Button();
            this.btnProximaPagina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(526, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 49);
            this.button1.TabIndex = 96;
            this.button1.Text = "Cadastrar Entrada";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnFazerCheckout
            // 
            this.btnFazerCheckout.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazerCheckout.Location = new System.Drawing.Point(249, 287);
            this.btnFazerCheckout.Name = "btnFazerCheckout";
            this.btnFazerCheckout.Size = new System.Drawing.Size(131, 29);
            this.btnFazerCheckout.TabIndex = 95;
            this.btnFazerCheckout.Text = "Fazer Checkout";
            this.btnFazerCheckout.UseVisualStyleBackColor = true;
            // 
            // btnProximaPagina
            // 
            this.btnProximaPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximaPagina.Location = new System.Drawing.Point(290, 146);
            this.btnProximaPagina.Name = "btnProximaPagina";
            this.btnProximaPagina.Size = new System.Drawing.Size(171, 64);
            this.btnProximaPagina.TabIndex = 94;
            this.btnProximaPagina.Text = "Cadastrar Venda";
            this.btnProximaPagina.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(928, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFazerCheckout);
            this.Controls.Add(this.btnProximaPagina);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFazerCheckout;
        private System.Windows.Forms.Button btnProximaPagina;
    }
}

