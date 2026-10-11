namespace E1
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
            txtAnioDeNacimiento = new TextBox();
            BtnCalcular = new Button();
            BtnLimpiar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(238, 141);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtAnioDeNacimiento
            // 
            txtAnioDeNacimiento.Location = new Point(439, 141);
            txtAnioDeNacimiento.Name = "txtAnioDeNacimiento";
            txtAnioDeNacimiento.Size = new Size(100, 23);
            txtAnioDeNacimiento.TabIndex = 1;
            txtAnioDeNacimiento.TextChanged += txtAnioDeNacimiento_TextChanged;
            // 
            // BtnCalcular
            // 
            BtnCalcular.Location = new Point(352, 207);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(75, 23);
            BtnCalcular.TabIndex = 2;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new Point(352, 236);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(75, 23);
            BtnLimpiar.TabIndex = 3;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnCalcular);
            Controls.Add(txtAnioDeNacimiento);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtAnioDeNacimiento;
        private Button BtnCalcular;
        private Button BtnLimpiar;
    }
}
