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
    public partial class Estoque : Form
    {
        Thread nt;
        public Estoque()
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodProduto.Clear();
            txtNomeProduto.Clear();
            txtQuantidade.Clear();
            txtValorCompra.Clear();
            txtValorRevenda.Clear();
            txtUnidadeMedida.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            DAO.CadastroEstoque cadestoque = new DAO.CadastroEstoque(txtCodProduto.Text, txtNomeProduto.Text, txtQuantidade.Text, txtValorCompra.Text, txtValorRevenda.Text, txtUnidadeMedida.Text);
            MessageBox.Show(cadestoque.mensagem);
            txtCodProduto.Clear();
            txtNomeProduto.Clear();
            txtQuantidade.Clear();
            txtValorCompra.Clear();
            txtValorRevenda.Clear();
            txtUnidadeMedida.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DatatableEstoque estoque = new DAO.BuscarEstoque().SelectEstoque(txtCodProduto.Text);
                txtCodProduto.Text = estoque.GetIdProduto();
                txtNomeProduto.Text = estoque.GetNomeProduto();
                txtQuantidade.Text = estoque.GetQuantidade();
                txtValorCompra.Text = estoque.GetValorCompra();
                txtValorRevenda.Text = estoque.GetValorRevenda();
                txtUnidadeMedida.Text = estoque.GetUnidadeMedida();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Nome" + txtNomeProduto.Text + "não encontrado!");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DAO.AtualizarEstoque atualizarestoque = new DAO.AtualizarEstoque(txtCodProduto.Text, txtNomeProduto.Text, txtQuantidade.Text, txtValorCompra.Text, txtValorRevenda.Text, txtUnidadeMedida.Text);
            MessageBox.Show(atualizarestoque.mensagem);
            txtCodProduto.Clear();
            txtNomeProduto.Clear();
            txtQuantidade.Clear();
            txtValorCompra.Clear();
            txtValorRevenda.Clear();
            txtUnidadeMedida.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DAO.ExclusãoEstoque excluirestoque = new DAO.ExclusãoEstoque(txtCodProduto.Text);
            MessageBox.Show(excluirestoque.mensagem);
            txtCodProduto.Clear();
            txtNomeProduto.Clear();
            txtQuantidade.Clear();
            txtValorCompra.Clear();
            txtValorRevenda.Clear();
            txtUnidadeMedida.Clear();
        }
    }
}
