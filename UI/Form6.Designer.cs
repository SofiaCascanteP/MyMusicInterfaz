namespace UI
{
    partial class Form6
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
            this.calificacionEstrellas = new System.Windows.Forms.ComboBox();
            this.eliminarCancion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreCancion
            // 
            this.nombreCancion.Location = new System.Drawing.Point(21, 25);
            this.nombreCancion.Name = "nombreCancion";
            this.nombreCancion.PlaceholderText = "Nombre";
            this.nombreCancion.Size = new System.Drawing.Size(321, 27);
            this.nombreCancion.TabIndex = 1;
            // 
            // calificacionEstrellas
            // 
            this.calificacionEstrellas.FormattingEnabled = true;
            this.calificacionEstrellas.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5"});
            this.calificacionEstrellas.Location = new System.Drawing.Point(21, 69);
            this.calificacionEstrellas.Name = "calificacionEstrellas";
            this.calificacionEstrellas.Size = new System.Drawing.Size(321, 28);
            this.calificacionEstrellas.TabIndex = 2;
            // 
            // eliminarCancion
            // 
            this.eliminarCancion.Location = new System.Drawing.Point(96, 117);
            this.eliminarCancion.Name = "eliminarCancion";
            this.eliminarCancion.Size = new System.Drawing.Size(159, 29);
            this.eliminarCancion.TabIndex = 3;
            this.eliminarCancion.Text = "Calificar canción";
            this.eliminarCancion.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 168);
            this.Controls.Add(this.eliminarCancion);
            this.Controls.Add(this.calificacionEstrellas);
            this.Controls.Add(this.nombreCancion);
            this.Name = "Form6";
            this.Text = "MyMusic - Calificar canción";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nombreCancion;
        private ComboBox calificacionEstrellas;
        private Button eliminarCancion;
    }
}