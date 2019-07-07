namespace WFPresentationLayer
{
    partial class FormSelecionarCheckin
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
            this.dataGridDialog1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDialog1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDialog1
            // 
            this.dataGridDialog1.AllowUserToAddRows = false;
            this.dataGridDialog1.AllowUserToDeleteRows = false;
            this.dataGridDialog1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDialog1.Location = new System.Drawing.Point(-2, -2);
            this.dataGridDialog1.Name = "dataGridDialog1";
            this.dataGridDialog1.ReadOnly = true;
            this.dataGridDialog1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDialog1.Size = new System.Drawing.Size(757, 394);
            this.dataGridDialog1.TabIndex = 0;
            // FormSelecionarCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 393);
            this.Controls.Add(this.dataGridDialog1);
            this.Name = "FormSelecionarCheckin";
            this.Text = "FormDialog";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDialog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDialog1;
    }
}