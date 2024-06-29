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
            dgvClientes Cl = new dgvClientes();
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

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            MantenedorEmpleado MEm = new MantenedorEmpleado();
            MEm.FormClosed += MEm_FormClosed;
            MEm.MdiParent = this.MdiParent;
            MEm.Show();

            this.Hide();
        }

        private void MEm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
