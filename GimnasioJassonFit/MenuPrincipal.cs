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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            Carga();

        }

        private void Carga()
        {
            btnRegistrar.Visible = false;
            btnCliente.Visible = false;
            btnProEntrenamientos.Visible = false;
            btnEntrenadores.Visible = false;
            btnRegistrarEE.Visible = false;
            btnTipoEmpleados.Visible = false;

        }
        
        private void btnRegistraReforma_Click(object sender, EventArgs e)
        {
            btnRegistrar.Visible = !btnRegistrar.Visible;
            btnCliente.Visible = !btnCliente.Visible;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form fmrOpen = Application.OpenForms["RealizarProforma"];

            if (fmrOpen == null)
            {
                RealizarProforma fmr1 = new RealizarProforma();
                fmr1.MdiParent = this;
                fmr1.Show();
                
            }

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Form fmrOpen = Application.OpenForms["CLIENTES"];

            if (fmrOpen == null)
            {
                CLIENTES fmr2 = new CLIENTES();
                fmr2.MdiParent = this;
                fmr2.Show();
            }
        }

        private void btnEntrenamientos_Click(object sender, EventArgs e)
        {
            btnProEntrenamientos.Visible =! btnProEntrenamientos.Visible;
            btnEntrenadores.Visible =! btnEntrenadores.Visible;

        }

        private void btnProEntrenamientos_Click(object sender, EventArgs e)
        {
            Form fmrOpen = Application.OpenForms["RealizarProgramacionEntrenamientos"];

            if (fmrOpen == null)
            {
                RealizarProgramacionEntrenamientos fmr3 = new RealizarProgramacionEntrenamientos();
                fmr3.MdiParent = this;
                fmr3.Show();
            }
        }

        private void btnEntrenadores_Click(object sender, EventArgs e)
        {
            Form fmrOpen = Application.OpenForms["ENTRENADOR"];
            if (fmrOpen == null)
            {
                ENTRENADOR fmr4= new ENTRENADOR();
                fmr4.MdiParent = this;
                fmr4.Show();
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            btnRegistrarEE.Visible = !btnRegistrarEE.Visible;
            btnTipoEmpleados.Visible = !btnTipoEmpleados.Visible;
        }

        private void btnRegistrarEE_Click_1(object sender, EventArgs e)
        {
            Form fmrOpen = Application.OpenForms["MantenedorEmpleado"];

            if (fmrOpen == null)
            {
                MantenedorEmpleado fmRE = new MantenedorEmpleado();
                fmRE.MdiParent = this;
                fmRE.Show();
            }
        }

        private void btnTipoEmpleados_Click(object sender, EventArgs e)
        {
            Form fmrOpen = Application.OpenForms["TIPOSERVICIO"];

            if (fmrOpen == null)
            {
                TIPOSERVICIO TPS = new TIPOSERVICIO();
                TPS.MdiParent = this;
                TPS.Show();
            }
        }
    }
}
