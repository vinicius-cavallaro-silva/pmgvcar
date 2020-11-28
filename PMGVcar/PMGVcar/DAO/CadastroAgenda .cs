using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PMGVcar.DAO
{
    class CadastroAgenda
    {

        Model.ConectionDatabase conection = new Model.ConectionDatabase();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        

        public CadastroAgenda(string Nome,
                                string CPF,
                                string Tipo_Serviço,
                                string Data_Agendamento,     
                                string Id_agendamento)
        {
            cmd.CommandText = "INSERT INTO Agenda_Service (Nome, CPF, Tipo_Serviço, Data_agendamento, Id_agendamento) " +
                "VALUES (@Nome, @CPF, @Tipo_Serviço, @Data_Agendamento, @Id_agendamento)";

            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@Tipo_Serviço", Tipo_Serviço);
            cmd.Parameters.AddWithValue("@Data_Agendamento", Data_Agendamento);
            cmd.Parameters.AddWithValue("@Id_agendamento", Id_agendamento);

            try
            {
                cmd.Connection = conection.conectar();
                MessageBox.Show("conectou");
                cmd.ExecuteNonQuery(); 
                conection.desconectar();
                this.mensagem = "Cadastrado com Sucesso!!";
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                this.mensagem = "Erro ao tentar conectar com o banco de dados";
            }
        }
    }
}
