using Google.Protobuf.WellKnownTypes;
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
        public GenerarPagare()
        {
            InitializeComponent();
        }

        private void btnagregarpagare_Click(object sender, EventArgs e)
        {
            this.Hide();

            Ventas vp = new Ventas();
           
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
    }
}
