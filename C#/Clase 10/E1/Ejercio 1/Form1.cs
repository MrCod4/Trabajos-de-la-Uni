namespace Ejercio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextoDividir_Click(object sender, EventArgs e)
        {

        }

        private void TxtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtnumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool num10k = double.TryParse(TxtNumero1.Text, out double n1);
            bool num20k = double.TryParse(Txtnumero2.Text, out double n2);

            if(!num10k || !num20k)
            {
                MessageBox.Show("Por favor, ingrese números válidos en ambos campos.");
                return;
            }

            if(n2 == 0)
            {
                TxtResultado.Text = "El segundo número no puede ser cero.";
                return;
            }

            double resultado = n1 / n2;
            TxtResultado.Text = $"El resultado de la división es: {resultado}";
        }
    }
}
