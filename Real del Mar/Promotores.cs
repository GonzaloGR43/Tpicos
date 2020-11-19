using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_del_Mar
{
    public partial class Promotores : Form
    {

        Conexion conexion = new Conexion();

        public Promotores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Promotor_Click(object sender, EventArgs e)
        {
            Agregar_Promotor ap = new Agregar_Promotor();
            ap.Show();
        }

        private void Promotores_Load(object sender, EventArgs e)
        {
            try
            {
                //Mostrar los datos de Mysql a C#
                conexion.AbrirConexion();

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=Hola...264";

                string Query = "select * from realdelmar.ventas";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dgvpromo.DataSource = dTable;
                conexion.CerrarConeccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
