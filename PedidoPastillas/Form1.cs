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
    {   //Acá se crea una lista donde se va a guardar cada objeto (pastilla) creado.
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
            //cada vez que se llenen los datos (propiedades) de cada pastilla, se guardan en la 
            // lista para mostrarlos luego en el campo de abajo.
            pedidoPastillas.Add(pastilla);

            //este bucle, cada vez que se pulsa el botón "Agregar" y se guarda la info ingresada
            //vuelve a dejar en blanco los campos de texto para volver a ingresar los datos
            //de la siguiente pastilla.

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }




        }
        //El botón "Mostrar" refleja en el ListBox de abajo todos los ingresos que se fueron
        //agregando a la lista.
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
            foreach (Pastilla item in pedidoPastillas)
            {
                lsbMostrarPedido.Items.Add(item);
            }
        }
    }
}
