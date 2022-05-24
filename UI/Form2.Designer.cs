namespace UI
{
    partial class Form2
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
            this.listaCanciones = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contenidoBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.elementoBuscar = new System.Windows.Forms.TextBox();
            this.buscarPorNombre = new System.Windows.Forms.Button();
            this.buscarPorArtista = new System.Windows.Forms.Button();
            this.buscarPorAlbum = new System.Windows.Forms.Button();
            this.buscarPorLetra = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.eliminarCancion = new System.Windows.Forms.Button();
            this.modificarCancion = new System.Windows.Forms.Button();
            this.calificarCancion = new System.Windows.Forms.Button();
            this.ordenarQuickSort = new System.Windows.Forms.Button();
            this.ordenarInsertionSort = new System.Windows.Forms.Button();
            this.ordenarBubbleSort = new System.Windows.Forms.Button();
            this.agregarCancion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.amigos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaCanciones
            // 
            this.listaCanciones.FormattingEnabled = true;
            this.listaCanciones.ItemHeight = 20;
            this.listaCanciones.Location = new System.Drawing.Point(25, 142);
            this.listaCanciones.Name = "listaCanciones";
            this.listaCanciones.Size = new System.Drawing.Size(739, 284);
            this.listaCanciones.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(389, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 0;
            // 
            // contenidoBuscar
            // 
            this.contenidoBuscar.Location = new System.Drawing.Point(12, 24);
            this.contenidoBuscar.Name = "contenidoBuscar";
            this.contenidoBuscar.PlaceholderText = "Elemento a buscar";
            this.contenidoBuscar.Size = new System.Drawing.Size(275, 27);
            this.contenidoBuscar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // elementoBuscar
            // 
            this.elementoBuscar.Location = new System.Drawing.Point(29, 25);
            this.elementoBuscar.Name = "elementoBuscar";
            this.elementoBuscar.PlaceholderText = "Elemento a buscar";
            this.elementoBuscar.Size = new System.Drawing.Size(240, 27);
            this.elementoBuscar.TabIndex = 0;
            // 
            // buscarPorNombre
            // 
            this.buscarPorNombre.Location = new System.Drawing.Point(294, 24);
            this.buscarPorNombre.Name = "buscarPorNombre";
            this.buscarPorNombre.Size = new System.Drawing.Size(163, 29);
            this.buscarPorNombre.TabIndex = 1;
            this.buscarPorNombre.Text = "Buscar por nombre";
            this.buscarPorNombre.UseVisualStyleBackColor = true;
            this.buscarPorNombre.Click += new System.EventHandler(this.buscarPorNombre_Click);
            // 
            // buscarPorArtista
            // 
            this.buscarPorArtista.Location = new System.Drawing.Point(294, 69);
            this.buscarPorArtista.Name = "buscarPorArtista";
            this.buscarPorArtista.Size = new System.Drawing.Size(163, 29);
            this.buscarPorArtista.TabIndex = 2;
            this.buscarPorArtista.Text = "Buscar por artista";
            this.buscarPorArtista.UseVisualStyleBackColor = true;
            this.buscarPorArtista.Click += new System.EventHandler(this.buscarPorArtista_Click);
            // 
            // buscarPorAlbum
            // 
            this.buscarPorAlbum.Location = new System.Drawing.Point(472, 24);
            this.buscarPorAlbum.Name = "buscarPorAlbum";
            this.buscarPorAlbum.Size = new System.Drawing.Size(163, 29);
            this.buscarPorAlbum.TabIndex = 3;
            this.buscarPorAlbum.Text = "Buscar por album";
            this.buscarPorAlbum.UseVisualStyleBackColor = true;
            this.buscarPorAlbum.Click += new System.EventHandler(this.button3_Click);
            // 
            // buscarPorLetra
            // 
            this.buscarPorLetra.Location = new System.Drawing.Point(472, 69);
            this.buscarPorLetra.Name = "buscarPorLetra";
            this.buscarPorLetra.Size = new System.Drawing.Size(163, 29);
            this.buscarPorLetra.TabIndex = 4;
            this.buscarPorLetra.Text = "Buscar por letra";
            this.buscarPorLetra.UseVisualStyleBackColor = true;
            this.buscarPorLetra.Click += new System.EventHandler(this.buscarPorLetra_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 20;
            this.lista.Location = new System.Drawing.Point(29, 136);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(606, 244);
            this.lista.TabIndex = 5;
            // 
            // eliminarCancion
            // 
            this.eliminarCancion.Location = new System.Drawing.Point(210, 453);
            this.eliminarCancion.Name = "eliminarCancion";
            this.eliminarCancion.Size = new System.Drawing.Size(155, 29);
            this.eliminarCancion.TabIndex = 6;
            this.eliminarCancion.Text = "Eliminar canción";
            this.eliminarCancion.UseVisualStyleBackColor = true;
            this.eliminarCancion.Click += new System.EventHandler(this.button2_Click);
            // 
            // modificarCancion
            // 
            this.modificarCancion.Location = new System.Drawing.Point(210, 405);
            this.modificarCancion.Name = "modificarCancion";
            this.modificarCancion.Size = new System.Drawing.Size(155, 29);
            this.modificarCancion.TabIndex = 7;
            this.modificarCancion.Text = "Modificar canción";
            this.modificarCancion.UseVisualStyleBackColor = true;
            this.modificarCancion.Click += new System.EventHandler(this.modificarCancion_Click);
            // 
            // calificarCancion
            // 
            this.calificarCancion.Location = new System.Drawing.Point(29, 454);
            this.calificarCancion.Name = "calificarCancion";
            this.calificarCancion.Size = new System.Drawing.Size(155, 29);
            this.calificarCancion.TabIndex = 8;
            this.calificarCancion.Text = "Calificar canción";
            this.calificarCancion.UseVisualStyleBackColor = true;
            this.calificarCancion.Click += new System.EventHandler(this.calificarCancion_Click);
            // 
            // ordenarQuickSort
            // 
            this.ordenarQuickSort.Location = new System.Drawing.Point(692, 392);
            this.ordenarQuickSort.Name = "ordenarQuickSort";
            this.ordenarQuickSort.Size = new System.Drawing.Size(200, 29);
            this.ordenarQuickSort.TabIndex = 9;
            this.ordenarQuickSort.Text = "Ordenar por Quick Sort";
            this.ordenarQuickSort.UseVisualStyleBackColor = true;
            // 
            // ordenarInsertionSort
            // 
            this.ordenarInsertionSort.Location = new System.Drawing.Point(692, 427);
            this.ordenarInsertionSort.Name = "ordenarInsertionSort";
            this.ordenarInsertionSort.Size = new System.Drawing.Size(200, 29);
            this.ordenarInsertionSort.TabIndex = 10;
            this.ordenarInsertionSort.Text = "Ordenar por Insertion Sort";
            this.ordenarInsertionSort.UseVisualStyleBackColor = true;
            // 
            // ordenarBubbleSort
            // 
            this.ordenarBubbleSort.Location = new System.Drawing.Point(692, 462);
            this.ordenarBubbleSort.Name = "ordenarBubbleSort";
            this.ordenarBubbleSort.Size = new System.Drawing.Size(200, 29);
            this.ordenarBubbleSort.TabIndex = 11;
            this.ordenarBubbleSort.Text = "Ordenar por Bubble Sort";
            this.ordenarBubbleSort.UseVisualStyleBackColor = true;
            // 
            // agregarCancion
            // 
            this.agregarCancion.Location = new System.Drawing.Point(29, 406);
            this.agregarCancion.Name = "agregarCancion";
            this.agregarCancion.Size = new System.Drawing.Size(155, 29);
            this.agregarCancion.TabIndex = 12;
            this.agregarCancion.Text = "Agregar canción";
            this.agregarCancion.UseVisualStyleBackColor = true;
            this.agregarCancion.Click += new System.EventHandler(this.agregarCancion_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(709, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Reproducir canción";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // amigos
            // 
            this.amigos.Location = new System.Drawing.Point(709, 43);
            this.amigos.Name = "amigos";
            this.amigos.Size = new System.Drawing.Size(155, 29);
            this.amigos.TabIndex = 14;
            this.amigos.Text = "Amigos";
            this.amigos.UseVisualStyleBackColor = true;
            this.amigos.Click += new System.EventHandler(this.amigos_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(917, 513);
            this.Controls.Add(this.amigos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.agregarCancion);
            this.Controls.Add(this.ordenarBubbleSort);
            this.Controls.Add(this.ordenarInsertionSort);
            this.Controls.Add(this.ordenarQuickSort);
            this.Controls.Add(this.calificarCancion);
            this.Controls.Add(this.modificarCancion);
            this.Controls.Add(this.eliminarCancion);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.buscarPorLetra);
            this.Controls.Add(this.buscarPorAlbum);
            this.Controls.Add(this.buscarPorArtista);
            this.Controls.Add(this.buscarPorNombre);
            this.Controls.Add(this.elementoBuscar);
            this.Name = "Form2";
            this.Text = "MyMusic - Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listaCanciones;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox contenidoBuscar;
        private Button button1;
        private TextBox elementoBuscar;
        private Button buscarPorNombre;
        private Button buscarPorArtista;
        private Button buscarPorAlbum;
        private Button buscarPorLetra;
        private ListBox lista;
        private Button eliminarCancion;
        private Button modificarCancion;
        private Button calificarCancion;
        private Button ordenarQuickSort;
        private Button ordenarInsertionSort;
        private Button ordenarBubbleSort;
        private Button agregarCancion;
        private Button button2;
        private Button amigos;
    }
}