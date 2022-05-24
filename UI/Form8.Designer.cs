namespace UI
{
    partial class Form8
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
            this.nombreUsuarioAgregar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.recomendarCancion = new System.Windows.Forms.Button();
            this.nombreUsuarioRecomendar = new System.Windows.Forms.TextBox();
            this.nombreCancionRecomendar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listaRecomendaciones = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombreUsuarioAgregar
            // 
            this.nombreUsuarioAgregar.Location = new System.Drawing.Point(23, 70);
            this.nombreUsuarioAgregar.Name = "nombreUsuarioAgregar";
            this.nombreUsuarioAgregar.PlaceholderText = "Nombre de usuario";
            this.nombreUsuarioAgregar.Size = new System.Drawing.Size(275, 27);
            this.nombreUsuarioAgregar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar a la lista de amigos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // recomendarCancion
            // 
            this.recomendarCancion.Location = new System.Drawing.Point(324, 214);
            this.recomendarCancion.Name = "recomendarCancion";
            this.recomendarCancion.Size = new System.Drawing.Size(228, 29);
            this.recomendarCancion.TabIndex = 2;
            this.recomendarCancion.Text = "Recomendar canción";
            this.recomendarCancion.UseVisualStyleBackColor = true;
            // 
            // nombreUsuarioRecomendar
            // 
            this.nombreUsuarioRecomendar.Location = new System.Drawing.Point(23, 189);
            this.nombreUsuarioRecomendar.Name = "nombreUsuarioRecomendar";
            this.nombreUsuarioRecomendar.PlaceholderText = "Nombre de usuario";
            this.nombreUsuarioRecomendar.Size = new System.Drawing.Size(275, 27);
            this.nombreUsuarioRecomendar.TabIndex = 3;
            // 
            // nombreCancionRecomendar
            // 
            this.nombreCancionRecomendar.Location = new System.Drawing.Point(23, 240);
            this.nombreCancionRecomendar.Name = "nombreCancionRecomendar";
            this.nombreCancionRecomendar.PlaceholderText = "Nombre de la canción";
            this.nombreCancionRecomendar.Size = new System.Drawing.Size(275, 27);
            this.nombreCancionRecomendar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agregar amigos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Recomendar una canción";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listaRecomendaciones
            // 
            this.listaRecomendaciones.FormattingEnabled = true;
            this.listaRecomendaciones.ItemHeight = 20;
            this.listaRecomendaciones.Location = new System.Drawing.Point(23, 355);
            this.listaRecomendaciones.Name = "listaRecomendaciones";
            this.listaRecomendaciones.Size = new System.Drawing.Size(529, 104);
            this.listaRecomendaciones.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mis recomendaciones";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 490);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listaRecomendaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreCancionRecomendar);
            this.Controls.Add(this.nombreUsuarioRecomendar);
            this.Controls.Add(this.recomendarCancion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nombreUsuarioAgregar);
            this.Name = "Form8";
            this.Text = "MyMusic - Amigos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nombreUsuarioAgregar;
        private Button button1;
        private Button recomendarCancion;
        private TextBox nombreUsuarioRecomendar;
        private TextBox nombreCancionRecomendar;
        private Label label1;
        private Label label2;
        private ListBox listaRecomendaciones;
        private Label label3;
    }
}