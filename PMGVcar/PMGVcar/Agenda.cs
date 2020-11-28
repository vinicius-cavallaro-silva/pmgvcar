using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using PMGVcar.Model;

namespace PMGVcar
{
    public partial class Agenda : Form
    {
        Thread nt;

        public Agenda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(formInicio);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void formInicio()
        {
            Application.Run(new Inicio());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTipoServico.Clear();
            txtNome.Clear();
            txtCPF.Clear();
            txtDataAgendamento.Clear();
            txtIdAgendamento.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DAO.CadastroAgenda cadagenda = new DAO.CadastroAgenda(txtNome.Text, txtCPF.Text, txtTipoServico.Text, txtDataAgendamento.Text, txtIdAgendamento.Text);
            MessageBox.Show(cadagenda.mensagem);
            txtTipoServico.Clear();
            txtNome.Clear();
            txtCPF.Clear();
            txtDataAgendamento.Clear();
            txtIdAgendamento.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DatatableAgenda agenda = new DAO.BuscarAgenda().SelectAgenda(txtNome.Text);
                txtIdAgendamento.Text = agenda.GetIdAgendamento();
                txtNome.Text = agenda.GetNome();
                txtCPF.Text = agenda.GetCPF();
                txtTipoServico.Text = agenda.GetTipoServiço();
                txtDataAgendamento.Text = agenda.GetDataAgendamento();
            }
            catch (NullReferenceException) 
            {
                MessageBox.Show("Nome" + txtNome.Text + "não encontrado!");
            }
          
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DAO.AtualizarAgenda cadagenda = new DAO.AtualizarAgenda(txtNome.Text, txtCPF.Text, txtDataAgendamento.Text, txtTipoServico.Text, txtIdAgendamento.Text);
            MessageBox.Show(cadagenda.mensagem);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DAO.ExclusãoAgenda cadagenda = new DAO.ExclusãoAgenda(txtIdAgendamento.Text ,txtNome.Text);
            MessageBox.Show(cadagenda.mensagem);
            txtTipoServico.Clear();
            txtNome.Clear();
            txtCPF.Clear();
            txtDataAgendamento.Clear();
            txtIdAgendamento.Clear();
        }

        private void txtIdAgendamento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
