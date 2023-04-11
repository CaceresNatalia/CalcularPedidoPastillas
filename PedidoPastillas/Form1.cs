using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidoPastillas
{
    public partial class frmPedidoPastillas : Form
    {
        List<Pastilla> pedidoPastillas = new List<Pastilla>();
        
        public frmPedidoPastillas()
        {
            InitializeComponent();
                    }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Pastilla pastilla = new Pastilla();
            pastilla.Nombre = txbNombre.Text;
            pastilla.UxBlister = txbUxBlister.Text;
            pastilla.DosisDiaria = txbDosisDiaria.Text;
            pastilla.Blisters = txbBlisters.Text;
            pastilla.Sueltas = txbSueltas.Text;

            pastilla.Dias = txbPedido.Text;

            pedidoPastillas.Add(pastilla);

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }




        }
                
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
            foreach (Pastilla item in pedidoPastillas)
            {
                lsbMostrarPedido.Items.Add(item);
            }
        }
    }
}
