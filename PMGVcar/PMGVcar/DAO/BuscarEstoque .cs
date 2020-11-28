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
    class BuscarEstoque  
    {
        private Model.ConectionDatabase conection;
        private SqlCommand cmd;
        public String mensagem;

        public BuscarEstoque()
        {
            this.conection = new Model.ConectionDatabase();
            this.cmd = new SqlCommand();
        }

        public DatatableEstoque SelectEstoque(String Id_produto)
        {
            string query = "Select * from Estoques WHERE Id_produto = @Id_produto";

            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@Id_produto", Id_produto);

            DatatableEstoque estoque = null;

            try
            {
                cmd.Connection = conection.conectar();
                
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    estoque = new DatatableEstoque(dr["Id_Produto"].ToString(),
                                                    dr["Nome_Produto"].ToString(),
                                                    dr["Quantidade"].ToString(),
                                                    dr["Valor_Compra"].ToString(),
                                                    dr["Valor_Revenda"].ToString(),
                                                    dr["Unidade_Medida"].ToString());

                }


                conection.desconectar();             

            }
            catch (System.InvalidOperationException)
            {
                this.mensagem = "Não encontrado no banco de dados! Tente novamente!";
                
                 
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                this.mensagem = "Erro ao tentar conectar com o banco de dados";
            }

            return estoque;
        }
    }
}
