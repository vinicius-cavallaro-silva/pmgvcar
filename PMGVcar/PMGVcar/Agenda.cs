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
    }
}
