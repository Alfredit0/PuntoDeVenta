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
    public partial class ArticulosActualizar : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        Login login = new Login();
        public ArticulosActualizar()
        {
            InitializeComponent();
            login.declararConexiones();
            login.abrirConexionVentas();


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            login.abrirConexionVentas();
            String cajaDeTexto = "" + textBuscar.Text + "";
            if ((textBuscar.Text != "") && (textCodigoAlt.Text == ""))
            { cajaDeTexto = "" + textBuscar.Text + ""; }
            else if ((textBuscar.Text == "") && (textCodigoAlt.Text != ""))
            { cajaDeTexto = "" + textCodigoAlt.Text + ""; }
            else if ((textBuscar.Text != "") && (textCodigoAlt.Text != ""))
            { MessageBox.Show("Ingrese solo el codigo del producto o el codigo alterno"); }
            else
            { MessageBox.Show("Ingrese un codigo o en su defecto un codigo alterno"); }
            try
            {
                cmd = new SqlCommand("SELECT A.CODIGOPRODUCTO as CODIGO, A.DESCRIPCION as DESCRIPCION, A.PRECIOVENTA as PRECIO, A.COSTO as COSTO, A.IVAPORCENTAJE as IVAPOR, B.RAZONSOCIAL as PROVEEDOR, A.CODEALTER as CODALTERNO FROM ARTICULOS as A inner join CLIENTEPROVEEDOR as B on A.IdProveedor = B.IdClienteProveedor WHERE A.CODIGOPRODUCTO='" + cajaDeTexto + "'", login.VENTAS);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBuscar.Text = dr["CODIGO"].ToString();
                    textCodigoAlt.Text = dr["CODALTENO"].ToString();
                    richTextDescripcion.Text = dr["DESCRIPCION"].ToString();
                    textPrecioV.Text = dr["PRECIO"].ToString();
                    textCosto.Text = dr["COSTO"].ToString();
                    textPorcIva.Text = dr["IVAPOR"].ToString();
                    comboProveedor.Text = dr["PROVEEDOR"].ToString();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}