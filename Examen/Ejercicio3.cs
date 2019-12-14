using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Autor: Abel Pech
 Examen de Apoyo Programacion
 
    Desarrollar un FOR
    Inicializar en 1
    Incrementar en 1
    Hasta llegar a numero estipulado en TextBox
    Imprimir mensaje

     */

namespace Examen
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void ejercicio3()
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            int contador = 0;
            for (int i= 1; i <= numero; i++)
            {
                contador++;
            }
            MessageBox.Show("Contamos: " + contador + " veces", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            ejercicio3();
        }
    }
}
