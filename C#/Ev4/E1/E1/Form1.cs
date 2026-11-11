namespace E1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Operaciones
        {
            public double N1 { get; set; }
            public double N2 { get; set; }

            public double contadornumero = 1;
            public int contadorOperador = 0;

            public double Resultado;
        }

        Operaciones o = new Operaciones();

        private void TxtOperaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtOperaciones.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtOperaciones.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtOperaciones.Text += "3";
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if (o.contadornumero == 1)
            {
                o.N1 = double.Parse(TxtOperaciones.Text);
                o.contadornumero = 2;
            }
            else
            {
                o.N2 = double.Parse(TxtOperaciones.Text);
                o.contadornumero = 1;
            }

            o.contadorOperador = 1;
            TxtOperaciones.Clear();
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            if (o.contadornumero == 1)
            {
                o.N1 = double.Parse(TxtOperaciones.Text);
                o.contadornumero = 2;
            }
            else
            {
                o.N2 = double.Parse(TxtOperaciones.Text);
                o.contadornumero = 1;
            }

            o.contadorOperador = 2;

            o.Resultado = o.N1 / o.N2;

            TxtOperaciones.Clear();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtOperaciones.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtOperaciones.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtOperaciones.Text += "6";
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            if (o.contadornumero == 1)
            {
                o.N1 = double.Parse(TxtOperaciones.Text);
                o.contadornumero = 2;
            }
            else
            {
                o.N2 = double.Parse(TxtOperaciones.Text);
                o.contadornumero = 1;
            }

            o.contadorOperador = 3;

            o.Resultado = o.N1 + o.N2;

            TxtOperaciones.Clear();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtOperaciones.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtOperaciones.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtOperaciones.Text += "9";
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            if (o.contadornumero == 1)
            {
                o.N1 = double.Parse(TxtOperaciones.Text);
                o.contadornumero = 2;
            }
            else
            {
                o.N2 = double.Parse(TxtOperaciones.Text);
                o.contadornumero = 1;
            }

            o.contadorOperador = 4;

            o.Resultado = o.N1 - o.N2;

            TxtOperaciones.Clear();
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            TxtOperaciones.Text += ".";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TxtOperaciones.Text += "1";
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            if (o.contadornumero == 1)
            {
                o.N1 = double.Parse(TxtOperaciones.Text);
                o.contadornumero = 2;
            }
            else
            {
                o.N2 = double.Parse(TxtOperaciones.Text);
                o.contadornumero = 1;
            }

            if(o.contadorOperador == 1)
            {
                o.Resultado = o.N1 * o.N2;
            }
            else if (o.contadorOperador == 2)
            {
                if(o.N2 == 0)
                {
                    MessageBox.Show("No se puede dividir por 0");
                }
                else
                {
                    o.Resultado = o.N1 / o.N2;
                }
            }
            else if(o.contadorOperador == 3)
            {
                o.Resultado = o.N1 + o.N2;
            }
            else if (o.contadorOperador == 4)
            {
                o.Resultado = o.N1 - o.N2;
            }
            else
            {
                o.Resultado = o.N1;
            }




            TxtOperaciones.Text = $"{o.Resultado}";
            ListaHistorial.Items.Add($"{o.Resultado}");
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtOperaciones.Clear();
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            
        }

        private void ListaHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnBorrarHist_Click(object sender, EventArgs e)
        {
            ListaHistorial.Items.Clear();
        }
    }
}
