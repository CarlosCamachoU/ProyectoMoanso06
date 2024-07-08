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
    public partial class MantenedorCiudad : Form
    {
        public MantenedorCiudad()
        {
            InitializeComponent();
            listarCiudad();
            txtCiudad.Enabled = false;
            txtCiudadID.Enabled = false;

            
        }
        private void LimpiarVariables()
        {
            txtCiudad.Text = "";
        }

        public void listarCiudad()
        {
            dgvCiudad.DataSource = logCiudad.Instancia.ListarCiudad();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entCiudad ci = new entCiudad();
                ci.NombreCiudad = txtCiudad.Text.Trim();
                ci.EstadoCiudad = cbEstadoCiu.Checked;
                logCiudad.Instancia.InsertarCiudad(ci);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. no se puede registrar correctamente" + ex);
            }
            LimpiarVariables();
            txtCiudad.Enabled = false;
            listarCiudad();
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                entCiudad ci = new entCiudad();
                ci.CiudadID = int.Parse(txtCiudadID.Text.ToString());
                ci.NombreCiudad = txtCiudad.Text.ToString();
                ci.EstadoCiudad = cbEstadoCiu.Checked;
                logCiudad.Instancia.ModificarCiudad(ci);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. no se puede modificar correctamente" + ex);
            }
            LimpiarVariables();
            txtCiudad.Enabled = false;
            txtCiudadID.Enabled = false;
            listarCiudad();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCiudad ci = new entCiudad();
                ci.NombreCiudad = txtCiudad.Text.ToString();
                ci.CiudadID = int.Parse(txtCiudadID.Text.ToString());
                cbEstadoCiu.Checked = false;
                ci.EstadoCiudad = cbEstadoCiu.Checked;
                logCiudad.Instancia.DeshabilitarCiudad(ci);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            txtCiudad.Enabled = false;
            listarCiudad();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCiudad.Enabled = true;
            btnRegistrar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtCiudad.Enabled = true;
            btnModificar.Visible = true;
            btnRegistrar.Visible = false;
        }

        private void dgvCiudad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCiudad.Rows[e.RowIndex]; //
            txtCiudadID.Text = filaActual.Cells[0].Value.ToString();
            txtCiudad.Text = filaActual.Cells[1].Value.ToString();
            cbEstadoCiu.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
        }
    }
}

