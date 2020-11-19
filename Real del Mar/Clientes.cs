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
    public partial class Clientes : Form
    {

        Conexion conexion = new Conexion();

        public Clientes()
        {
            InitializeComponent();
        }

        private void btnagregarclientes_Click(object sender, EventArgs e)
        {
            AgregarClientes ac = new AgregarClientes();
            if (ac.ShowDialog() == DialogResult.OK) ;        
                refescodecola();
    
            
        }

        public void refescodecola()
        {
            try
            {
                //Mostrar los datos de Mysql a C#
                conexion.AbrirConexion();



                string Query = "select * from realdelmar.clientes";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion._conexion);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dgvcliente.DataSource = dTable;
                conexion.CerrarConeccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

         public void Clientes_Load(object sender, EventArgs e)
        {

            refescodecola();
            
        }

        private void dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
 