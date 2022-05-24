namespace UI
{
    partial class Form5
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
            this.eliminarCancion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreCancion
            // 
            this.nombreCancion.Location = new System.Drawing.Point(23, 23);
            this.nombreCancion.Name = "nombreCancion";
            this.nombreCancion.PlaceholderText = "Nombre";
            this.nombreCancion.Size = new System.Drawing.Size(321, 27);
            this.nombreCancion.TabIndex = 0;
            // 
            // eliminarCancion
            // 
            this.eliminarCancion.Location = new System.Drawing.Point(100, 72);
            this.eliminarCancion.Name = "eliminarCancion";
            this.eliminarCancion.Size = new System.Drawing.Size(159, 29);
            this.eliminarCancion.TabIndex = 1;
            this.eliminarCancion.Text = "Eliminar canción";
            this.eliminarCancion.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 119);
            this.Controls.Add(this.eliminarCancion);
            this.Controls.Add(this.nombreCancion);
            this.Name = "Form5";
            this.Text = "MyMusic - Eliminar canción";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nombreCancion;
        private Button eliminarCancion;
    }
}