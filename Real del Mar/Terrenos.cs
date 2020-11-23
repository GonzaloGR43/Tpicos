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
    public partial class Terrenos : Form
    {
        Conexion conexion = new Conexion();

        public Terrenos()
        {
            InitializeComponent();
        }

        private void btnagregarterrenos_Click(object sender, EventArgs e)
        {
            AgregarTerrenos at = new AgregarTerrenos();
            if (at.ShowDialog() == DialogResult.OK) ;
            refescodecola();
        }
        public void refescodecola()
        {
            try
            {
                //Actualizar datos 
                conexion.AbrirConexion();
                string Query = "select * from realdelmar.terrenos";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion._conexion);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dvgterreno.DataSource = dTable;
                conexion.CerrarConeccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Informacion i = new Informacion();
            i.Show();
        }

        private void Terrenos_Load(object sender, EventArgs e)
        {
            try
            {

                //Actualizar datos 
                conexion.AbrirConexion();
                string Query = "select * from realdelmar.terrenos";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion._conexion);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dvgterreno.DataSource = dTable;               
                conexion._conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void btneliminar_Click(object sender, EventArgs e)
        {


            if (dvgterreno.SelectedRows.Count == 0)
            {
                MessageBox.Show("¿Selecciona un registro primero?", "Resgistro invalido");
                return;
            }
            else if (MessageBox.Show("Seguro que quieres Eliminar", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var folio = dvgterreno.SelectedRows[0].Cells[0].Value;
                string Res = "";
                dvgterreno.SelectedRows.ToString();
                try
                {
                    string Estatus = "Cancelado";
                    string actualizar = string.Format("Delete FROM terrenos where IDTerrenos = '" + folio + "'");
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

        private void dvgterreno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
