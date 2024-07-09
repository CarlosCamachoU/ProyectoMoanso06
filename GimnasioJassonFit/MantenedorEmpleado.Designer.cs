
namespace GimnasioJassonFit
{
    partial class MantenedorEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.txtCorreoE = new System.Windows.Forms.TextBox();
            this.txtTelefonoE = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBuscarEm = new System.Windows.Forms.Button();
            this.txtDNIEmp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEstadoEmp = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRegresarD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Location = new System.Drawing.Point(51, 286);
            this.dgvEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.RowHeadersWidth = 51;
            this.dgvEmpleado.Size = new System.Drawing.Size(834, 170);
            this.dgvEmpleado.TabIndex = 0;
            this.dgvEmpleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "IDEmpleado";
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Location = new System.Drawing.Point(183, 32);
            this.txtIDEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(132, 22);
            this.txtIDEmpleado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefono";
            // 
            // txtNombreE
            // 
            this.txtNombreE.Location = new System.Drawing.Point(183, 124);
            this.txtNombreE.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(132, 22);
            this.txtNombreE.TabIndex = 6;
            // 
            // txtCorreoE
            // 
            this.txtCorreoE.Location = new System.Drawing.Point(183, 170);
            this.txtCorreoE.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoE.Name = "txtCorreoE";
            this.txtCorreoE.Size = new System.Drawing.Size(132, 22);
            this.txtCorreoE.TabIndex = 7;
            // 
            // txtTelefonoE
            // 
            this.txtTelefonoE.Location = new System.Drawing.Point(511, 31);
            this.txtTelefonoE.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoE.Name = "txtTelefonoE";
            this.txtTelefonoE.Size = new System.Drawing.Size(228, 22);
            this.txtTelefonoE.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(51, 483);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(113, 48);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(227, 483);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 48);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(385, 483);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(113, 48);
            this.btnDeshabilitar.TabIndex = 11;
            this.btnDeshabilitar.Text = "DESHABILITAR";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(817, 522);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 33);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(95, 64);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 33);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar ";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBuscarEm
            // 
            this.btnBuscarEm.Location = new System.Drawing.Point(536, 483);
            this.btnBuscarEm.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarEm.Name = "btnBuscarEm";
            this.btnBuscarEm.Size = new System.Drawing.Size(113, 48);
            this.btnBuscarEm.TabIndex = 14;
            this.btnBuscarEm.Text = "BUSCAR";
            this.btnBuscarEm.UseVisualStyleBackColor = true;
            this.btnBuscarEm.Click += new System.EventHandler(this.btnBuscarEm_Click);
            // 
            // txtDNIEmp
            // 
            this.txtDNIEmp.Location = new System.Drawing.Point(183, 79);
            this.txtDNIEmp.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNIEmp.Name = "txtDNIEmp";
            this.txtDNIEmp.Size = new System.Drawing.Size(132, 22);
            this.txtDNIEmp.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tipo Empleado";
            // 
            // cbTipoEmpleado
            // 
            this.cbTipoEmpleado.FormattingEnabled = true;
            this.cbTipoEmpleado.Location = new System.Drawing.Point(120, 31);
            this.cbTipoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoEmpleado.Name = "cbTipoEmpleado";
            this.cbTipoEmpleado.Size = new System.Drawing.Size(160, 24);
            this.cbTipoEmpleado.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbTipoEmpleado);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(441, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(299, 112);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // cbxEstadoEmp
            // 
            this.cbxEstadoEmp.AutoSize = true;
            this.cbxEstadoEmp.Location = new System.Drawing.Point(513, 178);
            this.cbxEstadoEmp.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEstadoEmp.Name = "cbxEstadoEmp";
            this.cbxEstadoEmp.Size = new System.Drawing.Size(18, 17);
            this.cbxEstadoEmp.TabIndex = 20;
            this.cbxEstadoEmp.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Estado";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(772, 63);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(113, 33);
            this.btnNuevo.TabIndex = 22;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(772, 128);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(113, 33);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRegresarD
            // 
            this.btnRegresarD.Location = new System.Drawing.Point(680, 483);
            this.btnRegresarD.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresarD.Name = "btnRegresarD";
            this.btnRegresarD.Size = new System.Drawing.Size(113, 48);
            this.btnRegresarD.TabIndex = 24;
            this.btnRegresarD.Text = "REGRESAR DATOS";
            this.btnRegresarD.UseVisualStyleBackColor = true;
            this.btnRegresarD.Click += new System.EventHandler(this.btnRegresarD_Click);
            // 
            // MantenedorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 568);
            this.Controls.Add(this.btnRegresarD);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxEstadoEmp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDNIEmp);
            this.Controls.Add(this.btnBuscarEm);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtTelefonoE);
            this.Controls.Add(this.txtCorreoE);
            this.Controls.Add(this.txtNombreE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmpleado);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MantenedorEmpleado";
            this.Text = "MantenedorEmpleado";
            this.Load += new System.EventHandler(this.MantenedorEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.TextBox txtCorreoE;
        private System.Windows.Forms.TextBox txtTelefonoE;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBuscarEm;
        private System.Windows.Forms.TextBox txtDNIEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipoEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxEstadoEmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRegresarD;
    }
}