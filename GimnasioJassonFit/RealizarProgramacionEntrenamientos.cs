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
    public partial class RealizarProgramacionEntrenamientos : Form
    {
        public RealizarProgramacionEntrenamientos()
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

        private void btnBuscarEntrenador_Click(object sender, EventArgs e)
        {
            ENTRENADOR EN = new ENTRENADOR();
            EN.FormClosed += EN_FormClosed;
            EN.MdiParent = this.MdiParent;
            EN.Show();

            this.Hide();
        }
        private void EN_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
