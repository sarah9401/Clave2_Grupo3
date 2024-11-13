namespace SystemAirline___PROYECTO.Empleado
{
    partial class RutaTarifa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRuta = new System.Windows.Forms.ComboBox();
            this.cmbTarifa = new System.Windows.Forms.ComboBox();
            this.dtRutaTarifa = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtRutaTarifa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ruta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarifa";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(148, 100);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(191, 22);
            this.txtPrecio.TabIndex = 3;
            // 
            // cmbRuta
            // 
            this.cmbRuta.FormattingEnabled = true;
            this.cmbRuta.Location = new System.Drawing.Point(148, 133);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Size = new System.Drawing.Size(144, 21);
            this.cmbRuta.TabIndex = 4;
            // 
            // cmbTarifa
            // 
            this.cmbTarifa.FormattingEnabled = true;
            this.cmbTarifa.Location = new System.Drawing.Point(148, 173);
            this.cmbTarifa.Name = "cmbTarifa";
            this.cmbTarifa.Size = new System.Drawing.Size(144, 21);
            this.cmbTarifa.TabIndex = 5;
            // 
            // dtRutaTarifa
            // 
            this.dtRutaTarifa.AllowUserToAddRows = false;
            this.dtRutaTarifa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtRutaTarifa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtRutaTarifa.BackgroundColor = System.Drawing.Color.White;
            this.dtRutaTarifa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtRutaTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRutaTarifa.Location = new System.Drawing.Point(55, 218);
            this.dtRutaTarifa.Name = "dtRutaTarifa";
            this.dtRutaTarifa.ReadOnly = true;
            this.dtRutaTarifa.RowHeadersWidth = 51;
            this.dtRutaTarifa.RowTemplate.Height = 24;
            this.dtRutaTarifa.Size = new System.Drawing.Size(574, 272);
            this.dtRutaTarifa.TabIndex = 8;
            this.dtRutaTarifa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtRutaTarifa_CellContentClick);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(373, 46);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(82, 34);
            this.btn_agregar.TabIndex = 7;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.button1.Location = new System.Drawing.Point(457, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RutaTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtRutaTarifa);
            this.Controls.Add(this.cmbTarifa);
            this.Controls.Add(this.cmbRuta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RutaTarifa";
            this.Text = "Ruta tarifa";
            ((System.ComponentModel.ISupportInitialize)(this.dtRutaTarifa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRuta;
        private System.Windows.Forms.ComboBox cmbTarifa;
        private System.Windows.Forms.DataGridView dtRutaTarifa;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
    }
}