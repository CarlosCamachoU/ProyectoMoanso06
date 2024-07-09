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
using System.Data.SqlClient;

namespace GimnasioJassonFit
{
    public partial class dgvClientes : Form
    {

        public dgvClientes()
        {
            InitializeComponent();
            listarCliente();
            txtClienteID.Enabled = false;
            txtNombreCl.Enabled = false;
            txtApellidosCl.Enabled = false;
            txtEdad.Enabled = false;
            txtDNICl.Enabled = false;
            txtTelefonoCl.Enabled = false;
            txtDireccion.Enabled = false;

        }
        private void LimpiarVariables()
        {
            //txtNombreCl.Text = "";
            gbDatosCl.Text = "";

        }
        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
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

        private void dgvClientes_Load(object sender, EventArgs e)
        {
            
           
            List<entCiudad> Ciu = logCiudad.Instancia.ListarCiudad1();
            foreach (entCiudad C in Ciu)
            {
                cbCiudad.Items.Add(C.NombreCiudad);
            }

            
            List<entProfesion> Pr = logProfesion.Instancia.ListarProfesion1();
            foreach (entProfesion P in Pr)
            {
                cbProfesion.Items.Add(P. NombreProfe);
            }

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            txtNombreCl.Enabled = true;
            txtApellidosCl.Enabled = true;
            txtEdad.Enabled = true;
            txtDNICl.Enabled = true;
            txtTelefonoCl.Enabled = true;
            txtDireccion.Enabled = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbDatosCl.Enabled = true;
            btnModificar.Visible = true;
            btnRegistrar.Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente Cl = new entCliente();
                entCiudad ciu = new entCiudad();
                entProfesion pr = new entProfesion();
                ciu.NombreCiudad = cbCiudad.SelectedItem.ToString();
                pr.NombreProfe = cbProfesion.SelectedItem.ToString();
                Cl.NombreClie = txtNombreCl.Text.Trim();
                Cl.ApellidoClie = txtApellidosCl.Text.Trim();
                Cl.FechaNaClie = dtPickerFechaNaCl.Value;
                Cl.EdadClie = int.Parse(txtEdad.Text.Trim());
                Cl.GeneroClie = txtGeneroCl.Text.Trim();
                Cl.DNIClie = txtDNICl.Text.Trim();
                Cl.TelefonoClie = txtTelefonoCl.Text.Trim();
                Cl.EstadoClie = cbEstadoCl.Checked;
                Cl.DireccionClie = txtDireccion.Text.Trim();
                logCliente.Instancia.InsertarCliente(Cl, ciu, pr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. no se puede registrar correctamente" + ex);
            }
            LimpiarVariables();
            txtNombreCl.Enabled = false;
            txtApellidosCl.Enabled = false;
            txtEdad.Enabled = false;
            txtDNICl.Enabled = false;
            txtTelefonoCl.Enabled = false;
            txtDireccion.Enabled = false;
            listarCliente();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente Cl = new entCliente();
                entCiudad ciu = new entCiudad();
                entProfesion pr = new entProfesion();
                ciu.NombreCiudad = cbCiudad.SelectedItem.ToString();
                pr.NombreProfe = cbProfesion.SelectedItem.ToString();
                Cl.NombreClie = txtNombreCl.Text.Trim();
                Cl.ApellidoClie = txtApellidosCl.Text.Trim();
                Cl.FechaNaClie = dtPickerFechaNaCl.Value;
                Cl.EdadClie = int.Parse(txtEdad.Text.Trim());
                Cl.DNIClie = txtDNICl.Text.Trim();
                Cl.TelefonoClie = txtTelefonoCl.Text.Trim();
                Cl.EstadoClie = cbEstadoCl.Checked;
                Cl.DireccionClie = txtDireccion.Text.Trim();
                logCliente.Instancia.ModificarCliente(Cl, ciu, pr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. no se puede modificar correctamente" + ex);
            }
            LimpiarVariables();
            txtNombreCl.Enabled = false;
            txtApellidosCl.Enabled = false;
            txtEdad.Enabled = false;
            txtDNICl.Enabled = false;
            txtTelefonoCl.Enabled = false;
            txtDireccion.Enabled = false;
            txtClienteID.Enabled = false;
            listarCliente();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente Cli = new entCliente();
                Cli.NombreClie = txtNombreCl.Text.ToString();
                Cli.ClienteID = int.Parse(txtClienteID.Text.ToString());
                cbEstadoCl.Checked = false;
                Cli.EstadoClie = cbEstadoCl.Checked;
                logCliente.Instancia.DeshabilitarCliente(Cli);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            txtNombreCl.Enabled = false;
            txtApellidosCl.Enabled = false;
            txtEdad.Enabled = false;
            txtDNICl.Enabled = false;
            txtTelefonoCl.Enabled = false;
            txtDireccion.Enabled = false;
            listarCliente();
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            entCliente Cli = new entCliente();
            Cli.DNIClie = txtDNICl.Text.ToString();
            dgvCliente.DataSource = logCliente.Instancia.BuscarCliente(Cli);

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex]; //
         
            cbCiudad.Text = filaActual.Cells[0].Value.ToString();
            cbProfesion.Text = filaActual.Cells[1].Value.ToString();
            txtClienteID.Text = filaActual.Cells[2].Value.ToString();
            txtNombreCl.Text = filaActual.Cells[3].Value.ToString();
            txtApellidosCl.Text = filaActual.Cells[4].Value.ToString();
            dtPickerFechaNaCl.Text = filaActual.Cells[5].Value.ToString();
            txtEdad.Text = filaActual.Cells[6].Value.ToString();
            txtGeneroCl.Text = filaActual.Cells[7].Value.ToString();
            txtDNICl.Text = filaActual.Cells[8].Value.ToString();
            txtTelefonoCl.Text = filaActual.Cells[9].Value.ToString();
            cbEstadoCl.Checked = Convert.ToBoolean(filaActual.Cells[10].Value);
            txtDireccion.Text = filaActual.Cells[11].Value.ToString();
        }
    }
         
}
