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
            BtnAtacar = new Button();
            LblResultado = new Label();
            TipoSeleccionado = new ComboBox();
            TxtNombre = new TextBox();
            SuspendLayout();
            // 
            // BtnAtacar
            // 
            BtnAtacar.Location = new Point(204, 160);
            BtnAtacar.Name = "BtnAtacar";
            BtnAtacar.Size = new Size(75, 23);
            BtnAtacar.TabIndex = 0;
            BtnAtacar.Text = "Atacar";
            BtnAtacar.UseVisualStyleBackColor = true;
            BtnAtacar.Click += BtnAtacar_Click;
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.Location = new Point(479, 160);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(0, 15);
            LblResultado.TabIndex = 1;
            LblResultado.Click += LblResultado_Click;
            // 
            // TipoSeleccionado
            // 
            TipoSeleccionado.FormattingEnabled = true;
            TipoSeleccionado.Location = new Point(308, 157);
            TipoSeleccionado.Name = "TipoSeleccionado";
            TipoSeleccionado.Size = new Size(121, 23);
            TipoSeleccionado.TabIndex = 2;
            TipoSeleccionado.SelectedIndexChanged += TipoSeleccionado_SelectedIndexChanged;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(191, 119);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(100, 23);
            TxtNombre.TabIndex = 3;
            TxtNombre.TextChanged += TxtNombre_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtNombre);
            Controls.Add(TipoSeleccionado);
            Controls.Add(LblResultado);
            Controls.Add(BtnAtacar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAtacar;
        private Label LblResultado;
        private ComboBox TipoSeleccionado;
        private TextBox TxtNombre;
    }
}
