using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PMGVcar.DAO
{
    class CadastroEstoque
    {

        Model.ConectionDatabase conection = new Model.ConectionDatabase();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        

        public CadastroEstoque(string Id_Produto,
                                string Nome_Produto,
                                string Quantidade,
                                string Valor_Compra,
                                string Valor_Revenda,
                                string Unidade_Medida)
        {
            cmd.CommandText = "insert into Estoques (Id_Produto, Nome_Produto, Quantidade, Valor_Compra, Valor_Revenda, Unidade_Medida) " +
                "values (@Id_Produto, @Nome_Produto, @Quantidade, @Valor_Compra, @Valor_Revenda, @Unidade_Medida)";

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
