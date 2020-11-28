using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMGVcar.Model
{
    class DatatableEstoque
    {
        private string Id_Produto;
        private string Nome_Produto;
        private string Quantidade;
        private string Valor_Compra;
        private string Valor_Revenda;
        private string Unidade_Medida;



        public DatatableEstoque(string Id_Produto, string Nome_Produto, string Quantidade, string Valor_Compra, string Valor_Revenda, string Unidade_Medida)
        {
            this.SetIdProduto(Id_Produto);
            this.SetNomeProduto(Nome_Produto);
            this.SetQuantidade(Quantidade);
            this.SetValorCompra(Valor_Compra);
            this.SetValorRevenda(Valor_Revenda);
            this.SetUnidadeMedida(Unidade_Medida);
        }



        public string GetIdProduto()
        {
            return this.Id_Produto;
        }
        public string GetNomeProduto()
        {
            return this.Nome_Produto;
        }
        public string GetQuantidade()
        {
            return this.Quantidade;
        }
        public string GetValorCompra()
        {
            return this.Valor_Compra;
        }
        public string GetValorRevenda()
        {
            return this.Valor_Revenda;
        }
        public string GetUnidadeMedida()
        {
            return this.Unidade_Medida;
        }



        public void SetIdProduto(string Id_Produto)
        {
            this.Id_Produto = Id_Produto;
        }
        public void SetNomeProduto(string Nome_Produto)
        {
            this.Nome_Produto = Nome_Produto;
        }
        public void SetQuantidade(string Quantidade)
        {
            this.Quantidade = Quantidade;
        }
        public void SetValorCompra(string Valor_Compra)
        {
            this.Valor_Compra = Valor_Compra;
        }
        public void SetValorRevenda(string Valor_Revenda)
        {
            this.Valor_Revenda = Valor_Revenda;
        }
        public void SetUnidadeMedida(string Unidade_Medida)
        {
            this.Unidade_Medida = Unidade_Medida;
        }


    }
}
