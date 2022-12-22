using Negocio;
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
    public partial class Factura : Form
    {
        cls_Factura objeto5 = new cls_Factura();
        public Factura()
        {
            InitializeComponent();
            Mostrar1();
        }

      
       
        private void Mostrar1()
        {

            cls_Factura objetoCN = new cls_Factura();
            dataGridView2.DataSource = objetoCN.MostrarTabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                
                objeto5.Insertar_Venta(txt_ID_Produ.Text, txt_Cedula.Text, txt_canti.Text, txt_venta.Text);
                MessageBox.Show("Datos ingresados correctamente");
                txt_ID_Produ.Clear();
                txt_Cedula.Clear();
                txt_canti.Clear();
                txt_venta.Clear();
                Mostrar1();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar los datos: " + ex);
            }
            txt_ID_Produ.Clear();
            txt_Cedula.Clear();
            txt_canti.Clear();
            txt_venta.Clear();
        }
    }
    
}
