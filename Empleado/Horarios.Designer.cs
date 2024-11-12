
namespace SystemAirline___PROYECTO.Empleado
{
    partial class Horarios
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaVuelo = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraLlegada = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarHorario = new System.Windows.Forms.Button();
            this.btnModificarHorario = new System.Windows.Forms.Button();
            this.btnEliminarHorario = new System.Windows.Forms.Button();
            this.dataGridViewHorarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Vuelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora Salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hora Llegada";
            // 
            // dtpFechaVuelo
            // 
            this.dtpFechaVuelo.Location = new System.Drawing.Point(271, 64);
            this.dtpFechaVuelo.Name = "dtpFechaVuelo";
            this.dtpFechaVuelo.Size = new System.Drawing.Size(313, 26);
            this.dtpFechaVuelo.TabIndex = 5;
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Location = new System.Drawing.Point(271, 110);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(313, 26);
            this.dtpHoraSalida.TabIndex = 6;
            // 
            // dtpHoraLlegada
            // 
            this.dtpHoraLlegada.Location = new System.Drawing.Point(271, 158);
            this.dtpHoraLlegada.Name = "dtpHoraLlegada";
            this.dtpHoraLlegada.Size = new System.Drawing.Size(313, 26);
            this.dtpHoraLlegada.TabIndex = 7;
            // 
            // btnAgregarHorario
            // 
            this.btnAgregarHorario.Location = new System.Drawing.Point(728, 64);
            this.btnAgregarHorario.Name = "btnAgregarHorario";
            this.btnAgregarHorario.Size = new System.Drawing.Size(121, 43);
            this.btnAgregarHorario.TabIndex = 8;
            this.btnAgregarHorario.Text = "Agregar";
            this.btnAgregarHorario.UseVisualStyleBackColor = true;
            this.btnAgregarHorario.Click += new System.EventHandler(this.btnAgregarHorario_Click);
            // 
            // btnModificarHorario
            // 
            this.btnModificarHorario.Location = new System.Drawing.Point(728, 124);
            this.btnModificarHorario.Name = "btnModificarHorario";
            this.btnModificarHorario.Size = new System.Drawing.Size(121, 43);
            this.btnModificarHorario.TabIndex = 9;
            this.btnModificarHorario.Text = "Modificar";
            this.btnModificarHorario.UseVisualStyleBackColor = true;
            this.btnModificarHorario.Click += new System.EventHandler(this.btnModificarHorario_Click);
            // 
            // btnEliminarHorario
            // 
            this.btnEliminarHorario.Location = new System.Drawing.Point(728, 188);
            this.btnEliminarHorario.Name = "btnEliminarHorario";
            this.btnEliminarHorario.Size = new System.Drawing.Size(121, 43);
            this.btnEliminarHorario.TabIndex = 10;
            this.btnEliminarHorario.Text = "Eliminar";
            this.btnEliminarHorario.UseVisualStyleBackColor = true;
            this.btnEliminarHorario.Click += new System.EventHandler(this.btnEliminarHorario_Click);
            // 
            // dataGridViewHorarios
            // 
            this.dataGridViewHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorarios.Location = new System.Drawing.Point(24, 289);
            this.dataGridViewHorarios.Name = "dataGridViewHorarios";
            this.dataGridViewHorarios.RowHeadersWidth = 62;
            this.dataGridViewHorarios.RowTemplate.Height = 28;
            this.dataGridViewHorarios.Size = new System.Drawing.Size(924, 295);
            this.dataGridViewHorarios.TabIndex = 11;
            this.dataGridViewHorarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHorarios_CellContentClick);
            // 
            // Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 627);
            this.Controls.Add(this.dataGridViewHorarios);
            this.Controls.Add(this.btnEliminarHorario);
            this.Controls.Add(this.btnModificarHorario);
            this.Controls.Add(this.btnAgregarHorario);
            this.Controls.Add(this.dtpHoraLlegada);
            this.Controls.Add(this.dtpHoraSalida);
            this.Controls.Add(this.dtpFechaVuelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Horarios";
            this.Text = "Horarios";
            this.Load += new System.EventHandler(this.Horarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaVuelo;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.DateTimePicker dtpHoraLlegada;
        private System.Windows.Forms.Button btnAgregarHorario;
        private System.Windows.Forms.Button btnModificarHorario;
        private System.Windows.Forms.Button btnEliminarHorario;
        private System.Windows.Forms.DataGridView dataGridViewHorarios;
    }
}