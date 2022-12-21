using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingresoArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Ven1 = new Form1();
            Ven1.ShowDialog();

            login Cerrar = new login();
            Cerrar.Visible=false;

           
        }

        private void acercaDeNosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es un software desarrollado por estudiantes de la carrera \n" +
                "de ingenieria en Sistema de la Universidad America.");
        }

        private void Cierre(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registro_login VenLogin = new registro_login();
            VenLogin.ShowDialog();
            
        }

        private void agregarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registro_empresa RegEmpresa = new registro_empresa();
            RegEmpresa.ShowDialog();

        }
    }
}
