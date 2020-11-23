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
            if (ap.ShowDialog() == DialogResult.OK) ;
            refescodecola();
        }

        public void refescodecola()
        {
            try
            {
                //Actualizar datos 
                conexion.AbrirConexion();
                string Query = "select * from realdelmar.promotores";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion._conexion);

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

        private void Promotores_Load(object sender, EventArgs e)
        {
            refescodecola();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvpromo.SelectedRows.Count == 0)
            {
                MessageBox.Show("¿Selecciona un registro primero?", "Resgistro invalido");
                return;
            }
            else if (MessageBox.Show("Seguro que quieres Eliminar", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var folio = dgvpromo.SelectedRows[0].Cells[0].Value;
                string Res = "";
                dgvpromo.SelectedRows.ToString();
                try
                {
                    
                    string actualizar = string.Format("Delete FROM promotores where Clave_Terreno = '" + folio + "'");
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
    }
}
