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
    public partial class registro_login : Form
    {

        cls_Usuario objeto1 = new cls_Usuario();
        private bool Editar = false;
        public registro_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {

                objeto1.Insertar_Usuario(txt_IDUsu.Text, txtUsuario.Text, txtContra.Text, txtRol.Text);
                MessageBox.Show("Datos ingresados correctamente");
                txt_IDUsu.Clear();
                txtUsuario.Clear();
                txtContra.Clear();
                txtRol.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar los datos: " + ex);
            }
           /* if (Editar == true)
            {

                try
                {
                    objeto.Editar(txt_id_producto.Text, txt_nombre_producto.Text, txt_precio.Text);
                    MessageBox.Show("Listo");
                    Mostrar();

                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }

            */
        }

        private void txtContra_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_IDUsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_IDUsu.Clear();
            txtUsuario.Clear();
            txtContra.Clear();
            txtRol.Clear();
        }
    }
}
