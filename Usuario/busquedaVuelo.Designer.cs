
namespace SystemAirline___PROYECTO
{
    partial class formPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.gpbGeneral = new System.Windows.Forms.GroupBox();
            this.btnBuscarVuelo = new System.Windows.Forms.Button();
            this.gpbSoloIdaSelected = new System.Windows.Forms.GroupBox();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown4 = new System.Windows.Forms.DomainUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gpbSoloIda = new System.Windows.Forms.GroupBox();
            this.dtpSoloIda = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDatosVuelos = new System.Windows.Forms.DataGridView();
            this.Aerolinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gpbGeneral.SuspendLayout();
            this.gpbSoloIdaSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbGeneral
            // 
            this.gpbGeneral.BackColor = System.Drawing.Color.Transparent;
            this.gpbGeneral.Controls.Add(this.btnBuscarVuelo);
            this.gpbGeneral.Controls.Add(this.gpbSoloIdaSelected);
            this.gpbGeneral.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbGeneral.Location = new System.Drawing.Point(93, 11);
            this.gpbGeneral.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbGeneral.Name = "gpbGeneral";
            this.gpbGeneral.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbGeneral.Size = new System.Drawing.Size(524, 312);
            this.gpbGeneral.TabIndex = 3;
            this.gpbGeneral.TabStop = false;
            this.gpbGeneral.Text = "Consulta y busqueda de vuelos";
            // 
            // btnBuscarVuelo
            // 
            this.btnBuscarVuelo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarVuelo.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarVuelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarVuelo.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVuelo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarVuelo.Location = new System.Drawing.Point(382, 269);
            this.btnBuscarVuelo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBuscarVuelo.Name = "btnBuscarVuelo";
            this.btnBuscarVuelo.Size = new System.Drawing.Size(142, 27);
            this.btnBuscarVuelo.TabIndex = 2;
            this.btnBuscarVuelo.Text = "Buscar vuelo";
            this.btnBuscarVuelo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarVuelo.UseVisualStyleBackColor = false;
            // 
            // gpbSoloIdaSelected
            // 
            this.gpbSoloIdaSelected.BackColor = System.Drawing.Color.Transparent;
            this.gpbSoloIdaSelected.Controls.Add(this.dtpSoloIda);
            this.gpbSoloIdaSelected.Controls.Add(this.comboBox1);
            this.gpbSoloIdaSelected.Controls.Add(this.domainUpDown3);
            this.gpbSoloIdaSelected.Controls.Add(this.domainUpDown4);
            this.gpbSoloIdaSelected.Controls.Add(this.label7);
            this.gpbSoloIdaSelected.Controls.Add(this.label8);
            this.gpbSoloIdaSelected.Controls.Add(this.gpbSoloIda);
            this.gpbSoloIdaSelected.Controls.Add(this.label4);
            this.gpbSoloIdaSelected.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSoloIdaSelected.Location = new System.Drawing.Point(200, 39);
            this.gpbSoloIdaSelected.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbSoloIdaSelected.Name = "gpbSoloIdaSelected";
            this.gpbSoloIdaSelected.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbSoloIdaSelected.Size = new System.Drawing.Size(324, 235);
            this.gpbSoloIdaSelected.TabIndex = 1;
            this.gpbSoloIdaSelected.TabStop = false;
            this.gpbSoloIdaSelected.Text = "Seleccion de vuelo";
            // 
            // domainUpDown3
            // 
            this.domainUpDown3.Location = new System.Drawing.Point(78, 192);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.Size = new System.Drawing.Size(64, 23);
            this.domainUpDown3.TabIndex = 15;
            // 
            // domainUpDown4
            // 
            this.domainUpDown4.Location = new System.Drawing.Point(78, 162);
            this.domainUpDown4.Name = "domainUpDown4";
            this.domainUpDown4.Size = new System.Drawing.Size(64, 23);
            this.domainUpDown4.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Niños:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Adultos:";
            // 
            // gpbSoloIda
            // 
            this.gpbSoloIda.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSoloIda.Location = new System.Drawing.Point(4, 96);
            this.gpbSoloIda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbSoloIda.Name = "gpbSoloIda";
            this.gpbSoloIda.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbSoloIda.Size = new System.Drawing.Size(138, 23);
            this.gpbSoloIda.TabIndex = 4;
            this.gpbSoloIda.TabStop = false;
            this.gpbSoloIda.Text = "Fecha de vuelo";
            // 
            // dtpSoloIda
            // 
            this.dtpSoloIda.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSoloIda.Location = new System.Drawing.Point(5, 119);
            this.dtpSoloIda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpSoloIda.Name = "dtpSoloIda";
            this.dtpSoloIda.Size = new System.Drawing.Size(167, 20);
            this.dtpSoloIda.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vuelo";
            // 
            // dgvDatosVuelos
            // 
            this.dgvDatosVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosVuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aerolinea,
            this.Ruta,
            this.Duracion,
            this.TipoAvion,
            this.Tarifa,
            this.Seleccion});
            this.dgvDatosVuelos.Location = new System.Drawing.Point(45, 329);
            this.dgvDatosVuelos.Name = "dgvDatosVuelos";
            this.dgvDatosVuelos.RowHeadersWidth = 62;
            this.dgvDatosVuelos.Size = new System.Drawing.Size(653, 131);
            this.dgvDatosVuelos.TabIndex = 4;
            // 
            // Aerolinea
            // 
            this.Aerolinea.HeaderText = "AEROLINEA";
            this.Aerolinea.MinimumWidth = 8;
            this.Aerolinea.Name = "Aerolinea";
            this.Aerolinea.Width = 150;
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "RUTA DE VIAJE";
            this.Ruta.MinimumWidth = 8;
            this.Ruta.Name = "Ruta";
            this.Ruta.Width = 150;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "DURACION DEL VUELO";
            this.Duracion.MinimumWidth = 8;
            this.Duracion.Name = "Duracion";
            this.Duracion.Width = 150;
            // 
            // TipoAvion
            // 
            this.TipoAvion.HeaderText = "TIPO DE AVION";
            this.TipoAvion.MinimumWidth = 8;
            this.TipoAvion.Name = "TipoAvion";
            this.TipoAvion.Width = 150;
            // 
            // Tarifa
            // 
            this.Tarifa.HeaderText = "TARIFA";
            this.Tarifa.MinimumWidth = 8;
            this.Tarifa.Name = "Tarifa";
            this.Tarifa.Width = 150;
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "SELECCIONAR";
            this.Seleccion.MinimumWidth = 8;
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Text = "SELECCIONAR";
            this.Seleccion.ToolTipText = "SELECCIONAR";
            this.Seleccion.UseColumnTextForButtonValue = true;
            this.Seleccion.Width = 150;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 26);
            this.comboBox1.TabIndex = 16;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SystemAirline___PROYECTO.Properties.Resources.Fondo_principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 549);
            this.Controls.Add(this.dgvDatosVuelos);
            this.Controls.Add(this.gpbGeneral);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "formPrincipal";
            this.Text = " ";
            this.gpbGeneral.ResumeLayout(false);
            this.gpbSoloIdaSelected.ResumeLayout(false);
            this.gpbSoloIdaSelected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVuelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbGeneral;
        private System.Windows.Forms.Button btnBuscarVuelo;
        private System.Windows.Forms.GroupBox gpbSoloIdaSelected;
        private System.Windows.Forms.GroupBox gpbSoloIda;
        private System.Windows.Forms.DateTimePicker dtpSoloIda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDatosVuelos;
        private System.Windows.Forms.DomainUpDown domainUpDown3;
        private System.Windows.Forms.DomainUpDown domainUpDown4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aerolinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccion;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

