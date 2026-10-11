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
            txtAnioNacimiento = new TextBox();
            BtnLimpiar = new Button();
            BtnCalcular = new Button();
            LblCalculo = new Label();
            BtnCrear = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(221, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtAnioNacimiento
            // 
            txtAnioNacimiento.Location = new Point(450, 77);
            txtAnioNacimiento.Name = "txtAnioNacimiento";
            txtAnioNacimiento.Size = new Size(100, 23);
            txtAnioNacimiento.TabIndex = 1;
            txtAnioNacimiento.TextChanged += txtAnioNacimiento_TextChanged;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new Point(349, 206);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(75, 23);
            BtnLimpiar.TabIndex = 2;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnCalcular
            // 
            BtnCalcular.Location = new Point(349, 164);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(75, 23);
            BtnCalcular.TabIndex = 3;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // LblCalculo
            // 
            LblCalculo.AutoSize = true;
            LblCalculo.Location = new Point(349, 127);
            LblCalculo.Name = "LblCalculo";
            LblCalculo.Size = new Size(0, 15);
            LblCalculo.TabIndex = 4;
            LblCalculo.Click += LblCalculo_Click;
            // 
            // BtnCrear
            // 
            BtnCrear.Location = new Point(349, 252);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(75, 23);
            BtnCrear.TabIndex = 5;
            BtnCrear.Text = "Crear";
            BtnCrear.UseVisualStyleBackColor = true;
            BtnCrear.Click += BtnCrear_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCrear);
            Controls.Add(LblCalculo);
            Controls.Add(BtnCalcular);
            Controls.Add(BtnLimpiar);
            Controls.Add(txtAnioNacimiento);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtAnioNacimiento;
        private Button BtnLimpiar;
        private Button BtnCalcular;
        private Label LblCalculo;
        private Button BtnCrear;
    }
}
