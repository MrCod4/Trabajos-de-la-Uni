namespace E1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnioDeNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            bool Anio = int.TryParse(txtAnioDeNacimiento.Text, out int anio);

            MessageBox.Show($"Hola {Nombre}, tines {DateTime.Now.Year - anio} años de edad");
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtAnioDeNacimiento.Clear();
            txtNombre.Focus();
        }
    }
}
