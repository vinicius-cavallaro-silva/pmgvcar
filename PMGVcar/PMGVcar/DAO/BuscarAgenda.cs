using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using PMGVcar.Model;

namespace PMGVcar.DAO
{
    class BuscarAgenda   
    {
        private Model.ConectionDatabase conection;
        private SqlCommand cmd;
        public String mensagem;

        public BuscarAgenda()
        {
            this.conection = new Model.ConectionDatabase();
            this.cmd = new SqlCommand();
        }

        public DatatableAgenda SelectAgenda(String Nome)
        {
            string query = "Select * from Agenda_Service WHERE Nome = @Nome";
            
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@Nome", Nome);

            DatatableAgenda agenda = null;

            try
            {
                cmd.Connection = conection.conectar();
                

                
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    agenda = new DatatableAgenda(dr["Tipo_Serviço"].ToString(),
                                                    dr["Nome"].ToString(),
                                                    dr["CPF"].ToString(),
                                                    dr["Data_Agendamento"].ToString(),
                                                    dr["Id_agendamento"].ToString());



                }
                conection.desconectar();
                



            }
            catch (System.InvalidOperationException)
            {
                this.mensagem = "Não encontrado no banco de dados! Tente novamente!";
                
                 
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar conectar com o banco de dados";
            }

            return agenda;
        }
    }
}
