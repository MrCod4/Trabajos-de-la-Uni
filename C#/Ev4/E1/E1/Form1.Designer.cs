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
            LblCalculadora = new Label();
            Btn1 = new Button();
            Btn4 = new Button();
            Btn2 = new Button();
            Btn5 = new Button();
            Btn3 = new Button();
            Btn6 = new Button();
            Btn8 = new Button();
            Btn7 = new Button();
            Btn9 = new Button();
            Btn0 = new Button();
            BtnIgual = new Button();
            BtnC = new Button();
            BtnMult = new Button();
            BtnSuma = new Button();
            BtnResta = new Button();
            BtnCE = new Button();
            BtnDividir = new Button();
            TxtOperaciones = new TextBox();
            ListaHistorial = new ListBox();
            BtnBorrarHist = new Button();
            BtnDecimal = new Button();
            SuspendLayout();
            // 
            // LblCalculadora
            // 
            LblCalculadora.AutoSize = true;
            LblCalculadora.Location = new Point(27, 27);
            LblCalculadora.Name = "LblCalculadora";
            LblCalculadora.Size = new Size(128, 15);
            LblCalculadora.TabIndex = 0;
            LblCalculadora.Text = "Calculadora interactiva";
            // 
            // Btn1
            // 
            Btn1.Location = new Point(27, 126);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(34, 23);
            Btn1.TabIndex = 1;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Btn1_Click;
            // 
            // Btn4
            // 
            Btn4.Location = new Point(27, 155);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(34, 23);
            Btn4.TabIndex = 2;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = true;
            Btn4.Click += Btn4_Click;
            // 
            // Btn2
            // 
            Btn2.Location = new Point(67, 126);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(34, 23);
            Btn2.TabIndex = 3;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += Btn2_Click;
            // 
            // Btn5
            // 
            Btn5.Location = new Point(67, 155);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(34, 23);
            Btn5.TabIndex = 4;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = true;
            Btn5.Click += Btn5_Click;
            // 
            // Btn3
            // 
            Btn3.Location = new Point(107, 126);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(34, 23);
            Btn3.TabIndex = 5;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += Btn3_Click;
            // 
            // Btn6
            // 
            Btn6.Location = new Point(107, 155);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(34, 23);
            Btn6.TabIndex = 6;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = true;
            Btn6.Click += Btn6_Click;
            // 
            // Btn8
            // 
            Btn8.Location = new Point(67, 185);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(34, 20);
            Btn8.TabIndex = 7;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = true;
            Btn8.Click += Btn8_Click;
            // 
            // Btn7
            // 
            Btn7.Location = new Point(27, 184);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(34, 21);
            Btn7.TabIndex = 8;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = true;
            Btn7.Click += Btn7_Click;
            // 
            // Btn9
            // 
            Btn9.Location = new Point(107, 184);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(33, 21);
            Btn9.TabIndex = 9;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = true;
            Btn9.Click += Btn9_Click;
            // 
            // Btn0
            // 
            Btn0.Location = new Point(67, 211);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(34, 20);
            Btn0.TabIndex = 10;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = true;
            Btn0.Click += Btn0_Click;
            // 
            // BtnIgual
            // 
            BtnIgual.Location = new Point(107, 211);
            BtnIgual.Name = "BtnIgual";
            BtnIgual.Size = new Size(34, 20);
            BtnIgual.TabIndex = 11;
            BtnIgual.Text = "=";
            BtnIgual.UseVisualStyleBackColor = true;
            BtnIgual.Click += BtnIgual_Click;
            // 
            // BtnC
            // 
            BtnC.Location = new Point(145, 211);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(34, 20);
            BtnC.TabIndex = 12;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = true;
            BtnC.Click += BtnC_Click;
            // 
            // BtnMult
            // 
            BtnMult.Location = new Point(147, 126);
            BtnMult.Name = "BtnMult";
            BtnMult.Size = new Size(32, 23);
            BtnMult.TabIndex = 13;
            BtnMult.Text = "*";
            BtnMult.UseVisualStyleBackColor = true;
            BtnMult.Click += BtnMult_Click;
            // 
            // BtnSuma
            // 
            BtnSuma.Location = new Point(147, 154);
            BtnSuma.Name = "BtnSuma";
            BtnSuma.Size = new Size(32, 24);
            BtnSuma.TabIndex = 14;
            BtnSuma.Text = "+";
            BtnSuma.UseVisualStyleBackColor = true;
            BtnSuma.Click += BtnSuma_Click;
            // 
            // BtnResta
            // 
            BtnResta.Location = new Point(148, 185);
            BtnResta.Name = "BtnResta";
            BtnResta.Size = new Size(31, 20);
            BtnResta.TabIndex = 15;
            BtnResta.Text = "-";
            BtnResta.UseVisualStyleBackColor = true;
            BtnResta.Click += BtnResta_Click;
            // 
            // BtnCE
            // 
            BtnCE.Location = new Point(185, 211);
            BtnCE.Name = "BtnCE";
            BtnCE.Size = new Size(31, 20);
            BtnCE.TabIndex = 16;
            BtnCE.Text = "CE";
            BtnCE.UseVisualStyleBackColor = true;
            BtnCE.Click += BtnCE_Click;
            // 
            // BtnDividir
            // 
            BtnDividir.Location = new Point(185, 126);
            BtnDividir.Name = "BtnDividir";
            BtnDividir.Size = new Size(32, 23);
            BtnDividir.TabIndex = 17;
            BtnDividir.Text = "/";
            BtnDividir.UseVisualStyleBackColor = true;
            BtnDividir.Click += BtnDividir_Click;
            // 
            // TxtOperaciones
            // 
            TxtOperaciones.Location = new Point(27, 97);
            TxtOperaciones.Name = "TxtOperaciones";
            TxtOperaciones.Size = new Size(182, 23);
            TxtOperaciones.TabIndex = 18;
            TxtOperaciones.TextChanged += TxtOperaciones_TextChanged;
            // 
            // ListaHistorial
            // 
            ListaHistorial.FormattingEnabled = true;
            ListaHistorial.Location = new Point(246, 111);
            ListaHistorial.Name = "ListaHistorial";
            ListaHistorial.Size = new Size(190, 94);
            ListaHistorial.TabIndex = 19;
            ListaHistorial.SelectedIndexChanged += ListaHistorial_SelectedIndexChanged;
            // 
            // BtnBorrarHist
            // 
            BtnBorrarHist.Location = new Point(246, 211);
            BtnBorrarHist.Name = "BtnBorrarHist";
            BtnBorrarHist.Size = new Size(190, 23);
            BtnBorrarHist.TabIndex = 20;
            BtnBorrarHist.Text = "Borrar Historial";
            BtnBorrarHist.UseVisualStyleBackColor = true;
            BtnBorrarHist.Click += BtnBorrarHist_Click;
            // 
            // BtnDecimal
            // 
            BtnDecimal.Location = new Point(27, 211);
            BtnDecimal.Name = "BtnDecimal";
            BtnDecimal.Size = new Size(34, 23);
            BtnDecimal.TabIndex = 21;
            BtnDecimal.Text = ".";
            BtnDecimal.UseVisualStyleBackColor = true;
            BtnDecimal.Click += BtnDecimal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnDecimal);
            Controls.Add(BtnBorrarHist);
            Controls.Add(ListaHistorial);
            Controls.Add(TxtOperaciones);
            Controls.Add(BtnDividir);
            Controls.Add(BtnCE);
            Controls.Add(BtnResta);
            Controls.Add(BtnSuma);
            Controls.Add(BtnMult);
            Controls.Add(BtnC);
            Controls.Add(BtnIgual);
            Controls.Add(Btn0);
            Controls.Add(Btn9);
            Controls.Add(Btn7);
            Controls.Add(Btn8);
            Controls.Add(Btn6);
            Controls.Add(Btn3);
            Controls.Add(Btn5);
            Controls.Add(Btn2);
            Controls.Add(Btn4);
            Controls.Add(Btn1);
            Controls.Add(LblCalculadora);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblCalculadora;
        private Button Btn1;
        private Button Btn4;
        private Button Btn2;
        private Button Btn5;
        private Button Btn3;
        private Button Btn6;
        private Button Btn8;
        private Button Btn7;
        private Button Btn9;
        private Button Btn0;
        private Button BtnIgual;
        private Button BtnC;
        private Button BtnMult;
        private Button BtnSuma;
        private Button BtnResta;
        private Button BtnCE;
        private Button BtnDividir;
        private TextBox TxtOperaciones;
        private ListBox ListaHistorial;
        private Button BtnBorrarHist;
        private Button BtnDecimal;
    }
}
