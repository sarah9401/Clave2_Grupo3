
namespace SystemAirline___PROYECTO.Empleado
{
    partial class rutas
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
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarRuta = new System.Windows.Forms.Button();
            this.btnModificarRuta = new System.Windows.Forms.Button();
            this.btnEliminarRuta = new System.Windows.Forms.Button();
            this.dataGridViewRutas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoraEstimada = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(212, 85);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(266, 26);
            this.txtOrigen.TabIndex = 0;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(212, 134);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(266, 26);
            this.txtDestino.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino";
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.Location = new System.Drawing.Point(569, 59);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Size = new System.Drawing.Size(126, 40);
            this.btnAgregarRuta.TabIndex = 4;
            this.btnAgregarRuta.Text = "Agregar";
            this.btnAgregarRuta.UseVisualStyleBackColor = true;
            this.btnAgregarRuta.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // btnModificarRuta
            // 
            this.btnModificarRuta.Location = new System.Drawing.Point(569, 105);
            this.btnModificarRuta.Name = "btnModificarRuta";
            this.btnModificarRuta.Size = new System.Drawing.Size(126, 40);
            this.btnModificarRuta.TabIndex = 5;
            this.btnModificarRuta.Text = "Modificar";
            this.btnModificarRuta.UseVisualStyleBackColor = true;
            this.btnModificarRuta.Click += new System.EventHandler(this.btnModificarRuta_Click);
            // 
            // btnEliminarRuta
            // 
            this.btnEliminarRuta.Location = new System.Drawing.Point(569, 151);
            this.btnEliminarRuta.Name = "btnEliminarRuta";
            this.btnEliminarRuta.Size = new System.Drawing.Size(126, 40);
            this.btnEliminarRuta.TabIndex = 6;
            this.btnEliminarRuta.Text = "Eliminar";
            this.btnEliminarRuta.UseVisualStyleBackColor = true;
            this.btnEliminarRuta.Click += new System.EventHandler(this.btnEliminarRuta_Click);
            // 
            // dataGridViewRutas
            // 
            this.dataGridViewRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRutas.Location = new System.Drawing.Point(30, 240);
            this.dataGridViewRutas.Name = "dataGridViewRutas";
            this.dataGridViewRutas.RowHeadersWidth = 62;
            this.dataGridViewRutas.RowTemplate.Height = 28;
            this.dataGridViewRutas.Size = new System.Drawing.Size(706, 187);
            this.dataGridViewRutas.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hora Estimada";
            // 
            // txtHoraEstimada
            // 
            this.txtHoraEstimada.Location = new System.Drawing.Point(212, 181);
            this.txtHoraEstimada.Name = "txtHoraEstimada";
            this.txtHoraEstimada.Size = new System.Drawing.Size(266, 26);
            this.txtHoraEstimada.TabIndex = 9;
            // 
            // rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHoraEstimada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewRutas);
            this.Controls.Add(this.btnEliminarRuta);
            this.Controls.Add(this.btnModificarRuta);
            this.Controls.Add(this.btnAgregarRuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Name = "rutas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.rutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarRuta;
        private System.Windows.Forms.Button btnModificarRuta;
        private System.Windows.Forms.Button btnEliminarRuta;
        private System.Windows.Forms.DataGridView dataGridViewRutas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoraEstimada;
    }
}