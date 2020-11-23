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
               //Actualizar datos 
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

        private void btneliminar_Click(object sender, EventArgs e)

        {
            if (dgvcliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("¿Selecciona un registro primero?", "Resgistro invalido");
                return;
            }
            else if (MessageBox.Show("Seguro que quieres Eliminar", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var folio = dgvcliente.SelectedRows[0].Cells[0].Value;
                string Res = "";
                dgvcliente.SelectedRows.ToString();
                try
                {

                    string actualizar = string.Format("Delete FROM clientes where IDClientes = '" + folio + "'");
                    MySqlCommand com = new MySqlCommand(actualizar, conexion._conexion);
                    conexion._conexion.Open();
                    com.ExecuteNonQuery();
                    MessageBox.Show("Se elimino el registro", "ELIMINADO");
                    conexion._conexion.Close();
                    refescodecola();
                }
                catch (Exception ex)
                {
                    Res = ex.Message;
                    conexion._conexion.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Creación_contrato cc = new Creación_contrato();
            cc.Show();
        }
    }
}
 