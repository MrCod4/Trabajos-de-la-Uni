namespace E3
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
            LblTitulo = new Label();
            LblNombrePersonaje = new Label();
            TxtNombrePersonaje = new TextBox();
            LblTipoPersonaje = new Label();
            CmbTipo = new ComboBox();
            LblNivelPersonaje = new Label();
            NumNivel = new NumericUpDown();
            BtnGuardar = new Button();
            BtnListar = new Button();
            LblLista = new Label();
            LstPersonajes = new ListBox();
            LblDetalle = new Label();
            ((System.ComponentModel.ISupportInitialize)NumNivel).BeginInit();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Location = new Point(30, 26);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(122, 15);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Gestion de personajes";
            // 
            // LblNombrePersonaje
            // 
            LblNombrePersonaje.AutoSize = true;
            LblNombrePersonaje.Location = new Point(30, 66);
            LblNombrePersonaje.Name = "LblNombrePersonaje";
            LblNombrePersonaje.Size = new Size(124, 15);
            LblNombrePersonaje.TabIndex = 1;
            LblNombrePersonaje.Text = "Nombre del personaje";
            // 
            // TxtNombrePersonaje
            // 
            TxtNombrePersonaje.Location = new Point(30, 84);
            TxtNombrePersonaje.Name = "TxtNombrePersonaje";
            TxtNombrePersonaje.Size = new Size(124, 23);
            TxtNombrePersonaje.TabIndex = 2;
            TxtNombrePersonaje.TextChanged += TxtNombrePersonaje_TextChanged;
            // 
            // LblTipoPersonaje
            // 
            LblTipoPersonaje.AutoSize = true;
            LblTipoPersonaje.Location = new Point(30, 131);
            LblTipoPersonaje.Name = "LblTipoPersonaje";
            LblTipoPersonaje.Size = new Size(101, 15);
            LblTipoPersonaje.TabIndex = 3;
            LblTipoPersonaje.Text = "Tipo de personaje";
            // 
            // CmbTipo
            // 
            CmbTipo.FormattingEnabled = true;
            CmbTipo.Location = new Point(30, 158);
            CmbTipo.Name = "CmbTipo";
            CmbTipo.Size = new Size(121, 23);
            CmbTipo.TabIndex = 4;
            CmbTipo.SelectedIndexChanged += CmbTipo_SelectedIndexChanged;
            // 
            // LblNivelPersonaje
            // 
            LblNivelPersonaje.AutoSize = true;
            LblNivelPersonaje.Location = new Point(30, 196);
            LblNivelPersonaje.Name = "LblNivelPersonaje";
            LblNivelPersonaje.Size = new Size(107, 15);
            LblNivelPersonaje.TabIndex = 5;
            LblNivelPersonaje.Text = "Nivel del personaje";
            // 
            // NumNivel
            // 
            NumNivel.Location = new Point(30, 214);
            NumNivel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumNivel.Name = "NumNivel";
            NumNivel.Size = new Size(120, 23);
            NumNivel.TabIndex = 6;
            NumNivel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumNivel.ValueChanged += NumNivel_ValueChanged;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(30, 243);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(120, 23);
            BtnGuardar.TabIndex = 7;
            BtnGuardar.Text = "Guardar Pj";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnListar
            // 
            BtnListar.Location = new Point(30, 272);
            BtnListar.Name = "BtnListar";
            BtnListar.Size = new Size(120, 23);
            BtnListar.TabIndex = 8;
            BtnListar.Text = "Listar Personajes";
            BtnListar.UseVisualStyleBackColor = true;
            BtnListar.Click += BtnListar_Click;
            // 
            // LblLista
            // 
            LblLista.AutoSize = true;
            LblLista.Location = new Point(30, 307);
            LblLista.Name = "LblLista";
            LblLista.Size = new Size(127, 15);
            LblLista.TabIndex = 9;
            LblLista.Text = "Personajes Registrados";
            // 
            // LstPersonajes
            // 
            LstPersonajes.FormattingEnabled = true;
            LstPersonajes.Location = new Point(30, 325);
            LstPersonajes.Name = "LstPersonajes";
            LstPersonajes.Size = new Size(224, 94);
            LstPersonajes.TabIndex = 10;
            LstPersonajes.SelectedIndexChanged += LstPersonajes_SelectedIndexChanged;
            // 
            // LblDetalle
            // 
            LblDetalle.AutoSize = true;
            LblDetalle.Location = new Point(30, 426);
            LblDetalle.Name = "LblDetalle";
            LblDetalle.Size = new Size(137, 15);
            LblDetalle.TabIndex = 11;
            LblDetalle.Text = "Selecciona un  personaje";
            LblDetalle.Click += LblDetalle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblDetalle);
            Controls.Add(LstPersonajes);
            Controls.Add(LblLista);
            Controls.Add(BtnListar);
            Controls.Add(BtnGuardar);
            Controls.Add(NumNivel);
            Controls.Add(LblNivelPersonaje);
            Controls.Add(CmbTipo);
            Controls.Add(LblTipoPersonaje);
            Controls.Add(TxtNombrePersonaje);
            Controls.Add(LblNombrePersonaje);
            Controls.Add(LblTitulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumNivel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private Label LblNombrePersonaje;
        private TextBox TxtNombrePersonaje;
        private Label LblTipoPersonaje;
        private ComboBox CmbTipo;
        private Label LblNivelPersonaje;
        private NumericUpDown NumNivel;
        private Button BtnGuardar;
        private Button BtnListar;
        private Label LblLista;
        private ListBox LstPersonajes;
        private Label LblDetalle;
    }
}
