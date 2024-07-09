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
    public partial class Profesion : Form
    {
        public Profesion()
        {
            InitializeComponent();
            listarProfesion();
            txtProfesion.Enabled = false;
            txtDescripcion.Enabled = false;
            txtIDProfesion.Enabled = false;
        }
        private void LimpiarVariables()
        {
            txtProfesion.Text = "";
            txtDescripcion.Text = "";
        }
        public void listarProfesion()
        {
            dgvProfesion.DataSource = logProfesion.Instancia.ListarProfesion();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtProfesion.Enabled = true;
            txtDescripcion.Enabled = true;
            btnRegistrar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entProfesion Pr = new entProfesion();
                Pr.NombreProfe = txtProfesion.Text.Trim();
                Pr.DescripcionProfe = txtDescripcion.Text.Trim();
                logProfesion.Instancia.InsertarProfesion(Pr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. no se puede registrar correctamente" + ex);
            }
            LimpiarVariables();
            txtProfesion.Enabled = false;
            txtDescripcion.Enabled = false;
            listarProfesion();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProfesion Pr = new entProfesion();
                Pr.ProfesionID = int.Parse(txtIDProfesion.Text.ToString());
                Pr.NombreProfe = txtProfesion.Text.ToString();
                Pr.DescripcionProfe = txtDescripcion.Text.ToString();
                logProfesion.Instancia.ModificarProfesion(Pr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. no se puede modificar correctamente" + ex);
            }
            LimpiarVariables();
            txtProfesion.Enabled = false;
            txtDescripcion.Enabled = false;
            txtIDProfesion.Enabled = false;
            listarProfesion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            if (dgvProfesion.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dgvProfesion.SelectedRows[0];
                    int profesionID = Convert.ToInt32(selectedRow.Cells["ProfesionID"].Value);

                        entProfesion Pr = new entProfesion { ProfesionID = profesionID };
                        logProfesion.Instancia.EliminarProfesion(Pr);
                        MessageBox.Show("Profesión eliminada correctamente.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.. no se puede eliminar correctamente" + ex.Message);
                }
                LimpiarVariables();
                listarProfesion();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtProfesion.Enabled = true;
            txtDescripcion.Enabled = true;
            btnModificar.Visible = true;
            btnRegistrar.Visible = false;
        }

        private void dgvProfesion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProfesion.Rows[e.RowIndex]; 
            txtIDProfesion.Text = filaActual.Cells[0].Value.ToString();
            txtProfesion.Text = filaActual.Cells[1].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[2].Value.ToString();
        }
    }
}
