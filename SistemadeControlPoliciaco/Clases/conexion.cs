using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SistemadeControlPoliciaco
{
    public class Conexion
    {
        public static SqlConnection conectar()
        {
            SqlConnection conectado = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName= E:\Documentos\Visual Studio 2013\Projects\SistemadeControlPoliciaco\SistemadeControlPoliciaco\bdSCP.mdf");
            conectado.Open();
            return conectado;
        }
        public static SqlConnection desconectar()
        {
            SqlConnection conectado = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName= E:\Documentos\Visual Studio 2013\Projects\SistemadeControlPoliciaco\SistemadeControlPoliciaco\bdSCP.mdf");
            conectado.Close();
            return conectado;
        }
    }
}
