namespace UI
{
    partial class Form4
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
            this.nombreCancion = new System.Windows.Forms.TextBox();
            this.generoCancion = new System.Windows.Forms.TextBox();
            this.artistaCancion = new System.Windows.Forms.TextBox();
            this.albumCancion = new System.Windows.Forms.TextBox();
            this.anioCancion = new System.Windows.Forms.TextBox();
            this.letraCancion = new System.Windows.Forms.TextBox();
            this.modificarCancion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreCancion
            // 
            this.nombreCancion.Location = new System.Drawing.Point(22, 24);
            this.nombreCancion.Name = "nombreCancion";
            this.nombreCancion.PlaceholderText = "Nombre";
            this.nombreCancion.Size = new System.Drawing.Size(331, 27);
            this.nombreCancion.TabIndex = 0;
            // 
            // generoCancion
            // 
            this.generoCancion.Location = new System.Drawing.Point(22, 67);
            this.generoCancion.Name = "generoCancion";
            this.generoCancion.PlaceholderText = "Genero";
            this.generoCancion.Size = new System.Drawing.Size(331, 27);
            this.generoCancion.TabIndex = 1;
            this.generoCancion.TextChanged += new System.EventHandler(this.generoCancion_TextChanged);
            // 
            // artistaCancion
            // 
            this.artistaCancion.Location = new System.Drawing.Point(22, 110);
            this.artistaCancion.Name = "artistaCancion";
            this.artistaCancion.PlaceholderText = "Artista";
            this.artistaCancion.Size = new System.Drawing.Size(331, 27);
            this.artistaCancion.TabIndex = 2;
            // 
            // albumCancion
            // 
            this.albumCancion.Location = new System.Drawing.Point(22, 154);
            this.albumCancion.Name = "albumCancion";
            this.albumCancion.PlaceholderText = "Álbum";
            this.albumCancion.Size = new System.Drawing.Size(331, 27);
            this.albumCancion.TabIndex = 3;
            // 
            // anioCancion
            // 
            this.anioCancion.Location = new System.Drawing.Point(22, 199);
            this.anioCancion.Name = "anioCancion";
            this.anioCancion.PlaceholderText = "Año";
            this.anioCancion.Size = new System.Drawing.Size(331, 27);
            this.anioCancion.TabIndex = 4;
            // 
            // letraCancion
            // 
            this.letraCancion.Location = new System.Drawing.Point(22, 243);
            this.letraCancion.Name = "letraCancion";
            this.letraCancion.PlaceholderText = "Letra";
            this.letraCancion.Size = new System.Drawing.Size(331, 27);
            this.letraCancion.TabIndex = 5;
            // 
            // modificarCancion
            // 
            this.modificarCancion.Location = new System.Drawing.Point(107, 296);
            this.modificarCancion.Name = "modificarCancion";
            this.modificarCancion.Size = new System.Drawing.Size(148, 29);
            this.modificarCancion.TabIndex = 6;
            this.modificarCancion.Text = "Modificar canción";
            this.modificarCancion.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 348);
            this.Controls.Add(this.modificarCancion);
            this.Controls.Add(this.letraCancion);
            this.Controls.Add(this.anioCancion);
            this.Controls.Add(this.albumCancion);
            this.Controls.Add(this.artistaCancion);
            this.Controls.Add(this.generoCancion);
            this.Controls.Add(this.nombreCancion);
            this.Name = "Form4";
            this.Text = "MyMusic - Modificar canción";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nombreCancion;
        private TextBox generoCancion;
        private TextBox artistaCancion;
        private TextBox albumCancion;
        private TextBox anioCancion;
        private TextBox letraCancion;
        private Button modificarCancion;
    }
}