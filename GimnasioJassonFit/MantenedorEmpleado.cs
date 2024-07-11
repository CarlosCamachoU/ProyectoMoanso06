using Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;

namespace GimnasioJassonFit
{
    public partial class MantenedorEmpleado : Form
    {
        public MantenedorEmpleado()
        {
            InitializeComponent();
            listarEmpleado();
        }

        private void LimpiarVariables()
        {
            txtNombreE.Text = "";
            txtDNIEmp.Text = "";
            txtCorreoE.Text = "";
            txtTelefonoE.Text = "";
            cbTipoEmpleado.Text = "";

        }

        public void listarEmpleado()
        {
            dgvEmpleado.DataSource = logEmpleado.Instancia.ListarEmpleado();
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

        private void MantenedorEmpleado_Load(object sender, EventArgs e)
        {
            List<entTipoEmpleado> Tp = logTipoEmpleado.Instancia.ListarTipoEmpleado1();
            foreach (entTipoEmpleado T in Tp)
            {
                cbTipoEmpleado.Items.Add(T.NombreTipoEmpl);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombreE.Enabled = true;
            txtDNIEmp.Enabled = true;
            txtCorreoE.Enabled = true;
            txtTelefonoE.Enabled = true;
            cbTipoEmpleado.Enabled = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtNombreE.Enabled = true;
            txtDNIEmp.Enabled = true;
            txtCorreoE.Enabled = true;
            txtTelefonoE.Enabled = true;
            btnModificar.Visible = true;
            btnRegistrar.Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado Emp = new entEmpleado();
                entTipoEmpleado Tp = new entTipoEmpleado();
                Tp.NombreTipoEmpl = cbTipoEmpleado.SelectedItem.ToString();
                Emp.NombreEmpl= txtNombreE.Text.Trim();
                Emp.DNIEmpl = txtDNIEmp.Text.Trim();
                Emp.CorreoEmpl = txtCorreoE.Text.Trim();
                Emp.TelefonoEmpl = txtTelefonoE.Text.Trim();
                Emp.EstadoEmpl = cbxEstadoEmp.Checked;
                logEmpleado.Instancia.InsertarEmpleado(Emp, Tp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. no se puede registrar correctamente" + ex);
            }
            LimpiarVariables();
            txtNombreE.Enabled = false;
            txtDNIEmp.Enabled = false;
            txtCorreoE.Enabled = false;
            txtTelefonoE.Enabled = false;
            listarEmpleado();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado Emp = new entEmpleado();
                entTipoEmpleado Tp = new entTipoEmpleado();
                Emp.EmpleadoID = Int32.Parse(txtIDEmpleado.Text.ToString());
                Tp.NombreTipoEmpl = cbTipoEmpleado.SelectedItem.ToString();
                Emp.NombreEmpl = txtNombreE.Text.Trim();
                Emp.DNIEmpl = txtDNIEmp.Text.Trim();
                Emp.CorreoEmpl = txtCorreoE.Text.Trim();
                Emp.TelefonoEmpl = txtTelefonoE.Text.Trim();
                Emp.EstadoEmpl = cbxEstadoEmp.Checked;
                logEmpleado.Instancia.ModificarEmpleado(Emp, Tp);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. no se puede modificar correctamente" + ex);
            }
            LimpiarVariables();
            txtNombreE.Enabled = false;
            txtDNIEmp.Enabled = false;
            txtCorreoE.Enabled = false;
            txtTelefonoE.Enabled = false;
            txtIDEmpleado.Enabled = false;
            listarEmpleado();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado Emp = new entEmpleado();
                Emp.NombreEmpl = txtNombreE.Text.ToString();
                Emp.EmpleadoID = int.Parse(txtIDEmpleado.Text.ToString());
                cbxEstadoEmp.Checked = false;
                Emp.EstadoEmpl = cbxEstadoEmp.Checked;
                logEmpleado.Instancia.DeshabilitarEmpleado(Emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            txtNombreE.Enabled = false;
            txtDNIEmp.Enabled = false;
            txtCorreoE.Enabled = false;
            txtTelefonoE.Enabled = false;
            txtIDEmpleado.Enabled = false;
            listarEmpleado();
        }

        private void btnBuscarEm_Click(object sender, EventArgs e)
        {
            entEmpleado Emp = new entEmpleado();
            Emp.DNIEmpl = txtDNIEmp.Text.ToString();
            dgvEmpleado.DataSource = logEmpleado.Instancia.BuscarEmpleado(Emp);
        }

        private void btnRegresarD_Click(object sender, EventArgs e)
        {
            dgvEmpleado.DataSource = logEmpleado.Instancia.ListarEmpleado();
        }

        private void dgvEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvEmpleado.Rows[e.RowIndex]; //
            txtIDEmpleado.Text = filaActual.Cells[0].Value.ToString();
            cbTipoEmpleado.Text = filaActual.Cells[2].Value.ToString();
            txtNombreE.Text = filaActual.Cells[3].Value.ToString();
            txtDNIEmp.Text = filaActual.Cells[4].Value.ToString();
            txtCorreoE.Text = filaActual.Cells[5].Value.ToString();
            txtTelefonoE.Text = filaActual.Cells[6].Value.ToString();
            cbxEstadoEmp.Checked = Convert.ToBoolean(filaActual.Cells[7].Value);
        }
    }
}
