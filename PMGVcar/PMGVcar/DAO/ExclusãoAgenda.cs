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
    class ExclusãoAgenda
    {

        Model.ConectionDatabase conection = new Model.ConectionDatabase();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;


        public ExclusãoAgenda(String Id_agendamento, String Nome)
        {
            string query = "delete from Agenda_Service WHERE Id_agendamento = @Id_Agendamento";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@Id_Agendamento", Id_agendamento);

            try
            {
                cmd.Connection = conection.conectar();
                cmd.ExecuteNonQuery();
                conection.desconectar();
                this.mensagem = "Agendamento de:" + Nome + " Excluído com Sucesso!!";

            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar conectar com o banco de dados";
            }
        }
    }
}
