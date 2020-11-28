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
    public partial class Carro : Form
    {
        Thread nt;
        public Carro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            DAO.CadastroCarro cadcarro = new DAO.CadastroCarro(txtIdCarro.Text, txtPlaca.Text, txtMarca.Text, txtModelo.Text, txtCor.Text, txtAno.Text, txtTipoServico.Text);
            MessageBox.Show(cadcarro.mensagem);
            txtIdCarro.Clear();
            txtPlaca.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtCor.Clear();
            txtAno.Clear();
            txtTipoServico.Clear();
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DAO.ExclusãoCarro excluircarro = new DAO.ExclusãoCarro(txtIdCarro.Text);
            MessageBox.Show(txtIdCarro.Text);
            MessageBox.Show(excluircarro.mensagem);
            txtIdCarro.Clear();
            txtPlaca.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtCor.Clear();
            txtAno.Clear();
            txtTipoServico.Clear();
        }

        private void textBoxIdCarro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DAO.AtualizarCarro atualizarcarro = new DAO.AtualizarCarro(txtIdCarro.Text, txtPlaca.Text, txtMarca.Text, txtModelo.Text, txtCor.Text, txtAno.Text, txtTipoServico.Text);
            MessageBox.Show(atualizarcarro.mensagem);
            txtIdCarro.Clear();
            txtPlaca.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtCor.Clear();
            txtAno.Clear();
            txtTipoServico.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatatableCarro carro = new DAO.BuscarCarro().SelectCarro(txtIdCarro.Text);
            txtPlaca.Text = carro.GetPlaca();
            txtMarca.Text = carro.GetMarca();
            txtModelo.Text = carro.GetModelo();
            txtCor.Text = carro.GetCor();
            txtAno.Text = carro.GetAno();
            txtTipoServico.Text = carro.GetTipoServiço();
           
        }

        private void SelectBoxTipoServico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdCarro.Clear();
            txtPlaca.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtCor.Clear();
            txtAno.Clear();
            txtTipoServico.Clear();
        }

        private void txtTipoServico_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
