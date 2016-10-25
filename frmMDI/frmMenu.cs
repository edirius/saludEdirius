using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDatos;
//using CapaDeNegocios;
//using CapaDeNegocios.Properties;


namespace frmMDI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void HacerConeccion()
        {
            //try
            //{
            //    Conexion.IniciarSesion(Settings.Default.ConexionMySql, "bdPersonal", "root", "root");
            //    MessageBox.Show(String.Format("{0}", "Se conecto exitosamente"));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}