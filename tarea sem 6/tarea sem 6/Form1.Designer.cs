
using System;

namespace tarea_sem_6
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEncendido = new System.Windows.Forms.Button();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonFrenar = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.Estado = new System.Windows.Forms.Label();
            this.Velocidad = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstcanciones = new System.Windows.Forms.ListBox();
            this.Boxagregar = new System.Windows.Forms.PictureBox();
            this.Cambiosmas = new System.Windows.Forms.Button();
            this.Cambiosmenos = new System.Windows.Forms.Button();
            this.Cambiomas = new System.Windows.Forms.Button();
            this.marcha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boxagregar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEncendido
            // 
            this.btnEncendido.Location = new System.Drawing.Point(116, 29);
            this.btnEncendido.Name = "btnEncendido";
            this.btnEncendido.Size = new System.Drawing.Size(76, 31);
            this.btnEncendido.TabIndex = 0;
            this.btnEncendido.Text = "Crear Carro";
            this.btnEncendido.UseVisualStyleBackColor = true;
            this.btnEncendido.Click += new System.EventHandler(this.btnEncendido_Click);
            // 
            // buttonEncender
            // 
            this.buttonEncender.Location = new System.Drawing.Point(59, 85);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(82, 33);
            this.buttonEncender.TabIndex = 1;
            this.buttonEncender.Text = "Encender";
            this.buttonEncender.UseVisualStyleBackColor = true;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(170, 85);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(82, 33);
            this.buttonApagar.TabIndex = 2;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonFrenar
            // 
            this.buttonFrenar.Location = new System.Drawing.Point(59, 154);
            this.buttonFrenar.Name = "buttonFrenar";
            this.buttonFrenar.Size = new System.Drawing.Size(82, 30);
            this.buttonFrenar.TabIndex = 3;
            this.buttonFrenar.Text = "Fenar";
            this.buttonFrenar.UseVisualStyleBackColor = true;
            this.buttonFrenar.Click += new System.EventHandler(this.buttonFrenar_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.Location = new System.Drawing.Point(170, 154);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(82, 30);
            this.buttonAcelerar.TabIndex = 4;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = true;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(276, 95);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(39, 13);
            this.Estado.TabIndex = 5;
            this.Estado.Text = "estado";
            // 
            // Velocidad
            // 
            this.Velocidad.AutoSize = true;
            this.Velocidad.Location = new System.Drawing.Point(276, 146);
            this.Velocidad.Name = "Velocidad";
            this.Velocidad.Size = new System.Drawing.Size(62, 13);
            this.Velocidad.TabIndex = 6;
            this.Velocidad.Text = "aceleracion";
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(363, 29);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(329, 54);
            this.player.TabIndex = 7;
            // 
            // lstcanciones
            // 
            this.lstcanciones.FormattingEnabled = true;
            this.lstcanciones.Location = new System.Drawing.Point(368, 190);
            this.lstcanciones.Name = "lstcanciones";
            this.lstcanciones.Size = new System.Drawing.Size(324, 147);
            this.lstcanciones.TabIndex = 8;
            this.lstcanciones.SelectedIndexChanged += new System.EventHandler(this.lstcanciones_SelectedIndexChanged);
            // 
            // Boxagregar
            // 
            this.Boxagregar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Boxagregar.Location = new System.Drawing.Point(378, 128);
            this.Boxagregar.Name = "Boxagregar";
            this.Boxagregar.Size = new System.Drawing.Size(60, 31);
            this.Boxagregar.TabIndex = 9;
            this.Boxagregar.TabStop = false;
            this.Boxagregar.Click += new System.EventHandler(this.Boxagregar_Click);
            // 
            // Cambiosmas
            // 
            this.Cambiosmas.Location = new System.Drawing.Point(0, 0);
            this.Cambiosmas.Name = "Cambiosmas";
            this.Cambiosmas.Size = new System.Drawing.Size(75, 23);
            this.Cambiosmas.TabIndex = 13;
            // 
            // Cambiosmenos
            // 
            this.Cambiosmenos.Location = new System.Drawing.Point(170, 219);
            this.Cambiosmenos.Name = "Cambiosmenos";
            this.Cambiosmenos.Size = new System.Drawing.Size(81, 37);
            this.Cambiosmenos.TabIndex = 11;
            this.Cambiosmenos.Text = "disminuir marcha";
            this.Cambiosmenos.UseVisualStyleBackColor = true;
            this.Cambiosmenos.Click += new System.EventHandler(this.Cambiosmenos_Click);
            // 
            // Cambiomas
            // 
            this.Cambiomas.Location = new System.Drawing.Point(59, 219);
            this.Cambiomas.Name = "Cambiomas";
            this.Cambiomas.Size = new System.Drawing.Size(85, 38);
            this.Cambiomas.TabIndex = 14;
            this.Cambiomas.Text = "aumentar marcha";
            this.Cambiomas.UseVisualStyleBackColor = true;
            this.Cambiomas.Click += new System.EventHandler(this.Cambiomas_Click);
            // 
            // marcha
            // 
            this.marcha.AutoSize = true;
            this.marcha.Location = new System.Drawing.Point(276, 209);
            this.marcha.Name = "marcha";
            this.marcha.Size = new System.Drawing.Size(74, 13);
            this.marcha.TabIndex = 6;
            this.marcha.Text = "marcha actual";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cambiomas);
            this.Controls.Add(this.Cambiosmenos);
            this.Controls.Add(this.Cambiosmas);
            this.Controls.Add(this.Boxagregar);
            this.Controls.Add(this.lstcanciones);
            this.Controls.Add(this.player);
            this.Controls.Add(this.marcha);
            this.Controls.Add(this.Velocidad);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonFrenar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.btnEncendido);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boxagregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncendido;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonFrenar;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Label Velocidad;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.ListBox lstcanciones;
        private System.Windows.Forms.PictureBox Boxagregar;
        private System.Windows.Forms.Button Cambiosmas;
        private System.Windows.Forms.Button Cambiosmenos;
        private System.Windows.Forms.Button Cambiomas;
        private System.Windows.Forms.Label marcha;
    }
}

