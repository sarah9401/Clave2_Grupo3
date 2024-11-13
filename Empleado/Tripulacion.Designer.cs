
namespace SystemAirline___PROYECTO.Empleado
{
    partial class Tripulacion
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
            this.btnAgregarTripulacion = new System.Windows.Forms.Button();
            this.btnModificartripulacion = new System.Windows.Forms.Button();
            this.btnEliminarTripulacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreTripulacion = new System.Windows.Forms.TextBox();
            this.dgvTripulacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTripulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarTripulacion
            // 
            this.btnAgregarTripulacion.Location = new System.Drawing.Point(619, 45);
            this.btnAgregarTripulacion.Name = "btnAgregarTripulacion";
            this.btnAgregarTripulacion.Size = new System.Drawing.Size(84, 33);
            this.btnAgregarTripulacion.TabIndex = 0;
            this.btnAgregarTripulacion.Text = "Agregar";
            this.btnAgregarTripulacion.UseVisualStyleBackColor = true;
            this.btnAgregarTripulacion.Click += new System.EventHandler(this.btnAgregarTripulacion_Click);
            // 
            // btnModificartripulacion
            // 
            this.btnModificartripulacion.Location = new System.Drawing.Point(619, 98);
            this.btnModificartripulacion.Name = "btnModificartripulacion";
            this.btnModificartripulacion.Size = new System.Drawing.Size(84, 33);
            this.btnModificartripulacion.TabIndex = 1;
            this.btnModificartripulacion.Text = "Modificar";
            this.btnModificartripulacion.UseVisualStyleBackColor = true;
            this.btnModificartripulacion.Click += new System.EventHandler(this.btnModificartripulacion_Click);
            // 
            // btnEliminarTripulacion
            // 
            this.btnEliminarTripulacion.Location = new System.Drawing.Point(619, 149);
            this.btnEliminarTripulacion.Name = "btnEliminarTripulacion";
            this.btnEliminarTripulacion.Size = new System.Drawing.Size(84, 33);
            this.btnEliminarTripulacion.TabIndex = 2;
            this.btnEliminarTripulacion.Text = "Eliminar";
            this.btnEliminarTripulacion.UseVisualStyleBackColor = true;
            this.btnEliminarTripulacion.Click += new System.EventHandler(this.btnEliminarTripulacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre tripulacion";
            // 
            // txtNombreTripulacion
            // 
            this.txtNombreTripulacion.Location = new System.Drawing.Point(163, 115);
            this.txtNombreTripulacion.Name = "txtNombreTripulacion";
            this.txtNombreTripulacion.Size = new System.Drawing.Size(284, 20);
            this.txtNombreTripulacion.TabIndex = 4;
            // 
            // dgvTripulacion
            // 
            this.dgvTripulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTripulacion.Location = new System.Drawing.Point(22, 253);
            this.dgvTripulacion.Name = "dgvTripulacion";
            this.dgvTripulacion.Size = new System.Drawing.Size(623, 150);
            this.dgvTripulacion.TabIndex = 5;
            this.dgvTripulacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTripulacion_CellContentClick);
            // 
            // Tripulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTripulacion);
            this.Controls.Add(this.txtNombreTripulacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarTripulacion);
            this.Controls.Add(this.btnModificartripulacion);
            this.Controls.Add(this.btnAgregarTripulacion);
            this.Name = "Tripulacion";
            this.Text = "Tripulacion";
            this.Load += new System.EventHandler(this.Tripulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTripulacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarTripulacion;
        private System.Windows.Forms.Button btnModificartripulacion;
        private System.Windows.Forms.Button btnEliminarTripulacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreTripulacion;
        private System.Windows.Forms.DataGridView dgvTripulacion;
    }
}