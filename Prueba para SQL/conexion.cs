using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Prueba_para_SQL
{
    internal class conexion
    {
        public void Conectar(DataGridView dgv)
        {
            string connectionString = "Server = localhost\\SQLEXPRESS; Database = Comercio; Trusted_Connection = True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    connection.Open();
                    MessageBox.Show("Datos guardados correctamente");


                    string query = "SELECT * FROM Contactos";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgv.DataSource = table;

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Los datos presentan error" + ex.Message);
                }
            }
        }
    }
}
