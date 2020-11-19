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
            this.Hide();
            Promotores p = new Promotores();
      
        }
    }
}
