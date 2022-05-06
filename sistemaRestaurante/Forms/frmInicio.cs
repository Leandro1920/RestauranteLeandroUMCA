using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sistemaRestaurante.vistas
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     

       
        private void inicio_Load(object sender, EventArgs e)
        {
       
   
           
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAgregarUsuario().Show();
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmEliminarUsuario().Show();
        }

        private void agragarClienteFrecuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmClienteFrecuente().Show();
        }

        private void eliminarClienteFrecuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmEliminarClienteFrecuente().Show();
        }

        private void distribucionDeLasMesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new mesas().Show();
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmOrden().Show(); ;
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new productosEingredientes().Show();
        }

        private void almacenDeIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new admoningredientes().Show();
        }

        private void agregarClienteFrecuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
