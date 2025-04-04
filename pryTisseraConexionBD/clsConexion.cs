using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pryTisseraConexionBD
{
    internal class clsConexion
    {

        string connectionString = "Server=E:/Escritorio/pryTisseraConexionBD;Database=Comercio;Trusted_Connection=True;";
        public SqlConnection connection { get; set; }
        public SqlConnection conexion()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("✅ Conexión exitosa a la base de datos.");
                return connection;
 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return connection;
            }

        }
    }
}
