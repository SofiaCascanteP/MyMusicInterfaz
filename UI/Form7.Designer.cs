namespace UI
{
    partial class Form7
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
            this.agregarCancion = new System.Windows.Forms.Button();
            this.letraCancion = new System.Windows.Forms.TextBox();
            this.anioCancion = new System.Windows.Forms.TextBox();
            this.albumCancion = new System.Windows.Forms.TextBox();
            this.artistaCancion = new System.Windows.Forms.TextBox();
            this.generoCancion = new System.Windows.Forms.TextBox();
            this.nombreCancion = new System.Windows.Forms.TextBox();
            this.cargarAudioCancion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agregarCancion
            // 
            this.agregarCancion.Location = new System.Drawing.Point(110, 341);
            this.agregarCancion.Name = "agregarCancion";
            this.agregarCancion.Size = new System.Drawing.Size(148, 29);
            this.agregarCancion.TabIndex = 13;
            this.agregarCancion.Text = "Agregar canción";
            this.agregarCancion.UseVisualStyleBackColor = true;
            // 
            // letraCancion
            // 
            this.letraCancion.Location = new System.Drawing.Point(24, 245);
            this.letraCancion.Name = "letraCancion";
            this.letraCancion.PlaceholderText = "Letra";
            this.letraCancion.Size = new System.Drawing.Size(331, 27);
            this.letraCancion.TabIndex = 12;
            // 
            // anioCancion
            // 
            this.anioCancion.Location = new System.Drawing.Point(24, 201);
            this.anioCancion.Name = "anioCancion";
            this.anioCancion.PlaceholderText = "Año";
            this.anioCancion.Size = new System.Drawing.Size(331, 27);
            this.anioCancion.TabIndex = 11;
            // 
            // albumCancion
            // 
            this.albumCancion.Location = new System.Drawing.Point(24, 156);
            this.albumCancion.Name = "albumCancion";
            this.albumCancion.PlaceholderText = "Álbum";
            this.albumCancion.Size = new System.Drawing.Size(331, 27);
            this.albumCancion.TabIndex = 10;
            // 
            // artistaCancion
            // 
            this.artistaCancion.Location = new System.Drawing.Point(24, 112);
            this.artistaCancion.Name = "artistaCancion";
            this.artistaCancion.PlaceholderText = "Artista";
            this.artistaCancion.Size = new System.Drawing.Size(331, 27);
            this.artistaCancion.TabIndex = 9;
            // 
            // generoCancion
            // 
            this.generoCancion.Location = new System.Drawing.Point(24, 69);
            this.generoCancion.Name = "generoCancion";
            this.generoCancion.PlaceholderText = "Genero";
            this.generoCancion.Size = new System.Drawing.Size(331, 27);
            this.generoCancion.TabIndex = 8;
            // 
            // nombreCancion
            // 
            this.nombreCancion.Location = new System.Drawing.Point(24, 26);
            this.nombreCancion.Name = "nombreCancion";
            this.nombreCancion.PlaceholderText = "Nombre";
            this.nombreCancion.Size = new System.Drawing.Size(331, 27);
            this.nombreCancion.TabIndex = 7;
            // 
            // cargarAudioCancion
            // 
            this.cargarAudioCancion.Location = new System.Drawing.Point(24, 289);
            this.cargarAudioCancion.Name = "cargarAudioCancion";
            this.cargarAudioCancion.Size = new System.Drawing.Size(331, 29);
            this.cargarAudioCancion.TabIndex = 14;
            this.cargarAudioCancion.Text = "Cargar audio de la canción";
            this.cargarAudioCancion.UseVisualStyleBackColor = true;
            this.cargarAudioCancion.Click += new System.EventHandler(this.cargarAudioCancion_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 399);
            this.Controls.Add(this.cargarAudioCancion);
            this.Controls.Add(this.agregarCancion);
            this.Controls.Add(this.letraCancion);
            this.Controls.Add(this.anioCancion);
            this.Controls.Add(this.albumCancion);
            this.Controls.Add(this.artistaCancion);
            this.Controls.Add(this.generoCancion);
            this.Controls.Add(this.nombreCancion);
            this.Name = "Form7";
            this.Text = "MyMusic - Agregar canción";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button agregarCancion;
        private TextBox letraCancion;
        private TextBox anioCancion;
        private TextBox albumCancion;
        private TextBox artistaCancion;
        private TextBox generoCancion;
        private TextBox nombreCancion;
        private Button cargarAudioCancion;
    }
}