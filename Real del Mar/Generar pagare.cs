using Google.Protobuf.WellKnownTypes;
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
    public partial class GenerarPagare : Form
    {
        Conexion conexion = new Conexion();
       

        public GenerarPagare()
        {
            InitializeComponent();
        }

        private void btnagregarpagare_Click(object sender, EventArgs e)
        {
            if (CBClienteGenerarPgare.SelectedIndex == 0 || txtPersonaFisica_GP.Text == " " || txtLugarPago_GP.Text == "" || txtDireccion_GP.Text == ""
                || txtPoblacion_GP.Text == "" || txtCantidad_GP.Text == "" || txtDescuento_GP.Text == "" || txtIntereses_GP.Text=="")
            {

                MessageBox.Show("No puede dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                //Comparar fechas
                DateTime Fechactual = DateTime.Parse(lblFecha.Text);

                string fechacreacion = Cal_GP.SelectionRange.Start.Date.ToString();
                DateTime FC = Convert.ToDateTime(fechacreacion);
                int result = DateTime.Compare(Fechactual, FC);



                string Estatus;

                if (result > 0)
                {
                    Estatus = "vencido";
                }
                else
                {
                    Estatus = "Pendiente";
                }
                string Res = " ";


                string query = string.Format("insert into ventas(Cliente, Fecha_de_Pago, Lugar_de_Pago, Cantidad,Persona_Fisica,Fecha_de_Creacion,Direccion_Deudor,Poblacion_Deudor,Intereses,Descuento,Status) " +
                    "values('{0}','{1}','{2}',{3},'{4}','{5}','{6}','{7}',{8},{9},'{10}')", CBClienteGenerarPgare.SelectedItem, FC.ToString("yy/MM/dd"), txtLugarPago_GP.Text, txtCantidad_GP.Text, txtPersonaFisica_GP.Text, Fechactual.ToString("yy/MM/dd"), txtDireccion_GP.Text, txtPoblacion_GP.Text, txtIntereses_GP.Text, txtDescuento_GP.Text, Estatus);
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
                Ventas vp = new Ventas();
            }

            
           
        }

        private void btncancelarpagare_Click(object sender, EventArgs e)
        {
            this.Hide();

            Ventas vp = new Ventas();
           
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void lbltitulo_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_GP_KeyUp(object sender, KeyEventArgs e)
        {
            decimal Cant = 0, Des = 0, Inte = 0;
            decimal suma;

            if (txtCantidad_GP.Text == "" || txtDescuento_GP.Text == "" || txtIntereses_GP.Text == "")
            {
                
            }
            else
            Cant = Convert.ToDecimal(txtCantidad_GP.Text);
            Des = Convert.ToDecimal(txtDescuento_GP.Text);
            Inte = Convert.ToDecimal(txtIntereses_GP.Text);


            suma = Cant - Des + Inte;

            txtTotal_GP.Text = Convert.ToString(suma);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
      
            private void CBClienteGenerarPgare_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    conexion.AbrirConexion();
            //    DataSet ds = new DataSet();
            //    CBClienteGenerarPgare.Items.Clear();
            //    string sql = "select Cliente from ventas";
            //    MySqlCommand cmdSel = new MySqlCommand(sql, conexion._conexion);
            //    DataTable dt = new DataTable();
            //    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
            //    da.Fill(dt);
            //    CBClienteGenerarPgare.DataSource = dt;
            //    CBClienteGenerarPgare.DisplayMember = "Cliente";
            //    conexion.CerrarConeccion();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    conexion.CerrarConeccion();

            //}

        }

        private void Cal_GP_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            
        }

        public void GenerarPagare_Load(object sender, EventArgs e)
        {
            //Mostsrar fecha 
            DateTime Fechaactual = DateTime.Today;
            lblFecha.Text = Fechaactual.ToString("d");

            //combobox
            cargarcombobox();
        }

        DataTable dtcliente = new DataTable();

        public void cargarcombobox()
        {
           
                string query = "SELECT Cliente from ventas";
                MySqlDataAdapter adp = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand(query, conexion._conexion);
                adp.SelectCommand = cmd;

                adp.Fill(dtcliente);

                foreach (DataRow row in dtcliente.Rows)
                {
                    CBClienteGenerarPgare.Items.Add(row[0].ToString());

                }
            

        }  


        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPersonaFisica_GP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPersonaFisica_GP_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void txtLugarPago_GP_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void txtLugarPago_GP_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void txtPoblacion_GP_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void txtCantidad_GP_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numerosdecimal(e);
        }

        private void txtDescuento_GP_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numerosdecimal(e);
        }

        private void GenerarPagare_AutoValidateChanged(object sender, EventArgs e)
        {
            
        }
    }
}
