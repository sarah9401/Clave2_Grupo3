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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaVuelo = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraLlegada = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewHorarios = new System.Windows.Forms.DataGridView();
            this.btnAgregarHorario = new System.Windows.Forms.Button();
            this.btnModificarHorario = new System.Windows.Forms.Button();
            this.btnEliminarHorario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Vuelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora Salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora Llegada";
            // 
            // dtpFechaVuelo
            // 
            this.dtpFechaVuelo.Location = new System.Drawing.Point(144, 54);
            this.dtpFechaVuelo.Name = "dtpFechaVuelo";
            this.dtpFechaVuelo.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVuelo.TabIndex = 3;
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSalida.Location = new System.Drawing.Point(144, 89);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(200, 20);
            this.dtpHoraSalida.TabIndex = 4;
            // 
            // dtpHoraLlegada
            // 
            this.dtpHoraLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraLlegada.Location = new System.Drawing.Point(144, 128);
            this.dtpHoraLlegada.Name = "dtpHoraLlegada";
            this.dtpHoraLlegada.Size = new System.Drawing.Size(200, 20);
            this.dtpHoraLlegada.TabIndex = 5;
            // 
            // dataGridViewHorarios
            // 
            this.dataGridViewHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorarios.Location = new System.Drawing.Point(61, 231);
            this.dataGridViewHorarios.Name = "dataGridViewHorarios";
            this.dataGridViewHorarios.Size = new System.Drawing.Size(672, 150);
            this.dataGridViewHorarios.TabIndex = 6;
            this.dataGridViewHorarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHorarios_CellContentClick_1);
            // 
            // btnAgregarHorario
            // 
            this.btnAgregarHorario.Location = new System.Drawing.Point(537, 55);
            this.btnAgregarHorario.Name = "btnAgregarHorario";
            this.btnAgregarHorario.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarHorario.TabIndex = 7;
            this.btnAgregarHorario.Text = "Agregar";
            this.btnAgregarHorario.UseVisualStyleBackColor = true;
            this.btnAgregarHorario.Click += new System.EventHandler(this.btnAgregarHorario_Click_1);
            // 
            // btnModificarHorario
            // 
            this.btnModificarHorario.Location = new System.Drawing.Point(537, 86);
            this.btnModificarHorario.Name = "btnModificarHorario";
            this.btnModificarHorario.Size = new System.Drawing.Size(75, 23);
            this.btnModificarHorario.TabIndex = 8;
            this.btnModificarHorario.Text = "Modificar";
            this.btnModificarHorario.UseVisualStyleBackColor = true;
            this.btnModificarHorario.Click += new System.EventHandler(this.btnModificarHorario_Click_1);
            // 
            // btnEliminarHorario
            // 
            this.btnEliminarHorario.Location = new System.Drawing.Point(537, 118);
            this.btnEliminarHorario.Name = "btnEliminarHorario";
            this.btnEliminarHorario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarHorario.TabIndex = 9;
            this.btnEliminarHorario.Text = "Eliminar";
            this.btnEliminarHorario.UseVisualStyleBackColor = true;
            this.btnEliminarHorario.Click += new System.EventHandler(this.btnEliminarHorario_Click_1);
            // 
            // Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarHorario);
            this.Controls.Add(this.btnModificarHorario);
            this.Controls.Add(this.btnAgregarHorario);
            this.Controls.Add(this.dataGridViewHorarios);
            this.Controls.Add(this.dtpHoraLlegada);
            this.Controls.Add(this.dtpHoraSalida);
            this.Controls.Add(this.dtpFechaVuelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaVuelo;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.DateTimePicker dtpHoraLlegada;
        private System.Windows.Forms.DataGridView dataGridViewHorarios;
        private System.Windows.Forms.Button btnAgregarHorario;
        private System.Windows.Forms.Button btnModificarHorario;
        private System.Windows.Forms.Button btnEliminarHorario;
    }
}