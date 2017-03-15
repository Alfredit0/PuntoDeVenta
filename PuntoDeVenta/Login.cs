using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlTypes;
using System.Globalization;
using System.Data.OleDb;
namespace PuntoDeVenta
{
    public partial class Login : Form
    {
        SqlConnection VENTAS;
        SqlCommand cmd;
        SqlDataReader dr;
        public String userType;
        public int userId;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["VENTAS"].ConnectionString;
            VENTAS = new SqlConnection(connectionString);
            try {
                VENTAS.Close();
                VENTAS.Open();
                MessageBox.Show("Conexion Abiarta");
            }
            catch (Exception ex) {
                MessageBox.Show("Error al abrir la conexion");
            }
        }

        public void abrirConexionVentas() {
            VENTAS.Close();
            VENTAS.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUser.Text != ""&&textPass.Text!="")
            {
                abrirConexionVentas();

                cmd = new SqlCommand("SELECT * FROM USUARIOS WHERE NOMBRE='"+textUser.Text+"'", VENTAS);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    PuntoDeVenta.MenuDelSistema menu = new PuntoDeVenta.MenuDelSistema();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El Usuario No existe");
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
