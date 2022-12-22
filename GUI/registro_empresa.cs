using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace GUI
{
    public partial class registro_empresa : Form
    {


        clsEmpresa objeto5 = new clsEmpresa();
        public registro_empresa()
        {
            InitializeComponent();
            Mostrar3();
        }

        private void Mostrar3()
        {

            clsEmpresa objetoCN = new clsEmpresa();
            dataGridView3.DataSource = objetoCN.MostrarTabla();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Cedula.Clear();
            txtEmpresa.Clear();
            txtTipo.Clear();

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {

                objeto5.Insertar_Empresa(txt_Cedula.Text, txtEmpresa.Text, txtTipo.Text);
                MessageBox.Show("Datos ingresados correctamente");
                txt_Cedula.Clear();
                txtEmpresa.Clear();
                txtTipo.Clear();
                Mostrar3();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar los datos: " + ex);
            }
            txt_Cedula.Clear();
            txtEmpresa.Clear();
            txtTipo.Clear();
        }

        private void txt_Cedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


