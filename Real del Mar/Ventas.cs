using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_del_Mar
{
    public partial class Ventas : Form
    {
        Conexion conexion = new Conexion();

        public Ventas()
        {
            InitializeComponent();
        }

        private void btnagregarpagare_Click(object sender, EventArgs e)
        {
          

            GenerarPagare pg = new GenerarPagare();
            pg.Show();
        }

        private void btngpp_Click(object sender, EventArgs e)
        {
     
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            try
            {
                //Mostrar los datos de Mysql a C#
                conexion.AbrirConexion();

            

                string Query = "select * from realdelmar.ventas";
                
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion._conexion);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dgvventas.DataSource = dTable;
                conexion.CerrarConeccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
