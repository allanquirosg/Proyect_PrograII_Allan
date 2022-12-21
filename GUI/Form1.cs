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
    public partial class Form1 : Form
    {
        cls_negocio objeto = new cls_negocio();
        private bool Editar = false;

        public Form1()
        {
            InitializeComponent();
            Mostrar();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Mostrar()
        {

            cls_negocio objetoCN = new cls_negocio();
            dataGridView1.DataSource = objetoCN.MostrarTabla();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_producto_TextChanged(object sender, EventArgs e)
        {



        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bnt_editar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txt_id_producto.Text = dataGridView1.CurrentRow.Cells["ID_PRODUCTO"].Value.ToString();
                txt_nombre_producto.Text = dataGridView1.CurrentRow.Cells["NOMBRE_PRODUCTO"].Value.ToString();
                txt_precio.Text = dataGridView1.CurrentRow.Cells["PRECIO"].Value.ToString();

            }
            else
                MessageBox.Show("seleccione una fila por favor");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                objeto.Insertar(txt_id_producto.Text, txt_nombre_producto.Text, txt_precio.Text);
                MessageBox.Show("Listo"); Mostrar(); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            if (Editar == true)
            {

                try
                {
                    objeto.Editar(txt_id_producto.Text, txt_nombre_producto.Text, txt_precio.Text);
                    MessageBox.Show("Listo");
                    Mostrar();
                   
                    Editar = false;
                    txt_id_producto.Clear();
                    txt_nombre_producto.Clear();
                    txt_precio.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }




        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void Cerrar(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_id_producto.Clear();
            txt_nombre_producto.Clear();
            txt_precio.Clear();
        }
    }
}
