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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }


        private void abrirforms(object formhija)
        {
            if (this.pprincipal.Controls.Count > 0)
                this.pprincipal.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pprincipal.Controls.Add(fh);
            this.pprincipal.Tag = fh;
            fh.Show();
        }

        private void btnventas_Click(object sender, EventArgs e)
        {

            abrirforms(new Ventas());
           
        }

        private void btnterreno_Click(object sender, EventArgs e)
        {
            abrirforms(new Terrenos());
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            btninicio_Click(null, e);
        }

     

        private void btninicio_Click(object sender, EventArgs e)
        {
            abrirforms(new Graficas());
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            abrirforms(new Clientes());
        }

        private void btnpromotores_Click(object sender, EventArgs e)
        {
            abrirforms(new Promotores());
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            abrirforms(new Reportes());
        }
    }
}
