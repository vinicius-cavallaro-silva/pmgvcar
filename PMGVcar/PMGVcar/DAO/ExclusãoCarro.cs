using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PMGVcar.DAO
{
    class ExclusãoCarro
    {

        Model.ConectionDatabase conection = new Model.ConectionDatabase();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;


        public ExclusãoCarro(String Id_Carro)
        {
            string query = "delete from Carros WHERE Id_Carro = @Id_Carro";
            
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@Id_Carro", Id_Carro);

            try
            {
                cmd.Connection = conection.conectar();     
                cmd.ExecuteNonQuery();
                conection.desconectar();
                this.mensagem = "Carro de Id:" + Id_Carro + " Excluído com Sucesso!!";

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                this.mensagem = "Erro ao tentar conectar com o banco de dados";
            }
        }
    }
}
