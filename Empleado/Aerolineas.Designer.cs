
namespace SystemAirline___PROYECTO.Empleado
{
    partial class Aerolineas
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
            this.txtNombreAerolinea = new System.Windows.Forms.TextBox();
            this.txtPaisOrigen = new System.Windows.Forms.TextBox();
            this.btnAgregarAerolinea = new System.Windows.Forms.Button();
            this.btnModificarAerolinea = new System.Windows.Forms.Button();
            this.btnEliminarAerolinea = new System.Windows.Forms.Button();
            this.dgvAerolineas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdAerolinea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAerolineas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Aerolinea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pais de Origen";
            // 
            // txtNombreAerolinea
            // 
            this.txtNombreAerolinea.Location = new System.Drawing.Point(176, 71);
            this.txtNombreAerolinea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreAerolinea.Name = "txtNombreAerolinea";
            this.txtNombreAerolinea.Size = new System.Drawing.Size(263, 22);
            this.txtNombreAerolinea.TabIndex = 2;
            // 
            // txtPaisOrigen
            // 
            this.txtPaisOrigen.Location = new System.Drawing.Point(176, 107);
            this.txtPaisOrigen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaisOrigen.Name = "txtPaisOrigen";
            this.txtPaisOrigen.Size = new System.Drawing.Size(263, 22);
            this.txtPaisOrigen.TabIndex = 3;
            // 
            // btnAgregarAerolinea
            // 
            this.btnAgregarAerolinea.Location = new System.Drawing.Point(547, 33);
            this.btnAgregarAerolinea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarAerolinea.Name = "btnAgregarAerolinea";
            this.btnAgregarAerolinea.Size = new System.Drawing.Size(77, 26);
            this.btnAgregarAerolinea.TabIndex = 4;
            this.btnAgregarAerolinea.Text = "Agregar";
            this.btnAgregarAerolinea.UseVisualStyleBackColor = true;
            this.btnAgregarAerolinea.Click += new System.EventHandler(this.btnAgregarAerolinea_Click);
            // 
            // btnModificarAerolinea
            // 
            this.btnModificarAerolinea.Location = new System.Drawing.Point(547, 71);
            this.btnModificarAerolinea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarAerolinea.Name = "btnModificarAerolinea";
            this.btnModificarAerolinea.Size = new System.Drawing.Size(77, 26);
            this.btnModificarAerolinea.TabIndex = 5;
            this.btnModificarAerolinea.Text = "Modificar";
            this.btnModificarAerolinea.UseVisualStyleBackColor = true;
            this.btnModificarAerolinea.Click += new System.EventHandler(this.btnModificarAerolinea_Click);
            // 
            // btnEliminarAerolinea
            // 
            this.btnEliminarAerolinea.Location = new System.Drawing.Point(547, 112);
            this.btnEliminarAerolinea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarAerolinea.Name = "btnEliminarAerolinea";
            this.btnEliminarAerolinea.Size = new System.Drawing.Size(77, 26);
            this.btnEliminarAerolinea.TabIndex = 6;
            this.btnEliminarAerolinea.Text = "Eliminar";
            this.btnEliminarAerolinea.UseVisualStyleBackColor = true;
            this.btnEliminarAerolinea.Click += new System.EventHandler(this.btnEliminarAerolinea_Click);
            // 
            // dgvAerolineas
            // 
            this.dgvAerolineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAerolineas.Location = new System.Drawing.Point(11, 163);
            this.dgvAerolineas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAerolineas.Name = "dgvAerolineas";
            this.dgvAerolineas.RowHeadersWidth = 62;
            this.dgvAerolineas.RowTemplate.Height = 28;
            this.dgvAerolineas.Size = new System.Drawing.Size(690, 179);
            this.dgvAerolineas.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Id Aeroliena";
            // 
            // txtIdAerolinea
            // 
            this.txtIdAerolinea.Location = new System.Drawing.Point(176, 33);
            this.txtIdAerolinea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdAerolinea.Name = "txtIdAerolinea";
            this.txtIdAerolinea.Size = new System.Drawing.Size(263, 22);
            this.txtIdAerolinea.TabIndex = 9;
            // 
            // Aerolineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.txtIdAerolinea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAerolineas);
            this.Controls.Add(this.btnEliminarAerolinea);
            this.Controls.Add(this.btnModificarAerolinea);
            this.Controls.Add(this.btnAgregarAerolinea);
            this.Controls.Add(this.txtPaisOrigen);
            this.Controls.Add(this.txtNombreAerolinea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Aerolineas";
            this.Text = "Aerolineas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAerolineas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreAerolinea;
        private System.Windows.Forms.TextBox txtPaisOrigen;
        private System.Windows.Forms.Button btnAgregarAerolinea;
        private System.Windows.Forms.Button btnModificarAerolinea;
        private System.Windows.Forms.Button btnEliminarAerolinea;
        private System.Windows.Forms.DataGridView dgvAerolineas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdAerolinea;
    }
}