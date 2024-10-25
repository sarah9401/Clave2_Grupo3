
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
            this.rdbSoloida = new System.Windows.Forms.RadioButton();
            this.rdbIdaVuelta = new System.Windows.Forms.RadioButton();
            this.btnBuscarVuelo = new System.Windows.Forms.Button();
            this.gpbSoloIdaSelected = new System.Windows.Forms.GroupBox();
            this.txtOrigenSoloIda = new System.Windows.Forms.TextBox();
            this.cbmDestinoSoloIda = new System.Windows.Forms.ComboBox();
            this.gpbSoloIda = new System.Windows.Forms.GroupBox();
            this.dtpSoloIda = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbIdaVuelta = new System.Windows.Forms.GroupBox();
            this.txtOrigenIdaVuleta = new System.Windows.Forms.TextBox();
            this.cbmDestinoIDAVUELTA = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtpVuelta = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpIda = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatosVuelos = new System.Windows.Forms.DataGridView();
            this.Aerolinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown4 = new System.Windows.Forms.DomainUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gpbGeneral.SuspendLayout();
            this.gpbSoloIdaSelected.SuspendLayout();
            this.gpbSoloIda.SuspendLayout();
            this.gpbIdaVuelta.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbGeneral
            // 
            this.gpbGeneral.BackColor = System.Drawing.Color.Transparent;
            this.gpbGeneral.Controls.Add(this.rdbSoloida);
            this.gpbGeneral.Controls.Add(this.rdbIdaVuelta);
            this.gpbGeneral.Controls.Add(this.btnBuscarVuelo);
            this.gpbGeneral.Controls.Add(this.gpbSoloIdaSelected);
            this.gpbGeneral.Controls.Add(this.gpbIdaVuelta);
            this.gpbGeneral.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbGeneral.Location = new System.Drawing.Point(10, 11);
            this.gpbGeneral.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbGeneral.Name = "gpbGeneral";
            this.gpbGeneral.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbGeneral.Size = new System.Drawing.Size(716, 441);
            this.gpbGeneral.TabIndex = 3;
            this.gpbGeneral.TabStop = false;
            this.gpbGeneral.Text = "Consulta y busqueda de vuelos";
            // 
            // rdbSoloida
            // 
            this.rdbSoloida.AutoSize = true;
            this.rdbSoloida.Location = new System.Drawing.Point(279, 39);
            this.rdbSoloida.Name = "rdbSoloida";
            this.rdbSoloida.Size = new System.Drawing.Size(94, 23);
            this.rdbSoloida.TabIndex = 4;
            this.rdbSoloida.TabStop = true;
            this.rdbSoloida.Text = "Solo ida";
            this.rdbSoloida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbSoloida.UseVisualStyleBackColor = true;
            // 
            // rdbIdaVuelta
            // 
            this.rdbIdaVuelta.AutoSize = true;
            this.rdbIdaVuelta.Location = new System.Drawing.Point(13, 39);
            this.rdbIdaVuelta.Name = "rdbIdaVuelta";
            this.rdbIdaVuelta.Size = new System.Drawing.Size(126, 23);
            this.rdbIdaVuelta.TabIndex = 3;
            this.rdbIdaVuelta.TabStop = true;
            this.rdbIdaVuelta.Text = "Ida y vuelta";
            this.rdbIdaVuelta.UseVisualStyleBackColor = true;
            // 
            // btnBuscarVuelo
            // 
            this.btnBuscarVuelo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarVuelo.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarVuelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarVuelo.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVuelo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarVuelo.Location = new System.Drawing.Point(554, 406);
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
            this.gpbSoloIdaSelected.Controls.Add(this.domainUpDown3);
            this.gpbSoloIdaSelected.Controls.Add(this.domainUpDown4);
            this.gpbSoloIdaSelected.Controls.Add(this.txtOrigenSoloIda);
            this.gpbSoloIdaSelected.Controls.Add(this.label7);
            this.gpbSoloIdaSelected.Controls.Add(this.cbmDestinoSoloIda);
            this.gpbSoloIdaSelected.Controls.Add(this.label8);
            this.gpbSoloIdaSelected.Controls.Add(this.gpbSoloIda);
            this.gpbSoloIdaSelected.Controls.Add(this.label3);
            this.gpbSoloIdaSelected.Controls.Add(this.label4);
            this.gpbSoloIdaSelected.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSoloIdaSelected.Location = new System.Drawing.Point(372, 68);
            this.gpbSoloIdaSelected.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbSoloIdaSelected.Name = "gpbSoloIdaSelected";
            this.gpbSoloIdaSelected.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbSoloIdaSelected.Size = new System.Drawing.Size(324, 332);
            this.gpbSoloIdaSelected.TabIndex = 1;
            this.gpbSoloIdaSelected.TabStop = false;
            this.gpbSoloIdaSelected.Text = "Solo ida";
            // 
            // txtOrigenSoloIda
            // 
            this.txtOrigenSoloIda.Location = new System.Drawing.Point(11, 66);
            this.txtOrigenSoloIda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtOrigenSoloIda.Name = "txtOrigenSoloIda";
            this.txtOrigenSoloIda.Size = new System.Drawing.Size(182, 23);
            this.txtOrigenSoloIda.TabIndex = 8;
            // 
            // cbmDestinoSoloIda
            // 
            this.cbmDestinoSoloIda.FormattingEnabled = true;
            this.cbmDestinoSoloIda.Items.AddRange(new object[] {
            "Nueva York (EE.UU.)",
            "Las Vegas (EE.UU.)",
            "Toronto (Canadá)",
            "Panamá City (Panamá)",
            "Río de Janeiro (Brasil)",
            "Machu Picchu (Perú)",
            "Santiago (Chile)",
            "París (Francia)",
            "Roma (Italia)",
            "San Salvador (EL Salvador)"});
            this.cbmDestinoSoloIda.Location = new System.Drawing.Point(11, 114);
            this.cbmDestinoSoloIda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbmDestinoSoloIda.Name = "cbmDestinoSoloIda";
            this.cbmDestinoSoloIda.Size = new System.Drawing.Size(182, 26);
            this.cbmDestinoSoloIda.TabIndex = 7;
            // 
            // gpbSoloIda
            // 
            this.gpbSoloIda.Controls.Add(this.dtpSoloIda);
            this.gpbSoloIda.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSoloIda.Location = new System.Drawing.Point(8, 145);
            this.gpbSoloIda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbSoloIda.Name = "gpbSoloIda";
            this.gpbSoloIda.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbSoloIda.Size = new System.Drawing.Size(184, 44);
            this.gpbSoloIda.TabIndex = 4;
            this.gpbSoloIda.TabStop = false;
            this.gpbSoloIda.Text = "Ida:";
            // 
            // dtpSoloIda
            // 
            this.dtpSoloIda.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSoloIda.Location = new System.Drawing.Point(5, 18);
            this.dtpSoloIda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpSoloIda.Name = "dtpSoloIda";
            this.dtpSoloIda.Size = new System.Drawing.Size(167, 20);
            this.dtpSoloIda.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ciudad de destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cuidad de origen:";
            // 
            // gpbIdaVuelta
            // 
            this.gpbIdaVuelta.BackColor = System.Drawing.Color.Transparent;
            this.gpbIdaVuelta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gpbIdaVuelta.Controls.Add(this.domainUpDown2);
            this.gpbIdaVuelta.Controls.Add(this.domainUpDown1);
            this.gpbIdaVuelta.Controls.Add(this.label6);
            this.gpbIdaVuelta.Controls.Add(this.label5);
            this.gpbIdaVuelta.Controls.Add(this.txtOrigenIdaVuleta);
            this.gpbIdaVuelta.Controls.Add(this.cbmDestinoIDAVUELTA);
            this.gpbIdaVuelta.Controls.Add(this.groupBox5);
            this.gpbIdaVuelta.Controls.Add(this.groupBox4);
            this.gpbIdaVuelta.Controls.Add(this.label2);
            this.gpbIdaVuelta.Controls.Add(this.label1);
            this.gpbIdaVuelta.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbIdaVuelta.Location = new System.Drawing.Point(13, 68);
            this.gpbIdaVuelta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbIdaVuelta.Name = "gpbIdaVuelta";
            this.gpbIdaVuelta.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbIdaVuelta.Size = new System.Drawing.Size(342, 332);
            this.gpbIdaVuelta.TabIndex = 0;
            this.gpbIdaVuelta.TabStop = false;
            this.gpbIdaVuelta.Text = "Ida y vuelta";
            // 
            // txtOrigenIdaVuleta
            // 
            this.txtOrigenIdaVuleta.Location = new System.Drawing.Point(5, 66);
            this.txtOrigenIdaVuleta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtOrigenIdaVuleta.Name = "txtOrigenIdaVuleta";
            this.txtOrigenIdaVuleta.Size = new System.Drawing.Size(182, 23);
            this.txtOrigenIdaVuleta.TabIndex = 7;
            // 
            // cbmDestinoIDAVUELTA
            // 
            this.cbmDestinoIDAVUELTA.FormattingEnabled = true;
            this.cbmDestinoIDAVUELTA.Items.AddRange(new object[] {
            "Las Vegas (EE.UU.)",
            "Panamá City (Panamá)",
            "Roma (Italia)",
            "San Salvador (El Salvador)"});
            this.cbmDestinoIDAVUELTA.Location = new System.Drawing.Point(7, 114);
            this.cbmDestinoIDAVUELTA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbmDestinoIDAVUELTA.Name = "cbmDestinoIDAVUELTA";
            this.cbmDestinoIDAVUELTA.Size = new System.Drawing.Size(182, 26);
            this.cbmDestinoIDAVUELTA.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtpVuelta);
            this.groupBox5.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(5, 195);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Size = new System.Drawing.Size(184, 44);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Vuelta:";
            // 
            // dtpVuelta
            // 
            this.dtpVuelta.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVuelta.Location = new System.Drawing.Point(5, 18);
            this.dtpVuelta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpVuelta.Name = "dtpVuelta";
            this.dtpVuelta.Size = new System.Drawing.Size(167, 20);
            this.dtpVuelta.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpIda);
            this.groupBox4.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(5, 145);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(184, 44);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ida:";
            // 
            // dtpIda
            // 
            this.dtpIda.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIda.Location = new System.Drawing.Point(5, 18);
            this.dtpIda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpIda.Name = "dtpIda";
            this.dtpIda.Size = new System.Drawing.Size(167, 20);
            this.dtpIda.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ciudad de destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuidad de origen:";
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
            this.dgvDatosVuelos.Location = new System.Drawing.Point(45, 490);
            this.dgvDatosVuelos.Name = "dgvDatosVuelos";
            this.dgvDatosVuelos.Size = new System.Drawing.Size(653, 131);
            this.dgvDatosVuelos.TabIndex = 4;
            // 
            // Aerolinea
            // 
            this.Aerolinea.HeaderText = "AEROLINEA";
            this.Aerolinea.Name = "Aerolinea";
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "RUTA DE VIAJE";
            this.Ruta.Name = "Ruta";
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "DURACION DEL VUELO";
            this.Duracion.Name = "Duracion";
            // 
            // TipoAvion
            // 
            this.TipoAvion.HeaderText = "TIPO DE AVION";
            this.TipoAvion.Name = "TipoAvion";
            // 
            // Tarifa
            // 
            this.Tarifa.HeaderText = "TARIFA";
            this.Tarifa.Name = "Tarifa";
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "SELECCIONAR";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Text = "SELECCIONAR";
            this.Seleccion.ToolTipText = "SELECCIONAR";
            this.Seleccion.UseColumnTextForButtonValue = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adultos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Niños:";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(81, 253);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(64, 23);
            this.domainUpDown1.TabIndex = 10;
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Location = new System.Drawing.Point(81, 283);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(64, 23);
            this.domainUpDown2.TabIndex = 11;
            // 
            // domainUpDown3
            // 
            this.domainUpDown3.Location = new System.Drawing.Point(82, 240);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.Size = new System.Drawing.Size(64, 23);
            this.domainUpDown3.TabIndex = 15;
            // 
            // domainUpDown4
            // 
            this.domainUpDown4.Location = new System.Drawing.Point(82, 210);
            this.domainUpDown4.Name = "domainUpDown4";
            this.domainUpDown4.Size = new System.Drawing.Size(64, 23);
            this.domainUpDown4.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Niños:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Adultos:";
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SystemAirline___PROYECTO.Properties.Resources.Fondo_principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 673);
            this.Controls.Add(this.dgvDatosVuelos);
            this.Controls.Add(this.gpbGeneral);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "formPrincipal";
            this.Text = " ";
            this.gpbGeneral.ResumeLayout(false);
            this.gpbGeneral.PerformLayout();
            this.gpbSoloIdaSelected.ResumeLayout(false);
            this.gpbSoloIdaSelected.PerformLayout();
            this.gpbSoloIda.ResumeLayout(false);
            this.gpbIdaVuelta.ResumeLayout(false);
            this.gpbIdaVuelta.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVuelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbGeneral;
        private System.Windows.Forms.Button btnBuscarVuelo;
        private System.Windows.Forms.GroupBox gpbSoloIdaSelected;
        private System.Windows.Forms.TextBox txtOrigenSoloIda;
        private System.Windows.Forms.ComboBox cbmDestinoSoloIda;
        private System.Windows.Forms.GroupBox gpbSoloIda;
        private System.Windows.Forms.DateTimePicker dtpSoloIda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpbIdaVuelta;
        private System.Windows.Forms.TextBox txtOrigenIdaVuleta;
        private System.Windows.Forms.ComboBox cbmDestinoIDAVUELTA;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpVuelta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpIda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbSoloida;
        private System.Windows.Forms.RadioButton rdbIdaVuelta;
        private System.Windows.Forms.DataGridView dgvDatosVuelos;
        private System.Windows.Forms.DomainUpDown domainUpDown3;
        private System.Windows.Forms.DomainUpDown domainUpDown4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aerolinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccion;
    }
}

