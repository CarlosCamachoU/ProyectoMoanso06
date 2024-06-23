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
    public partial class MantenedorEmpleado : Form
    {
        public MantenedorEmpleado()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TipoEmpleado TEM = new TipoEmpleado();
            TEM.FormClosed += TEM_FormClosed;
            TEM.MdiParent = this.MdiParent;
            TEM.Show();

            this.Hide();
        }
        private void TEM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
