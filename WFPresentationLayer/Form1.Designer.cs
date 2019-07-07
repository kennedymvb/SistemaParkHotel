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
            this.components = new System.ComponentModel.Container();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnFazerCheckout = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnQuartos = new System.Windows.Forms.Button();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHoras = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompras
            // 
            this.btnCompras.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Location = new System.Drawing.Point(67, 134);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(93, 46);
            this.btnCompras.TabIndex = 96;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnFazerCheckout
            // 
            this.btnFazerCheckout.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazerCheckout.Location = new System.Drawing.Point(749, 132);
            this.btnFazerCheckout.Name = "btnFazerCheckout";
            this.btnFazerCheckout.Size = new System.Drawing.Size(89, 46);
            this.btnFazerCheckout.TabIndex = 95;
            this.btnFazerCheckout.Text = "Checkout";
            this.btnFazerCheckout.UseVisualStyleBackColor = true;
            this.btnFazerCheckout.Click += new System.EventHandler(this.btnFazerCheckout_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.Location = new System.Drawing.Point(280, 134);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(89, 44);
            this.btnVendas.TabIndex = 94;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.Location = new System.Drawing.Point(514, 134);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(93, 46);
            this.btnCheckin.TabIndex = 97;
            this.btnCheckin.Text = "Checkin";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(67, 240);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(93, 44);
            this.btnCliente.TabIndex = 98;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.Location = new System.Drawing.Point(280, 240);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(89, 44);
            this.btnProdutos.TabIndex = 99;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.Location = new System.Drawing.Point(514, 240);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(93, 44);
            this.btnReservas.TabIndex = 100;
            this.btnReservas.Text = "Reserva";
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnQuartos
            // 
            this.btnQuartos.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuartos.Location = new System.Drawing.Point(749, 240);
            this.btnQuartos.Name = "btnQuartos";
            this.btnQuartos.Size = new System.Drawing.Size(89, 44);
            this.btnQuartos.TabIndex = 101;
            this.btnQuartos.Text = "Quartos";
            this.btnQuartos.UseVisualStyleBackColor = true;
            this.btnQuartos.Click += new System.EventHandler(this.btnQuartos_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrador.Location = new System.Drawing.Point(399, 358);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(113, 58);
            this.btnAdministrador.TabIndex = 102;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(63, 66);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(106, 20);
            this.lblBemVindo.TabIndex = 103;
            this.lblBemVindo.Text = "Bem Vindo: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.checkinToolStripMenuItem,
            this.checkoutToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.reservaToolStripMenuItem,
            this.quartosToolStripMenuItem,
            this.administradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 24);
            this.menuStrip1.TabIndex = 104;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.comprasToolStripMenuItem.Text = "compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // checkinToolStripMenuItem
            // 
            this.checkinToolStripMenuItem.Name = "checkinToolStripMenuItem";
            this.checkinToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.checkinToolStripMenuItem.Text = "Checkin";
            this.checkinToolStripMenuItem.Click += new System.EventHandler(this.checkinToolStripMenuItem_Click);
            // 
            // checkoutToolStripMenuItem
            // 
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.checkoutToolStripMenuItem.Text = "Checkout";
            this.checkoutToolStripMenuItem.Click += new System.EventHandler(this.checkoutToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reservaToolStripMenuItem.Text = "Reserva";
            this.reservaToolStripMenuItem.Click += new System.EventHandler(this.reservaToolStripMenuItem_Click);
            // 
            // quartosToolStripMenuItem
            // 
            this.quartosToolStripMenuItem.Name = "quartosToolStripMenuItem";
            this.quartosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.quartosToolStripMenuItem.Text = "Quartos";
            this.quartosToolStripMenuItem.Click += new System.EventHandler(this.quartosToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(519, 66);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(104, 20);
            this.lblHoras.TabIndex = 105;
            this.lblHoras.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(928, 462);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.btnQuartos);
            this.Controls.Add(this.btnReservas);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnFazerCheckout);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnFazerCheckout;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnQuartos;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Timer timer1;
    }
}

