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
 
    Declarar un arreglo longitud de 4 
    2 inicializar 
    2 espacios del arreglo capturar en un TextBox 
    Validación (en las texbox solo se puede ingresar números) 
    Sacar el promedio de los 4 valores 
    Imprimir en MessageBox con el icono de información y el título de MessageBox tenga el nombre de resultado y el resultado.

     */
namespace Examen
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        public void ejercicio2()
        {
            double promedio = 0;
            double[] arreglo = new double[4];
            arreglo[0] = 10;
            arreglo[1] = 10;
            arreglo[2] = Convert.ToDouble(txtVariable1.Text);
            arreglo[3] = Convert.ToDouble(txtVariable2.Text);

            for(int i=0; i < arreglo.Length; i++)
            {
                promedio += arreglo[i];
            }

            MessageBox.Show("El Promedio es: " + promedio/4, "Resultado",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            ejercicio2();
        }

        //Validacion solo numeros con 1 decimal

        private void txtVariable1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
 
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //Validacion solo numeros con 1 decimal

        private void txtVariable2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
