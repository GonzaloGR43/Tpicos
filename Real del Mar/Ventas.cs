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
            if (pg.ShowDialog() == DialogResult.OK) ;
            refescodecola();

        }
        public void refescodecola()
        {
            try
            {
                //Actualizar datos 
                conexion.AbrirConexion();
                string Query = "select * from realdelmar.ventas";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion._conexion);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dgvventas.DataSource = dTable;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btngpp_Click(object sender, EventArgs e)
        {
     
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            try
            {
                refescodecola();

                //Se comparan las fechas para veificar si estan vencidas
                foreach (DataGridViewRow row in dgvventas.Rows)
                {
                    
                    if(row.Cells["Fecha_de_Pago"].Value==null)                   
                        continue;
                    
                   else if(row.Cells["Status"].Value.ToString() == "Cancelado")                   
                        continue;
                    
                    DateTime Fechactual = DateTime.Now;
                    string fechacreacion = row.Cells["Fecha_de_Pago"].Value.ToString();
                    DateTime FC = Convert.ToDateTime(fechacreacion);
                    int result = DateTime.Compare(Fechactual, FC);



                    if (result > 0)
                    {
                        string Estatus = "Vencido";
                        string actualizar = string.Format("update Ventas set Status =  '" + Estatus + "' where Folio = '" + row.Cells["Folio"].Value + "'");
                        MySqlCommand com = new MySqlCommand(actualizar, conexion._conexion);
                        conexion._conexion.Open();
                        com.ExecuteNonQuery();
                        conexion._conexion.Close();

                    }


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error al actualizar"+ ex.Message+" "+ex.StackTrace);
            }
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        public void btneliminar_Click(object sender, EventArgs e)
        {

            if (dgvventas.SelectedRows.Count==0 )
            {
                MessageBox.Show("Selecciona un registro primero");
                return;
            }
            else if(MessageBox.Show("¿Seguro que quieres cancelar?","Advertencia", MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes )
            {
                var folio = dgvventas.SelectedRows[0].Cells[0].Value;
                string Res = "";
                dgvventas.SelectedRows.ToString();
                try
                {
                    string Estatus = "Cancelado";
                    string actualizar = string.Format("update Ventas set Status =  '" + Estatus + "' where Folio = '" + folio + "'");
                    MySqlCommand com = new MySqlCommand(actualizar, conexion._conexion);
                    conexion._conexion.Open();
                    com.ExecuteNonQuery();
                    MessageBox.Show("Se cancelo el pagare");
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

        private void dgvventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdPrueva_Click(object sender, EventArgs e)
        {
           
        }

        public void dgvventas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            
        }
    }
}
