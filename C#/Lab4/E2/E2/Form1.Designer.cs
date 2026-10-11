namespace E2
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
            txtNombre = new TextBox();
            txtRut = new TextBox();
            txtEdad = new TextBox();
            ListaAccion = new ListBox();
            BtnAñadir = new Button();
            BtnEliminar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(42, 151);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtRut
            // 
            txtRut.Location = new Point(42, 88);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(100, 23);
            txtRut.TabIndex = 1;
            txtRut.TextChanged += txtRut_TextChanged;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(42, 224);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 2;
            txtEdad.TextChanged += txtEdad_TextChanged;
            // 
            // ListaAccion
            // 
            ListaAccion.FormattingEnabled = true;
            ListaAccion.Location = new Point(202, 88);
            ListaAccion.Name = "ListaAccion";
            ListaAccion.Size = new Size(120, 94);
            ListaAccion.TabIndex = 3;
            ListaAccion.SelectedIndexChanged += ListaAccion_SelectedIndexChanged;
            // 
            // BtnAñadir
            // 
            BtnAñadir.Location = new Point(202, 199);
            BtnAñadir.Name = "BtnAñadir";
            BtnAñadir.Size = new Size(120, 23);
            BtnAñadir.TabIndex = 4;
            BtnAñadir.Text = "Añadir alumno";
            BtnAñadir.UseVisualStyleBackColor = true;
            BtnAñadir.Click += BtnAñadir_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(202, 228);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(120, 23);
            BtnEliminar.TabIndex = 5;
            BtnEliminar.Text = "Eliminar alumno";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnAñadir);
            Controls.Add(ListaAccion);
            Controls.Add(txtEdad);
            Controls.Add(txtRut);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtRut;
        private TextBox txtEdad;
        private ListBox ListaAccion;
        private Button BtnAñadir;
        private Button BtnEliminar;
    }
}
