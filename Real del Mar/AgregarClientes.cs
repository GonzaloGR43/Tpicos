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
    public partial class AgregarClientes : Form
    {
        Conexion conexion = new Conexion();

        
        public AgregarClientes()
        {
            InitializeComponent();
        }

        private void btnagregarcliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes c = new Clientes();
        }

        private void btncancelarcliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes c = new Clientes();
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblnombrecliente_Click(object sender, EventArgs e)
        {

        }

        private void btnagregarcliente_Click_1(object sender, EventArgs e)
        {
            string Res = "holi";
            string query=string.Format("insert into clientes(Nombre_Cliente, Apellido_P, Apellido_M, Clave_Terrenos, IDContrato) " +
                "values('{0}', '{1}', '{2}','{3}',{4})", txtnombrecliente.Text,txtapellidopaterno.Text, txtapellidomaterno.Text,cbterrenos.Text, 1 );
            MySqlCommand com = new MySqlCommand(query, conexion._conexion);
            try
            {
                conexion._conexion.Open();
                com.ExecuteNonQuery();
                Res = "Fierro";
                conexion._conexion.Close();
            }
            catch (Exception ex)
            {
                Res = ex.Message;
                conexion._conexion.Close();
            }

            MessageBox.Show(Res, "Precaution");


        }

        private void btncancelarcliente_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Clientes c = new Clientes();
        }

        private void cbterrenos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Btn_AC_AgregarT_Click(object sender, EventArgs e)
        {

        }
    }
}
