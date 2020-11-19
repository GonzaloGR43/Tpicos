using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_del_Mar
{
    public class ClientesCLASE
    {
        public int IDClienetes { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Clave_Terrenos { get; set; }
        public int IDContrato { get; set; }

        public ClientesCLASE()
        {
        }

        public ClientesCLASE(int pIDClientes, string pNombre_Cliente, string pClave_Terrenos, int pIDContrato)
        {
            this.IDClienetes = pIDClientes;
            this.Nombre_Cliente = pNombre_Cliente;
            this.Clave_Terrenos = pClave_Terrenos;
            this.IDContrato = pIDContrato;
        }

        public static IList<ClientesCLASE> Buscar(MySqlConnection Conexion,int IDClientes,string Nombre_Cliente,string Clave_Terrenos, int IDContrato)
        {
            List<ClientesCLASE> lista = new List<ClientesCLASE>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT IDClientes,Nombre_Cliente,Clave_Terrenos,IDContrato from clientes WHERE IDClientes LIKE ('%(0)%') AND  Nombre_Cliente LIKE  ('%(1)%') AND  Clave_Terrenos LIKE ('%(2)%') AND IDContrato LIKE  ('%(3)%')", IDClientes,Nombre_Cliente,Clave_Terrenos,IDContrato));
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ClientesCLASE cliente = new ClientesCLASE();
                cliente.IDClienetes = reader.GetInt32(0);
                cliente.Nombre_Cliente = reader.GetString(1);
                cliente.Clave_Terrenos = reader.GetString(2);
                cliente.IDContrato = reader.GetInt32(3);


                lista.Add(cliente);
            }
            return lista;
        }
    }
}
