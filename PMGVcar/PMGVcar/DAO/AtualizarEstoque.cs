using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PMGVcar.DAO
{
    class AtualizarEstoque   
    {

        Model.ConectionDatabase conection = new Model.ConectionDatabase();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        

        public AtualizarEstoque(string Id_Produto,
                                string Nome_Produto,
                                string Quantidade,
                                string Valor_Compra,
                                string Valor_Revenda,
                                string Unidade_Medida)
        {
            cmd.CommandText = "UPDATE Estoques SET Id_Produto = @Id_Produto, Nome_Produto = @Nome_Produto, Quantidade = @Quantidade, Valor_Compra = @Valor_Compra, Valor_Revenda = @Valor_Revenda, Unidade_Medida=@Unidade_Medida";

            cmd.Parameters.AddWithValue("@Id_Produto", Id_Produto);
            cmd.Parameters.AddWithValue("@Nome_Produto", Nome_Produto);
            cmd.Parameters.AddWithValue("@Quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@Valor_Compra", Valor_Compra);
            cmd.Parameters.AddWithValue("@Valor_Revenda", Valor_Revenda);
            cmd.Parameters.AddWithValue("@Unidade_Medida", Unidade_Medida);

            try
            {
                
                cmd.Connection = conection.conectar();
                cmd.ExecuteNonQuery();
                conection.desconectar();
                this.mensagem = "Produto:" + Id_Produto + "Atualizado com Sucesso!!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar conectar com o banco de dados";
            }
        }
    }
}
