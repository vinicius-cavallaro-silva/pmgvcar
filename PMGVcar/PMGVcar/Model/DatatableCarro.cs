using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMGVcar.Model
{
    class DatatableCarro
    {
        private string Id_Carro;
        private string Placa;
        private string Marca;
        private string Modelo;
        private string Cor;
        private string Ano;
        private string Tipo_Serviço;



        public DatatableCarro(string Id_Carro, string Placa, string Marca, string Modelo, string Cor, string Ano, string Tipo_Serviço)
        {
            this.SetIdCarro(Id_Carro);
            this.SetIdCarro(Id_Carro);
            this.SetPlaca(Placa);
            this.SetMarca(Marca);
            this.SetModelo(Modelo);
            this.SetCor(Cor);
            this.SetAno(Ano);
            this.SetTipoServiço(Tipo_Serviço);
        }



        public string GetIdCarro()
        {
            return this.Id_Carro;
        }
        public string GetPlaca()
        {
            return this.Placa;
        }
        public string GetMarca()
        {
            return this.Marca;
        }
        public string GetModelo()
        {
            return this.Modelo;
        }
        public string GetCor()
        {
            return this.Cor;
        }
        public string GetAno()
        {
            return this.Ano;
        }
        public string GetTipoServiço()
        {
            return this.Tipo_Serviço;
        }


        public void SetIdCarro(string Id_Carro)
        {
            this.Id_Carro = Id_Carro;
        }
        public void SetPlaca(string Placa)
        {
            this.Placa = Placa;
        }
        public void SetMarca(string Marca)
        {
            this.Marca = Marca;
        }
        public void SetModelo(string Modelo)
        {
            this.Modelo = Modelo;
        }
        public void SetCor(string Cor)
        {
            this.Cor = Cor;
        }
        public void SetAno(string Ano)
        {
            this.Ano = Ano;
        }
        public void SetTipoServiço(string Tipo_Serviço)
        {
            this.Tipo_Serviço = Tipo_Serviço;
        }

    }
}
