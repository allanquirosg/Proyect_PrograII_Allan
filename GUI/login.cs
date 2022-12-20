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
    public partial class login : Form
    {

        CLS_ConexionBD conn = new CLS_ConexionBD("Data Source=DESKTOP-OIQSSMB\\SQLEXPRESS;Initial Catalog=FARMACIA;Integrated Security=True");

        public login()
        {
            InitializeComponent();
        }

        private void txbusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string[] arr_usuario = new string[1];
            arr_usuario = conn.m_validaringreso(txbusuario.Text, txbpassword.Text);
            string user, admin;
            if (arr_usuario.Contains(null))
            {
                MessageBox.Show("Usuario o password incorrectos");
            }
            else
            {
                user = arr_usuario[0];
                admin = arr_usuario[1];
                MessageBox.Show("Bienvenido al sistema");

                Form1 objForm = new Form1();
                objForm.ShowDialog();
                this.Hide();

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
