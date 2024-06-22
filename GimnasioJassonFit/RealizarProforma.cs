using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimnasioJassonFit
{
    public partial class RealizarProforma : Form
    {
        public RealizarProforma()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            CLIENTES Cl = new CLIENTES();
            Cl.FormClosed += Cl_FormClosed;
            Cl.MdiParent = this.MdiParent;
            Cl.Show();

            this.Hide();
        }
        private void Cl_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnBuscarTS_Click(object sender, EventArgs e)
        {
            TIPOSERVICIO TP = new TIPOSERVICIO();
            TP.FormClosed += TP_FormClosed;
            TP.MdiParent = this.MdiParent;
            TP.Show();

            this.Hide();
        }
        private void TP_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
