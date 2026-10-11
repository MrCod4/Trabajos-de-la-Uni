namespace E4
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
            BtnCalcular = new Button();
            ListaDetalles = new ListBox();
            txtMonto = new TextBox();
            CmbMedioDePago = new ComboBox();
            LblPago = new Label();
            LblMonto = new Label();
            SuspendLayout();
            // 
            // BtnCalcular
            // 
            BtnCalcular.Location = new Point(170, 205);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(121, 23);
            BtnCalcular.TabIndex = 0;
            BtnCalcular.Text = "button1";
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // ListaDetalles
            // 
            ListaDetalles.FormattingEnabled = true;
            ListaDetalles.Location = new Point(328, 121);
            ListaDetalles.Name = "ListaDetalles";
            ListaDetalles.Size = new Size(315, 109);
            ListaDetalles.TabIndex = 1;
            ListaDetalles.SelectedIndexChanged += ListaDetalles_SelectedIndexChanged;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(170, 151);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(121, 23);
            txtMonto.TabIndex = 2;
            txtMonto.TextChanged += txtMonto_TextChanged;
            // 
            // CmbMedioDePago
            // 
            CmbMedioDePago.FormattingEnabled = true;
            CmbMedioDePago.Location = new Point(170, 107);
            CmbMedioDePago.Name = "CmbMedioDePago";
            CmbMedioDePago.Size = new Size(121, 23);
            CmbMedioDePago.TabIndex = 3;
            CmbMedioDePago.SelectedIndexChanged += CmbMedioDePago_SelectedIndexChanged;
            // 
            // LblPago
            // 
            LblPago.AutoSize = true;
            LblPago.Location = new Point(170, 89);
            LblPago.Name = "LblPago";
            LblPago.Size = new Size(88, 15);
            LblPago.TabIndex = 4;
            LblPago.Text = "Medio De pago";
            // 
            // LblMonto
            // 
            LblMonto.AutoSize = true;
            LblMonto.Location = new Point(170, 133);
            LblMonto.Name = "LblMonto";
            LblMonto.Size = new Size(43, 15);
            LblMonto.TabIndex = 5;
            LblMonto.Text = "Monto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblMonto);
            Controls.Add(LblPago);
            Controls.Add(CmbMedioDePago);
            Controls.Add(txtMonto);
            Controls.Add(ListaDetalles);
            Controls.Add(BtnCalcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCalcular;
        private ListBox ListaDetalles;
        private TextBox txtMonto;
        private ComboBox CmbMedioDePago;
        private Label LblPago;
        private Label LblMonto;
    }
}
