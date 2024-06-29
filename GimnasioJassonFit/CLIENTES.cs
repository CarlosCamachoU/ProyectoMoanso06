using Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using System.Windows.Forms;

namespace GimnasioJassonFit
{
    public partial class dgvClientes : Form
    {
        public dgvClientes()
        {
            InitializeComponent();
            listarCliente();
        }

        private void btnBuscarCiudad_Click(object sender, EventArgs e)
        {
            MantenedorCiudad mc = new MantenedorCiudad();
            mc.FormClosed += Mc_FormClosed;
            mc.MdiParent = this.MdiParent;
            mc.Show();

            this.Hide();
        }

        private void Mc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarProf_Click(object sender, EventArgs e)
        {
            Profesion pf = new Profesion();
            pf.FormClosed += PF_FormClosed;
            pf.MdiParent = this.MdiParent;
            pf.Show();

            this.Hide();
        }
        private void PF_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
        }

    }
}
