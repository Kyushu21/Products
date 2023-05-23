using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible=false;
            btnRestaurar.Visible=true;

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Form1
            Form1 form1 = new Form1();

            // Establecer TopLevel en false para que se pueda agregar al Panel
            form1.TopLevel = false;

            // Agregar el formulario al Panel Contenedor
            Contenedor.Controls.Add(form1);

            // Ajustar el tamaño del formulario al tamaño del Panel
            form1.Size = Contenedor.Size;

            // Ajustar la posición del formulario en el Panel
            form1.Location = new Point(0, 0);

            // Mostrar el formulario
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de confirmación al usuario
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Confirmar cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Crear una instancia del formulario "Login"
                Login loginForm = new Login();

                // Mostrar el formulario "Login"
                loginForm.Show();

                // Cerrar el formulario actual
                this.Close();
            }
        }


    }
}
