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
    public partial class Agregar_Promotor : Form
    {

        Conexion conexion = new Conexion();

        public Agregar_Promotor()
        {
            InitializeComponent();
        }

        private void btncancelarcliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Promotores p = new Promotores();
          ;
        }

        private void btnagregarcliente_Click(object sender, EventArgs e)
        {
            if (txtnombre_Promotor.Text==""|| txtApellidoPa_Promotor.Text==""|| txtApellidoMa_Promotor.Text==""|| txtcomision.Text==""|| cbterrenos.SelectedIndex==0)
            {
                MessageBox.Show("No puede dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                //Insertar datos
                string Res = " ";
                string query = string.Format("insert into promotores(Clave_Terreno,Nombre_Promotor,Apellido_P,Apellido_M,Comision) " +
                    "values('{0}', '{1}', '{2}','{3}',{4})", cbterrenos.Text, txtnombre_Promotor.Text, txtApellidoPa_Promotor.Text, txtApellidoMa_Promotor.Text, txtcomision.Text);
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
                Promotores p = new Promotores();
            }
      
        }

        private void cbterrenos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        DataTable dtpromotor = new DataTable();

        public void cargarcombobox()
        {
            try
            {
                string query = "SELECT Clave_Terreno from promotores";
                MySqlDataAdapter adp = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand(query, conexion._conexion);
                adp.SelectCommand = cmd;

                adp.Fill(dtpromotor);

                foreach (DataRow row in dtpromotor.Rows)
                {
                    cbterrenos.Items.Add(row[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

        }

        private void Agregar_Promotor_Load(object sender, EventArgs e)
        {
            cargarcombobox();
        }

        private void txtnombre_Promotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void txtApellidoPa_Promotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void txtApellidoMa_Promotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void txtcomision_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numerosdecimal(e);
        }
    }
}
