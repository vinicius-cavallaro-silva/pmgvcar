using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PMGVcar.DAO
{
    class CadastroCarro
    {

        Model.ConectionDatabase conection = new Model.ConectionDatabase();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        

        public CadastroCarro(       String Id_Carro,
                                    String Placa,
                                    String Marca,
                                    String Modelo,
                                    String Cor,
                                    String Ano,
                                    String Tipo_Serviço)
        {
            cmd.CommandText = "insert into Carros(Id_Carro, Placa, Marca, Modelo, Cor, Ano, Tipo_Serviço) " +
                "values (@Id_Carro, @Placa, @Marca, @Modelo, @Cor, @Ano, @Tipo_Serviço)";

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
