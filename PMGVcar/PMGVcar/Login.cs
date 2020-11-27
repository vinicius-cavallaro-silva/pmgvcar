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
    public partial class Login : Form
    {
        Thread nt;
        public Login()
        {
            InitializeComponent();    
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text=="Admin" || txtUser.Text=="mecanico" && txtSenha.Text == "Admin@1973" || txtSenha.Text=="123456")
            {
                MessageBox.Show("Login Aceito :)");
                this.Close();
                nt = new Thread(formInicio);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Login ou Senha Inválidos :(");
            }
        }

        private void formInicio()
        {
            Application.Run(new Inicio());
        }
    }
}
