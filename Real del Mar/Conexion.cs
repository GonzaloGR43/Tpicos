using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Real_del_Mar
{
   public class Conexion
    {
        public MySqlConnection _conexion;

        public Conexion()
        {
            //Conexion Gonzalo
            _conexion = new MySqlConnection("server=localhost; port=3306; database=realdelmar; Uid=root; pwd=p@ssw0rd");
            //Conexion Ana
            //_conexion = new MySqlConnection("server=localhost; port=3306; database=realdelmar; Uid=root; pwd=Hola...264");
        }

        public bool AbrirConexion()
        {
            try
            {
                _conexion.Open();
                return true;

            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }

        public bool CerrarConeccion()
        {
            try
            {
                _conexion.Close();
                return true;

            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }

        }
    }
}
