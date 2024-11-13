namespace SystemAirline___PROYECTO.Empleado
{
    partial class Rutas
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtHoraEstimada = new System.Windows.Forms.TextBox();
            this.btnAgregarRuta = new System.Windows.Forms.Button();
            this.btnModificarRuta = new System.Windows.Forms.Button();
            this.btnEliminarRuta = new System.Windows.Forms.Button();
            this.dgvRutas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora Estimada";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(172, 74);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(239, 20);
            this.txtOrigen.TabIndex = 3;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(172, 110);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(239, 20);
            this.txtDestino.TabIndex = 4;
            // 
            // txtHoraEstimada
            // 
            this.txtHoraEstimada.Location = new System.Drawing.Point(172, 145);
            this.txtHoraEstimada.Name = "txtHoraEstimada";
            this.txtHoraEstimada.Size = new System.Drawing.Size(239, 20);
            this.txtHoraEstimada.TabIndex = 5;
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.Location = new System.Drawing.Point(603, 71);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarRuta.TabIndex = 6;
            this.btnAgregarRuta.Text = "Agregar";
            this.btnAgregarRuta.UseVisualStyleBackColor = true;
            this.btnAgregarRuta.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // btnModificarRuta
            // 
            this.btnModificarRuta.Location = new System.Drawing.Point(603, 113);
            this.btnModificarRuta.Name = "btnModificarRuta";
            this.btnModificarRuta.Size = new System.Drawing.Size(75, 23);
            this.btnModificarRuta.TabIndex = 7;
            this.btnModificarRuta.Text = "Modificar";
            this.btnModificarRuta.UseVisualStyleBackColor = true;
            this.btnModificarRuta.Click += new System.EventHandler(this.btnModificarRuta_Click);
            // 
            // btnEliminarRuta
            // 
            this.btnEliminarRuta.Location = new System.Drawing.Point(603, 148);
            this.btnEliminarRuta.Name = "btnEliminarRuta";
            this.btnEliminarRuta.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarRuta.TabIndex = 8;
            this.btnEliminarRuta.Text = "Eliminar";
            this.btnEliminarRuta.UseVisualStyleBackColor = true;
            this.btnEliminarRuta.Click += new System.EventHandler(this.btnEliminarRuta_Click);
            // 
            // dgvRutas
            // 
            this.dgvRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutas.Location = new System.Drawing.Point(80, 228);
            this.dgvRutas.Name = "dgvRutas";
            this.dgvRutas.Size = new System.Drawing.Size(598, 150);
            this.dgvRutas.TabIndex = 9;
            this.dgvRutas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRutas_CellContentClick);
            // 
            // Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRutas);
            this.Controls.Add(this.btnEliminarRuta);
            this.Controls.Add(this.btnModificarRuta);
            this.Controls.Add(this.btnAgregarRuta);
            this.Controls.Add(this.txtHoraEstimada);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Rutas";
            this.Text = "Rutas";
            this.Load += new System.EventHandler(this.Rutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtHoraEstimada;
        private System.Windows.Forms.Button btnAgregarRuta;
        private System.Windows.Forms.Button btnModificarRuta;
        private System.Windows.Forms.Button btnEliminarRuta;
        private System.Windows.Forms.DataGridView dgvRutas;
    }
}