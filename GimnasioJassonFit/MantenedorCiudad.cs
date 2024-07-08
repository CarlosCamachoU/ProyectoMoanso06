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
                ci.NombreCiudad = txtCiudad.Text.Trim();
                ci.EstadoCiudad = cbEstadoCiu.Checked;
                logCiudad.Instancia.ModificarCiudad(ci);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. no se puede modificar correctamente" + ex);
            }
            LimpiarVariables();
            txtCiudad.Enabled = false;
            listarCiudad();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCiudad ci = new entCiudad();
                ci.NombreCiudad = txtCiudad.Text.Trim();
                ci.CiudadID = int.Parse(Text.Trim());
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
    }
}

