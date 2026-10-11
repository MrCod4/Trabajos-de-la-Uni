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
            rxrBuscar = new TextBox();
            LblBuscar = new Label();
            ListaProductos = new ListBox();
            SuspendLayout();
            // 
            // rxrBuscar
            // 
            rxrBuscar.Location = new Point(331, 77);
            rxrBuscar.Name = "rxrBuscar";
            rxrBuscar.Size = new Size(100, 23);
            rxrBuscar.TabIndex = 0;
            rxrBuscar.TextChanged += rxrBuscar_TextChanged;
            // 
            // LblBuscar
            // 
            LblBuscar.AutoSize = true;
            LblBuscar.Location = new Point(331, 59);
            LblBuscar.Name = "LblBuscar";
            LblBuscar.Size = new Size(42, 15);
            LblBuscar.TabIndex = 1;
            LblBuscar.Text = "Buscar";
            LblBuscar.Click += LblBuscar_Click;
            // 
            // ListaProductos
            // 
            ListaProductos.FormattingEnabled = true;
            ListaProductos.Location = new Point(331, 106);
            ListaProductos.Name = "ListaProductos";
            ListaProductos.Size = new Size(120, 94);
            ListaProductos.TabIndex = 2;
            ListaProductos.SelectedIndexChanged += ListaProductos_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListaProductos);
            Controls.Add(LblBuscar);
            Controls.Add(rxrBuscar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox rxrBuscar;
        private Label LblBuscar;
        private ListBox ListaProductos;
    }
}
