
namespace SystemAirline___PROYECTO.Empleado
{
    partial class Tarifaform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregarTarifa = new System.Windows.Forms.Button();
            this.btnModificarTarifa = new System.Windows.Forms.Button();
            this.btnEliminarTarifa = new System.Windows.Forms.Button();
            this.dgvTarifa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarifa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(170, 75);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(273, 20);
            this.txtTarifa.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(170, 110);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(273, 69);
            this.txtDescripcion.TabIndex = 3;
            // 
            // btnAgregarTarifa
            // 
            this.btnAgregarTarifa.Location = new System.Drawing.Point(595, 68);
            this.btnAgregarTarifa.Name = "btnAgregarTarifa";
            this.btnAgregarTarifa.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTarifa.TabIndex = 4;
            this.btnAgregarTarifa.Text = "Agregar";
            this.btnAgregarTarifa.UseVisualStyleBackColor = true;
            this.btnAgregarTarifa.Click += new System.EventHandler(this.btnAgregarTarifa_Click);
            // 
            // btnModificarTarifa
            // 
            this.btnModificarTarifa.Location = new System.Drawing.Point(595, 105);
            this.btnModificarTarifa.Name = "btnModificarTarifa";
            this.btnModificarTarifa.Size = new System.Drawing.Size(75, 23);
            this.btnModificarTarifa.TabIndex = 5;
            this.btnModificarTarifa.Text = "Modificar";
            this.btnModificarTarifa.UseVisualStyleBackColor = true;
            this.btnModificarTarifa.Click += new System.EventHandler(this.btnModificarTarifa_Click);
            // 
            // btnEliminarTarifa
            // 
            this.btnEliminarTarifa.Location = new System.Drawing.Point(595, 143);
            this.btnEliminarTarifa.Name = "btnEliminarTarifa";
            this.btnEliminarTarifa.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTarifa.TabIndex = 6;
            this.btnEliminarTarifa.Text = "Eliminar";
            this.btnEliminarTarifa.UseVisualStyleBackColor = true;
            this.btnEliminarTarifa.Click += new System.EventHandler(this.btnEliminarTarifa_Click);
            // 
            // dgvTarifa
            // 
            this.dgvTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifa.Location = new System.Drawing.Point(98, 241);
            this.dgvTarifa.Name = "dgvTarifa";
            this.dgvTarifa.Size = new System.Drawing.Size(572, 150);
            this.dgvTarifa.TabIndex = 7;
            this.dgvTarifa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarifa_CellContentClick);
            // 
            // Tarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTarifa);
            this.Controls.Add(this.btnEliminarTarifa);
            this.Controls.Add(this.btnModificarTarifa);
            this.Controls.Add(this.btnAgregarTarifa);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tarifa";
            this.Text = "Tarifa";
            this.Load += new System.EventHandler(this.Tarifa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregarTarifa;
        private System.Windows.Forms.Button btnModificarTarifa;
        private System.Windows.Forms.Button btnEliminarTarifa;
        private System.Windows.Forms.DataGridView dgvTarifa;
    }
}