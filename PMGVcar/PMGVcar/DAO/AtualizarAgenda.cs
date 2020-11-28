using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PMGVcar.DAO
{
    class AtualizarAgenda    
    {

        Model.ConectionDatabase conection = new Model.ConectionDatabase();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        

        public AtualizarAgenda(string Nome,
                                string CPF,
                                string Data_Agendamento,
                                string Tipo_Serviço,
                                string Id_agendamento)
        {
            cmd.CommandText = "UPDATE Agenda_Service SET Nome = @Nome, CPF = @CPF, Tipo_Serviço = @Tipo_Serviço, Data_agendamento = @Data_agendamento, Id_agendamento=@Id_agendamento WHERE Id_agendamento = @Id_Agendamento";


            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@Data_Agendamento", Data_Agendamento);
            cmd.Parameters.AddWithValue("@Tipo_Serviço", Tipo_Serviço);
            cmd.Parameters.AddWithValue("@Id_agendamento", Id_agendamento);

            try
            {
                
                cmd.Connection = conection.conectar();
                cmd.ExecuteNonQuery();
                conection.desconectar();
                this.mensagem = "Cliente:" + Nome + "Atualizado com Sucesso!!";
            }

            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                this.mensagem = "Erro ao tentar conectar com o banco de dados";
            }
        }
    }
}
