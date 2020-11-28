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
    class BuscarCarro   
    {
        private Model.ConectionDatabase conection;
        private SqlCommand cmd;
        public String mensagem;


        public BuscarCarro()
        {
            this.conection = new Model.ConectionDatabase();
            this.cmd = new SqlCommand();
        }

        public DatatableCarro SelectCarro(String Id_Carro)
        {
            string query = "Select * from Carros WHERE Id_Carro = @Id_Carro";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@Id_Carro", Id_Carro);

            DatatableCarro carro = null;

            try
            {
                cmd.Connection = conection.conectar();
                
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    carro = new DatatableCarro( dr["Id_Carro"].ToString(),
                                                dr["Placa"].ToString(),
                                                dr["Marca"].ToString(),
                                                dr["Modelo"].ToString(),
                                                dr["Cor"].ToString(),
                                                dr["Ano"].ToString(),
                                                dr["Tipo_Serviço"].ToString());

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

            return carro;
        }
    }
}
