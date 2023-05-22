using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Products
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxUsuario.Text== "Usuario"&& textBoxContraseña.Text == "Admin")
            {
                Interfaz form1 = new Interfaz();
                this.Hide();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("los datos ingresados son incorrectos");
                    textBoxContraseña.Clear();
                    textBoxUsuario.Clear();
            }
        }

        private void BtMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void labelLOGIN_Click(object sender, EventArgs e)
        {

        }
    }
}
