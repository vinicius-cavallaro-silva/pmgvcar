using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMGVcar.Model
{
    class DatatableAgenda
    {
        private string Nome;
        private string CPF;
        private string Data_Agendamento;
        private string Tipo_Serviço; 
        private string Id_Agendamento;


        public DatatableAgenda(string Tipo_Serviço, string Nome, string CPF, string Data_Agendamento, string Id_Agendamento)
        {
            this.SetTipoServiço(Tipo_Serviço);
            this.SetNome(Nome);
            this.SetCPF(CPF);
            this.SetDataAgendamento(Data_Agendamento);         
            this.SetIdAgendamento(Id_Agendamento);
        }


        public string GetNome()
        {
            return this.Nome;
        }
        public string GetCPF()
        {
            return this.CPF;
        }
        public string GetTipoServiço()
        {
            return this.Tipo_Serviço;
        }
        public string GetDataAgendamento()
        {
            return this.Data_Agendamento;
        }
        public string GetIdAgendamento()
        {
            return this.Id_Agendamento;
        }


        public void SetNome(string Nome)
        {
            this.Nome = Nome;
        }
        public void SetCPF(string CPF)
        {
            this.CPF = CPF;
        }
        public void SetDataAgendamento(string Data_Agendamento)
        {
            this.Data_Agendamento = Data_Agendamento;
        }
        public void SetTipoServiço(string Tipo_Serviço)
        {
            this.Tipo_Serviço = Tipo_Serviço;
        }
        public void SetIdAgendamento(string Id_Agendamento)
        {
            this.Id_Agendamento = Id_Agendamento;
        }

    }
}
