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
        public AgregarTerrenos()
        {
            InitializeComponent();
        }

        private void btnguardarterreno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Terrenos t = new Terrenos();

        }

        private void btncancelarterreno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Terrenos t = new Terrenos();

        }
    }
}
