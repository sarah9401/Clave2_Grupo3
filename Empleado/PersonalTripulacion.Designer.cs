
namespace SystemAirline___PROYECTO.Empleado
{
    partial class PersonalTripulacion
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
            this.btnAgregarPersonal = new System.Windows.Forms.Button();
            this.btnModificarPersonal = new System.Windows.Forms.Button();
            this.btnEliminarPersonal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonal = new System.Windows.Forms.TextBox();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTripulacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarPersonal
            // 
            this.btnAgregarPersonal.Location = new System.Drawing.Point(577, 80);
            this.btnAgregarPersonal.Name = "btnAgregarPersonal";
            this.btnAgregarPersonal.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPersonal.TabIndex = 0;
            this.btnAgregarPersonal.Text = "Agregar";
            this.btnAgregarPersonal.UseVisualStyleBackColor = true;
            this.btnAgregarPersonal.Click += new System.EventHandler(this.btnAgregarPersonal_Click);
            // 
            // btnModificarPersonal
            // 
            this.btnModificarPersonal.Location = new System.Drawing.Point(577, 118);
            this.btnModificarPersonal.Name = "btnModificarPersonal";
            this.btnModificarPersonal.Size = new System.Drawing.Size(75, 23);
            this.btnModificarPersonal.TabIndex = 1;
            this.btnModificarPersonal.Text = "Modificar";
            this.btnModificarPersonal.UseVisualStyleBackColor = true;
            this.btnModificarPersonal.Click += new System.EventHandler(this.btnModificarPersonal_Click);
            // 
            // btnEliminarPersonal
            // 
            this.btnEliminarPersonal.Location = new System.Drawing.Point(577, 160);
            this.btnEliminarPersonal.Name = "btnEliminarPersonal";
            this.btnEliminarPersonal.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPersonal.TabIndex = 2;
            this.btnEliminarPersonal.Text = "Eliminar";
            this.btnEliminarPersonal.UseVisualStyleBackColor = true;
            this.btnEliminarPersonal.Click += new System.EventHandler(this.btnEliminarPersonal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // txtPersonal
            // 
            this.txtPersonal.Location = new System.Drawing.Point(213, 106);
            this.txtPersonal.Name = "txtPersonal";
            this.txtPersonal.Size = new System.Drawing.Size(238, 20);
            this.txtPersonal.TabIndex = 4;
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Location = new System.Drawing.Point(113, 239);
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.Size = new System.Drawing.Size(568, 150);
            this.dgvPersonal.TabIndex = 5;
            this.dgvPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonal_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cargo";
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Piloto",
            "Copiloto",
            "Ingeniero de Vuelo",
            "Jefe de Cabina",
            "Asistente de Vuelo",
            "Oficial de Seguridad Aerea"});
            this.cmbCargo.Location = new System.Drawing.Point(213, 140);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(165, 21);
            this.cmbCargo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tripulacion";
            // 
            // cmbTripulacion
            // 
            this.cmbTripulacion.FormattingEnabled = true;
            this.cmbTripulacion.Location = new System.Drawing.Point(213, 179);
            this.cmbTripulacion.Name = "cmbTripulacion";
            this.cmbTripulacion.Size = new System.Drawing.Size(165, 21);
            this.cmbTripulacion.TabIndex = 9;
            // 
            // PersonalTripulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTripulacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPersonal);
            this.Controls.Add(this.txtPersonal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarPersonal);
            this.Controls.Add(this.btnModificarPersonal);
            this.Controls.Add(this.btnAgregarPersonal);
            this.Name = "PersonalTripulacion";
            this.Text = "PersonalTripulacion";
            this.Load += new System.EventHandler(this.PersonalTripulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarPersonal;
        private System.Windows.Forms.Button btnModificarPersonal;
        private System.Windows.Forms.Button btnEliminarPersonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonal;
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTripulacion;
    }
}