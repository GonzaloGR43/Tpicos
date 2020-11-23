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
    public partial class AgregarTerrenos : Form
    {
        Conexion conexion = new Conexion();
        
        public AgregarTerrenos()
        {
            InitializeComponent();
        }

        private void btnguardarterreno_Click(object sender, EventArgs e)
        {
            if (txtclaveterreno.Text==""||txtprecio.Text==""||txtsuperficie.Text==""||txtdescuento.Text=="")
            {
                MessageBox.Show("No puede dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                //Insertar datos
                string Res = " ";
                string query = string.Format("insert into terrenos(Clave_Terrenos, Precio, Superficie,Cliente,Descuento,Abonado,Restante) " +
                    "values('{0}',{1},{2},'{3}',{4},{5},{6},{7})", txtclaveterreno.Text, txtprecio.Text, txtsuperficie.Text, "Pendiente", txtdescuento.Text, 0, txtprecio.Text);
                MySqlCommand com = new MySqlCommand(query, conexion._conexion);
                try
                {
                    conexion._conexion.Open();
                    com.ExecuteNonQuery();
                    Res = "Datos guardados exitosamente.";
                    conexion._conexion.Close();
                }
                catch (Exception ex)
                {
                    Res = ex.Message;
                    conexion._conexion.Close();
                }

                MessageBox.Show(Res, "Ha ocurrido un error.");

                this.Hide();
                Terrenos t = new Terrenos();
            }
        }

        private void btncancelarterreno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Terrenos t = new Terrenos();

        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numerosdecimal(e);
        }

        private void txtsuperficie_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numerosdecimal(e);
        }

        private void txtdescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numerosdecimal(e);
        }

        private void AgregarTerrenos_Load(object sender, EventArgs e)
        {

        }
    }
}
