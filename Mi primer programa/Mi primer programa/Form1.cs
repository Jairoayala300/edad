using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mi_primer_programa.Modelos;

namespace Mi_primer_programa
   
{
    public partial class Frmpersona : Form
    {
        public Frmpersona()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            cPersonas p = new cPersonas();
            p.setNombre(txtNombre.Text.Trim());
            p.setAñoNac(int.Parse(txtAñoNac.Text.Trim()));
            txtEdad.Text = "" + p.CalcularEdad();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtAñoNac.Text = "";
            txtEdad.Text = "";
            txtNombre.Focus();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblaño_Click(object sender, EventArgs e)
        {

        }
    }
}
