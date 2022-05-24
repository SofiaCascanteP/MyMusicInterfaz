namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreUsuario = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.iniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(207, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login";
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.Location = new System.Drawing.Point(132, 104);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.PlaceholderText = "Nombre de usuario";
            this.nombreUsuario.Size = new System.Drawing.Size(275, 27);
            this.nombreUsuario.TabIndex = 1;
            // 
            // contrasena
            // 
            this.contrasena.Location = new System.Drawing.Point(132, 154);
            this.contrasena.Name = "contrasena";
            this.contrasena.PlaceholderText = "Contraseña";
            this.contrasena.Size = new System.Drawing.Size(275, 27);
            this.contrasena.TabIndex = 2;
            // 
            // iniciarSesion
            // 
            this.iniciarSesion.Location = new System.Drawing.Point(195, 220);
            this.iniciarSesion.Name = "iniciarSesion";
            this.iniciarSesion.Size = new System.Drawing.Size(142, 29);
            this.iniciarSesion.TabIndex = 3;
            this.iniciarSesion.Text = "Iniciar sesión";
            this.iniciarSesion.UseVisualStyleBackColor = true;
            this.iniciarSesion.Click += new System.EventHandler(this.iniciarSesion_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(554, 288);
            this.Controls.Add(this.iniciarSesion);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.nombreUsuario);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "MyMusic - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nombreUsuario;
        private TextBox contrasena;
        private Button iniciarSesion;
    }
}