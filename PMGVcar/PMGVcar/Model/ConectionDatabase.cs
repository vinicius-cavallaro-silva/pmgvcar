using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace PMGVcar.Model
{
    public class ConectionDatabase
    {

        //construtor
        SqlConnection con = new SqlConnection();

        public ConectionDatabase()
        {

            con.ConnectionString = @"Data Source=DESKTOP-NMV9682\SQLEXPRESS;Initial Catalog=pim_cars;Integrated Security=True";
        }

        //para conectar
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        //para desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }


    }
}
