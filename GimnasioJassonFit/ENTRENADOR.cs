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
    public partial class ENTRENADOR : Form
    {
        public ENTRENADOR()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarEsp_Click(object sender, EventArgs e)
        {
            Especialidad be = new Especialidad();
            be.FormClosed += BuEsp_FormClosed;
            be.MdiParent = this.MdiParent;
            be.Show();

            this.Hide();
        }

        private void BuEsp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnBuscarSala_Click(object sender, EventArgs e)
        {
            MantenedorCiudad bs = new MantenedorCiudad();
            bs.FormClosed += BuSal_FormClosed;
            bs.MdiParent = this.MdiParent;
            bs.Show();

            this.Hide();
        }
        private void BuSal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
    
}
