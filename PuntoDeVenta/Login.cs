using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUser.Text != ""&&textPass.Text!="")
            {
                if (textUser.Text == "SA" && textPass.Text == "unsis806")
                {
                    PuntoDeVenta.MenuDelSistema menu = new PuntoDeVenta.MenuDelSistema();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseñas incorrectos");
                }
            }
            else { MessageBox.Show("Indtroduzca un Usuario y contraseña Válidos Por favor");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
