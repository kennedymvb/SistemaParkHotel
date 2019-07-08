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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuartos));
            this.dataGridViewQuartos = new System.Windows.Forms.DataGridView();
            this.btnExibirQuartos = new System.Windows.Forms.Button();
            this.cmbTipoQuarto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.CadastrarQuarto = new System.Windows.Forms.Button();
            this.label52 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuartos
            // 
            this.dataGridViewQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuartos.Location = new System.Drawing.Point(600, 2);
            this.dataGridViewQuartos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewQuartos.Name = "dataGridViewQuartos";
            this.dataGridViewQuartos.Size = new System.Drawing.Size(583, 559);
            this.dataGridViewQuartos.TabIndex = 65;
            // 
            // btnExibirQuartos
            // 
            this.btnExibirQuartos.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirQuartos.Location = new System.Drawing.Point(235, 392);
            this.btnExibirQuartos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExibirQuartos.Name = "btnExibirQuartos";
            this.btnExibirQuartos.Size = new System.Drawing.Size(157, 28);
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
            this.cmbTipoQuarto.Location = new System.Drawing.Point(158, 206);
            this.cmbTipoQuarto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoQuarto.Name = "cmbTipoQuarto";
            this.cmbTipoQuarto.Size = new System.Drawing.Size(160, 24);
            this.cmbTipoQuarto.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Valor Diária:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Tipo de Quarto:";
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Location = new System.Drawing.Point(158, 256);
            this.txtValorDiaria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(160, 22);
            this.txtValorDiaria.TabIndex = 60;
            // 
            // CadastrarQuarto
            // 
            this.CadastrarQuarto.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarQuarto.Location = new System.Drawing.Point(51, 392);
            this.CadastrarQuarto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CadastrarQuarto.Name = "CadastrarQuarto";
            this.CadastrarQuarto.Size = new System.Drawing.Size(157, 28);
            this.CadastrarQuarto.TabIndex = 59;
            this.CadastrarQuarto.Text = "Cadastrar Quarto";
            this.CadastrarQuarto.UseVisualStyleBackColor = true;
            this.CadastrarQuarto.Click += new System.EventHandler(this.CadastrarQuarto_Click);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(189, 33);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(308, 44);
            this.label52.TabIndex = 58;
            this.label52.Text = "Cadastro de Quarto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 132;
            this.pictureBox1.TabStop = false;
            // 
            // FormQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1180, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewQuartos);
            this.Controls.Add(this.btnExibirQuartos);
            this.Controls.Add(this.cmbTipoQuarto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorDiaria);
            this.Controls.Add(this.CadastrarQuarto);
            this.Controls.Add(this.label52);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormQuartos";
            this.Text = "FormQuartos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}