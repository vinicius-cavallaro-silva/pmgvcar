using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMGVcar
{
    class ModelEstoque
    {
        public string CodProduto { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public double ValorCompra { get; set; }
        public double ValorRevenda { get; set; }
        public double UnidadeMedida { get; set; }
    }
}
