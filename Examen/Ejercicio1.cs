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
 
    4 variables 
    2 inicializadas 
    2 capturar de tex box respectivamente 
    Concatenar las 4 variables y desplegar en un Label 
    Se ejecuta con un botón 
    Segundo botón para que se limpie los Texbox y las 2 variables inicializadas se mantengan igual

     */
namespace Examen
{
    public partial class Ejercicio1 : Form
    {
        string variable3 = "Abel";
        string variable4 = "Pech";

        public Ejercicio1()
        {
            InitializeComponent();
        }

        public void ejercicio1()
        {
            string variable1 = txtVariable1.Text;
            string variable2 = txtVariable2.Text;
            

            lconcatenar.Text = variable1 + " " + variable2 + " " + variable3 + " " + variable4;

        }

        public void limpiar()
        {
            txtVariable1.Text = "";
            txtVariable2.Text = "";
            lconcatenar.Text = variable3 + " " + variable4;
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            ejercicio1();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
