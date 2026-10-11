using System.Drawing.Text;

namespace E2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public string ObtenerDescripcion()
            {
                return Nombre + " tiene " + Edad + " años ";
            }
        }
        private void BtnCrear_Click_1(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            persona.Nombre = txtNombre.Text;
            persona.Edad = 2026 - int.Parse(txtAnioNacimiento.Text);

            LblCalculo.Text = persona.ObtenerDescripcion();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnioNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            bool Anio = int.TryParse(txtAnioNacimiento.Text, out int anio);
            string Nombre = txtNombre.Text;

            LblCalculo.Text = $"{Nombre} edad es : {2026 - anio}";


        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtAnioNacimiento.Clear();
            LblCalculo.Text = "";
        }

        private void LblCalculo_Click(object sender, EventArgs e)
        {

        }

    }
}
