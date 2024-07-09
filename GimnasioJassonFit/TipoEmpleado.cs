using Capa_Entidad;
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

namespace GimnasioJassonFit
{
    public partial class TipoEmpleado : Form
    {
        public TipoEmpleado()
        {
            InitializeComponent();
            listarTipoEmpleado();
            txtPuesto.Enabled = false;
            txtContrato.Enabled = false;
            txtDescripcion.Enabled = false;
            txtIDTP.Enabled = false;
        }

        private void LimpiarVariables()
        {
            txtPuesto.Text = "";
            txtContrato.Text = "";
            txtDescripcion.Text = "";
        }
        public void listarTipoEmpleado()
        {
            dgvTipoEmpleado.DataSource = logTipoEmpleado.Instancia.ListarTipoEmpleado();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPuesto.Enabled = true;
            txtContrato.Enabled = true;
            txtDescripcion.Enabled = true;
            btnRegistrar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoEmpleado Pt = new entTipoEmpleado();
                Pt.NombreTipoEmpl = txtPuesto.Text.Trim();
                Pt.Contrato = txtContrato.Text.Trim();
                Pt.Descripcion = txtDescripcion.Text.Trim();
                logTipoEmpleado.Instancia.InsertarTipoEmpleado(Pt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. no se puede registrar correctamente" + ex);
            }
            LimpiarVariables();
            txtPuesto.Enabled = false;
            txtContrato.Enabled = false;
            txtDescripcion.Enabled = false;
            listarTipoEmpleado();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoEmpleado Pt = new entTipoEmpleado();
                Pt.TipoEmpleadoID = int.Parse(txtIDTP.Text.ToString());
                Pt.NombreTipoEmpl = txtPuesto.Text.ToString();
                Pt.Contrato = txtContrato.Text.ToString();
                Pt.Descripcion = txtDescripcion.Text.ToString();
                logTipoEmpleado.Instancia.ModificarTipoEmpleado(Pt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. no se puede modificar correctamente" + ex);
            }
            LimpiarVariables();
            txtPuesto.Enabled = false;
            txtContrato.Enabled = false;
            txtDescripcion.Enabled = false;
            txtIDTP.Enabled = false;
            listarTipoEmpleado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTipoEmpleado.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dgvTipoEmpleado.SelectedRows[0];
                    int tipoEmpleadoID = Convert.ToInt32(selectedRow.Cells["TipoEmpleadoID"].Value);

                    entTipoEmpleado Pr = new entTipoEmpleado { TipoEmpleadoID = tipoEmpleadoID };
                    logTipoEmpleado.Instancia.EliminarTipoEmpleado(Pr);
                    MessageBox.Show("Tipo Empleado eliminado correctamente.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.. no se puede eliminar correctamente" + ex.Message);
                }
                LimpiarVariables();
                listarTipoEmpleado();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtPuesto.Enabled = true;
            txtContrato.Enabled = true;
            txtDescripcion.Enabled = true;
            btnModificar.Visible = true;
            btnRegistrar.Visible = false;
        }

        private void dgvTipoEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvTipoEmpleado.Rows[e.RowIndex];
            txtIDTP.Text = filaActual.Cells[0].Value.ToString();
            txtPuesto.Text = filaActual.Cells[1].Value.ToString();
            txtContrato.Text = filaActual.Cells[2].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[3].Value.ToString();
        }
    }
}
