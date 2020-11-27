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

namespace PMGVcar
{
    public partial class Inicio : Form
    {
        Thread nt;
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            this.Close();
                nt = new Thread(formAgenda);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
        }
         private void formAgenda()
        {
            Application.Run(new Agenda());
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(formEstoque);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void formEstoque()
        {
            Application.Run(new Estoque());
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(formCarro);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void formCarro()
        {
            Application.Run(new Carro());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(formLogin);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void formLogin()
        {
            Application.Run(new Login());
        }

        private void btnSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/");
        }
    }
}
