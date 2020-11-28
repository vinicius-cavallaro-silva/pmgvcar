using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PMGVcar.DAO
{
    class AtualizarCarro    
    {

        Model.ConectionDatabase conection = new Model.ConectionDatabase();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        

        public AtualizarCarro(       String Id_Carro,
                                    String Placa,
                                    String Marca,
                                    String Modelo,
                                    String Cor,
                                    String Ano,
                                    String Tipo_Serviço)
        {
            cmd.CommandText = "UPDATE Carros SET Id_Carro = @Id_Carro, Placa = @Placa, Marca = @Marca, Modelo = @Modelo, Cor=@Cor, Ano=@Ano, Tipo_Serviço=@Tipo_Serviço WHERE Id_Carro = @Id_Carro";
     

            cmd.Parameters.AddWithValue("@Id_Carro", Id_Carro);
            cmd.Parameters.AddWithValue("@Placa", Placa);
            cmd.Parameters.AddWithValue("@Marca", Marca);
            cmd.Parameters.AddWithValue("@Modelo", Modelo);
            cmd.Parameters.AddWithValue("@Cor", Cor);
            cmd.Parameters.AddWithValue("@Ano", Ano);
            cmd.Parameters.AddWithValue("@Tipo_Serviço", Tipo_Serviço);

            try
            {
                
                cmd.Connection = conection.conectar();
                cmd.ExecuteNonQuery();
                conection.desconectar();
                this.mensagem = "Carro:" + Id_Carro + "Atualizado com Sucesso!!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar conectar com o banco de dados";
            }
        }
    }
}
