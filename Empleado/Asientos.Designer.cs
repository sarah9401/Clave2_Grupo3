namespace SystemAirline___PROYECTO
{
    partial class Asientos
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dtAsientos = new System.Windows.Forms.DataGridView();
            this.cmbTarifa = new System.Windows.Forms.ComboBox();
            this.cmbVuelo = new System.Windows.Forms.ComboBox();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtAsientos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(98, 35);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(72, 20);
            this.txtid.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "id";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(362, 111);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(82, 34);
            this.btn_eliminar.TabIndex = 21;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(362, 73);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(82, 34);
            this.btn_modificar.TabIndex = 20;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(362, 35);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(82, 34);
            this.btn_agregar.TabIndex = 19;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dtAsientos
            // 
            this.dtAsientos.AllowUserToAddRows = false;
            this.dtAsientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtAsientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtAsientos.BackgroundColor = System.Drawing.Color.White;
            this.dtAsientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAsientos.GridColor = System.Drawing.Color.White;
            this.dtAsientos.Location = new System.Drawing.Point(30, 166);
            this.dtAsientos.Margin = new System.Windows.Forms.Padding(2);
            this.dtAsientos.Name = "dtAsientos";
            this.dtAsientos.ReadOnly = true;
            this.dtAsientos.RowHeadersWidth = 51;
            this.dtAsientos.RowTemplate.Height = 24;
            this.dtAsientos.Size = new System.Drawing.Size(414, 134);
            this.dtAsientos.TabIndex = 24;
            // 
            // cmbTarifa
            // 
            this.cmbTarifa.FormattingEnabled = true;
            this.cmbTarifa.Location = new System.Drawing.Point(98, 99);
            this.cmbTarifa.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTarifa.Name = "cmbTarifa";
            this.cmbTarifa.Size = new System.Drawing.Size(144, 21);
            this.cmbTarifa.TabIndex = 18;
            // 
            // cmbVuelo
            // 
            this.cmbVuelo.FormattingEnabled = true;
            this.cmbVuelo.Location = new System.Drawing.Point(98, 66);
            this.cmbVuelo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVuelo.Name = "cmbVuelo";
            this.cmbVuelo.Size = new System.Drawing.Size(144, 21);
            this.cmbVuelo.TabIndex = 17;
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(50, 99);
            this.lblTarifa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(37, 13);
            this.lblTarifa.TabIndex = 16;
            this.lblTarifa.Text = "Tarifa:";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(50, 68);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(37, 13);
            this.lblRuta.TabIndex = 15;
            this.lblRuta.Text = "Vuelo:";
            // 
            // Asientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 337);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dtAsientos);
            this.Controls.Add(this.cmbTarifa);
            this.Controls.Add(this.cmbVuelo);
            this.Controls.Add(this.lblTarifa);
            this.Controls.Add(this.lblRuta);
            this.Name = "Asientos";
            this.Text = "Asientos";
            ((System.ComponentModel.ISupportInitialize)(this.dtAsientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dtAsientos;
        private System.Windows.Forms.ComboBox cmbTarifa;
        private System.Windows.Forms.ComboBox cmbVuelo;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.Label lblRuta;
    }
}