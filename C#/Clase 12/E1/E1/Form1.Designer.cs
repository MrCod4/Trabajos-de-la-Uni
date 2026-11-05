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
            BtnMostrar = new Button();
            LblInfo = new Label();
            SuspendLayout();
            // 
            // BtnMostrar
            // 
            BtnMostrar.Location = new Point(281, 117);
            BtnMostrar.Name = "BtnMostrar";
            BtnMostrar.Size = new Size(227, 23);
            BtnMostrar.TabIndex = 0;
            BtnMostrar.Text = "Mostrar estudiantes";
            BtnMostrar.UseVisualStyleBackColor = true;
            BtnMostrar.Click += BtnMostrar_Click;
            // 
            // LblInfo
            // 
            LblInfo.AutoSize = true;
            LblInfo.Location = new Point(313, 154);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(166, 15);
            LblInfo.TabIndex = 1;
            LblInfo.Text = "Aqui aparecera la infotmacion";
            LblInfo.Click += LblInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblInfo);
            Controls.Add(BtnMostrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnMostrar;
        private Label LblInfo;
    }
}
