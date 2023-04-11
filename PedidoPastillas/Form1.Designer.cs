
namespace PedidoPastillas
{
    partial class frmPedidoPastillas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoPastillas));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUxBlister = new System.Windows.Forms.Label();
            this.lblDosisDiaria = new System.Windows.Forms.Label();
            this.lblCantBlisters = new System.Windows.Forms.Label();
            this.lblSueltas = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbUxBlister = new System.Windows.Forms.TextBox();
            this.txbDosisDiaria = new System.Windows.Forms.TextBox();
            this.txbBlisters = new System.Windows.Forms.TextBox();
            this.txbSueltas = new System.Windows.Forms.TextBox();
            this.txbPedido = new System.Windows.Forms.TextBox();
            this.lsbMostrarPedido = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombre.Location = new System.Drawing.Point(179, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblUxBlister
            // 
            this.lblUxBlister.AutoSize = true;
            this.lblUxBlister.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUxBlister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUxBlister.Location = new System.Drawing.Point(179, 102);
            this.lblUxBlister.Name = "lblUxBlister";
            this.lblUxBlister.Size = new System.Drawing.Size(105, 20);
            this.lblUxBlister.TabIndex = 1;
            this.lblUxBlister.Text = "U x blister:";
            // 
            // lblDosisDiaria
            // 
            this.lblDosisDiaria.AutoSize = true;
            this.lblDosisDiaria.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDosisDiaria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDosisDiaria.Location = new System.Drawing.Point(179, 137);
            this.lblDosisDiaria.Name = "lblDosisDiaria";
            this.lblDosisDiaria.Size = new System.Drawing.Size(117, 20);
            this.lblDosisDiaria.TabIndex = 2;
            this.lblDosisDiaria.Text = "Dosis diaria:";
            // 
            // lblCantBlisters
            // 
            this.lblCantBlisters.AutoSize = true;
            this.lblCantBlisters.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantBlisters.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantBlisters.Location = new System.Drawing.Point(179, 173);
            this.lblCantBlisters.Name = "lblCantBlisters";
            this.lblCantBlisters.Size = new System.Drawing.Size(190, 20);
            this.lblCantBlisters.TabIndex = 3;
            this.lblCantBlisters.Text = "Cantidad de blisters:";
            // 
            // lblSueltas
            // 
            this.lblSueltas.AutoSize = true;
            this.lblSueltas.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueltas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSueltas.Location = new System.Drawing.Point(179, 206);
            this.lblSueltas.Name = "lblSueltas";
            this.lblSueltas.Size = new System.Drawing.Size(223, 20);
            this.lblSueltas.TabIndex = 4;
            this.lblSueltas.Text = "Pastillas sueltas (0 o +):";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDias.Location = new System.Drawing.Point(179, 273);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(138, 20);
            this.lblDias.TabIndex = 5;
            this.lblDias.Text = "Días por pedir:";
            // 
            // txbNombre
            // 
            this.txbNombre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNombre.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(472, 66);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(151, 21);
            this.txbNombre.TabIndex = 6;
            // 
            // txbUxBlister
            // 
            this.txbUxBlister.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txbUxBlister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUxBlister.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUxBlister.Location = new System.Drawing.Point(523, 102);
            this.txbUxBlister.Name = "txbUxBlister";
            this.txbUxBlister.Size = new System.Drawing.Size(100, 21);
            this.txbUxBlister.TabIndex = 7;
            // 
            // txbDosisDiaria
            // 
            this.txbDosisDiaria.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txbDosisDiaria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDosisDiaria.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDosisDiaria.Location = new System.Drawing.Point(523, 137);
            this.txbDosisDiaria.Name = "txbDosisDiaria";
            this.txbDosisDiaria.Size = new System.Drawing.Size(100, 21);
            this.txbDosisDiaria.TabIndex = 8;
            // 
            // txbBlisters
            // 
            this.txbBlisters.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txbBlisters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBlisters.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBlisters.Location = new System.Drawing.Point(523, 172);
            this.txbBlisters.Name = "txbBlisters";
            this.txbBlisters.Size = new System.Drawing.Size(100, 21);
            this.txbBlisters.TabIndex = 9;
            // 
            // txbSueltas
            // 
            this.txbSueltas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txbSueltas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSueltas.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSueltas.Location = new System.Drawing.Point(523, 206);
            this.txbSueltas.Name = "txbSueltas";
            this.txbSueltas.Size = new System.Drawing.Size(100, 21);
            this.txbSueltas.TabIndex = 10;
            // 
            // txbPedido
            // 
            this.txbPedido.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txbPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPedido.Location = new System.Drawing.Point(523, 272);
            this.txbPedido.Name = "txbPedido";
            this.txbPedido.Size = new System.Drawing.Size(100, 21);
            this.txbPedido.TabIndex = 11;
            // 
            // lsbMostrarPedido
            // 
            this.lsbMostrarPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbMostrarPedido.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbMostrarPedido.FormattingEnabled = true;
            this.lsbMostrarPedido.HorizontalScrollbar = true;
            this.lsbMostrarPedido.ItemHeight = 18;
            this.lsbMostrarPedido.Location = new System.Drawing.Point(64, 415);
            this.lsbMostrarPedido.Name = "lsbMostrarPedido";
            this.lsbMostrarPedido.ScrollAlwaysVisible = true;
            this.lsbMostrarPedido.Size = new System.Drawing.Size(674, 144);
            this.lsbMostrarPedido.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Maroon;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.SeaShell;
            this.btnAgregar.Location = new System.Drawing.Point(183, 327);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(154, 58);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Maroon;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.SeaShell;
            this.btnMostrar.Location = new System.Drawing.Point(469, 327);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(154, 58);
            this.btnMostrar.TabIndex = 14;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmPedidoPastillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lsbMostrarPedido);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txbPedido);
            this.Controls.Add(this.txbSueltas);
            this.Controls.Add(this.txbBlisters);
            this.Controls.Add(this.txbDosisDiaria);
            this.Controls.Add(this.txbUxBlister);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblSueltas);
            this.Controls.Add(this.lblCantBlisters);
            this.Controls.Add(this.lblDosisDiaria);
            this.Controls.Add(this.lblUxBlister);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPedidoPastillas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido Pastillas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUxBlister;
        private System.Windows.Forms.Label lblDosisDiaria;
        private System.Windows.Forms.Label lblCantBlisters;
        private System.Windows.Forms.Label lblSueltas;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbUxBlister;
        private System.Windows.Forms.TextBox txbDosisDiaria;
        private System.Windows.Forms.TextBox txbBlisters;
        private System.Windows.Forms.TextBox txbSueltas;
        private System.Windows.Forms.TextBox txbPedido;
        private System.Windows.Forms.ListBox lsbMostrarPedido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrar;
    }
}

