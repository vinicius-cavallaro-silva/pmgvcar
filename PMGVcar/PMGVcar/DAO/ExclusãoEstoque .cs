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
    class ExclusãoEstoque
    {

        Model.ConectionDatabase conection = new Model.ConectionDatabase();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
   

        public ExclusãoEstoque(String Id_produto)
        {
            cmd.CommandText = "delete from Estoques WHERE Id_produto = @Id_produto";
            cmd.Parameters.AddWithValue("@Id_produto", Id_produto);

            try
            {
                cmd.Connection = conection.conectar();
                cmd.ExecuteNonQuery();
                conection.desconectar();
                this.mensagem = "Produto de Id:" + Id_produto + " Excluído com Sucesso!!";

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                this.mensagem = "Erro ao tentar conectar com o banco de dados";
            }
        }
    }
}
