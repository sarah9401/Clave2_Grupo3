
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
            this.btnRutaTarifa = new System.Windows.Forms.Button();
            this.btnAsientos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRutaTarifa
            // 
            this.btnRutaTarifa.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutaTarifa.Location = new System.Drawing.Point(66, 48);
            this.btnRutaTarifa.Margin = new System.Windows.Forms.Padding(4);
            this.btnRutaTarifa.Name = "btnRutaTarifa";
            this.btnRutaTarifa.Size = new System.Drawing.Size(175, 106);
            this.btnRutaTarifa.TabIndex = 2;
            this.btnRutaTarifa.Text = "Ruta tarifa";
            this.btnRutaTarifa.UseVisualStyleBackColor = true;
            // 
            // btnAsientos
            // 
            this.btnAsientos.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsientos.Location = new System.Drawing.Point(249, 48);
            this.btnAsientos.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsientos.Name = "btnAsientos";
            this.btnAsientos.Size = new System.Drawing.Size(191, 106);
            this.btnAsientos.TabIndex = 3;
            this.btnAsientos.Text = "Asientos";
            this.btnAsientos.UseVisualStyleBackColor = true;
            // 
            // PantallaInicioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SystemAirline___PROYECTO.Properties.Resources.Fondo_principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 536);
            this.Controls.Add(this.btnAsientos);
            this.Controls.Add(this.btnRutaTarifa);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PantallaInicioUsuario";
            this.Text = "PantallaInicioUsuario";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRutaTarifa;
        private System.Windows.Forms.Button btnAsientos;
    }
}