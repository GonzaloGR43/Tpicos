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
        public Terrenos()
        {
            InitializeComponent();
        }

        private void btnagregarterrenos_Click(object sender, EventArgs e)
        {
            AgregarTerrenos at = new AgregarTerrenos();
            at.Show();
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
                //Mostrar los datos de Mysql a C#
                Conexion co = new Conexion();
                string MyConnection3 = "datasource=localhost;port=3306;username=root;password=Hola...264";

                string Query = "select * from realdelmar.terrenos";
                MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                MySqlCommand MyCommand3 = new MySqlCommand(Query, MyConn3);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand3;
                DataTable dTablee = new DataTable();
                MyAdapter.Fill(dTablee);
                dvgterreno.DataSource = dTablee;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
