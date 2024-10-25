
namespace SystemAirline___PROYECTO
{
    partial class PantallaInicioUsuario
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
            this.btnCrearReservaciones = new System.Windows.Forms.Button();
            this.btnVerReservaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearReservaciones
            // 
            this.btnCrearReservaciones.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReservaciones.Location = new System.Drawing.Point(44, 34);
            this.btnCrearReservaciones.Name = "btnCrearReservaciones";
            this.btnCrearReservaciones.Size = new System.Drawing.Size(357, 64);
            this.btnCrearReservaciones.TabIndex = 2;
            this.btnCrearReservaciones.Text = "CREAR RESERVACION";
            this.btnCrearReservaciones.UseVisualStyleBackColor = true;
            // 
            // btnVerReservaciones
            // 
            this.btnVerReservaciones.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReservaciones.Location = new System.Drawing.Point(44, 132);
            this.btnVerReservaciones.Name = "btnVerReservaciones";
            this.btnVerReservaciones.Size = new System.Drawing.Size(357, 64);
            this.btnVerReservaciones.TabIndex = 3;
            this.btnVerReservaciones.Text = "VER MIS RESERVACIONES";
            this.btnVerReservaciones.UseVisualStyleBackColor = true;
            // 
            // PantallaInicioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SystemAirline___PROYECTO.Properties.Resources.Fondo_principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 277);
            this.Controls.Add(this.btnVerReservaciones);
            this.Controls.Add(this.btnCrearReservaciones);
            this.DoubleBuffered = true;
            this.Name = "PantallaInicioUsuario";
            this.Text = "PantallaInicioUsuario";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCrearReservaciones;
        private System.Windows.Forms.Button btnVerReservaciones;
    }
}