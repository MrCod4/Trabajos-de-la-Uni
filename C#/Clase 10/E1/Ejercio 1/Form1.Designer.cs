namespace Ejercio_1
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
            TxtNumero1 = new TextBox();
            Txtnumero2 = new TextBox();
            TxtResultado = new Label();
            Dividir = new Button();
            SuspendLayout();
            // 
            // TxtNumero1
            // 
            TxtNumero1.Location = new Point(195, 58);
            TxtNumero1.Name = "TxtNumero1";
            TxtNumero1.Size = new Size(100, 23);
            TxtNumero1.TabIndex = 0;
            TxtNumero1.TextChanged += TxtNumero1_TextChanged;
            // 
            // Txtnumero2
            // 
            Txtnumero2.Location = new Point(462, 58);
            Txtnumero2.Name = "Txtnumero2";
            Txtnumero2.Size = new Size(100, 23);
            Txtnumero2.TabIndex = 1;
            Txtnumero2.TextChanged += Txtnumero2_TextChanged;
            // 
            // TxtResultado
            // 
            TxtResultado.AutoSize = true;
            TxtResultado.Location = new Point(330, 174);
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(103, 15);
            TxtResultado.TabIndex = 2;
            TxtResultado.Text = "Mostrar Resultado";
            TxtResultado.Click += TextoDividir_Click;
            // 
            // Dividir
            // 
            Dividir.Location = new Point(346, 134);
            Dividir.Name = "Dividir";
            Dividir.Size = new Size(75, 23);
            Dividir.TabIndex = 3;
            Dividir.Text = "BtnDividir";
            Dividir.UseVisualStyleBackColor = true;
            Dividir.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Dividir);
            Controls.Add(TxtResultado);
            Controls.Add(Txtnumero2);
            Controls.Add(TxtNumero1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNumero1;
        private TextBox Txtnumero2;
        private Label TxtResultado;
        private Button Dividir;
    }
}
