namespace E2
{
    public partial class Form1 : Form
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        public Form1()
        {
            InitializeComponent();
            ListaAccion.Items.AddRange(new string[] { });
        }

        public class Estudiante
        {
            public string Rut { get; set; }
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public Estudiante(string rut, string nombre, int edad)
            {
                Rut = rut;
                Nombre = nombre;
                Edad = edad;
            }
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListaAccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            string rut = txtRut.Text;
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);

            estudiantes.Add(new Estudiante(rut, nombre, edad));
            ListaAccion.Items.Add(nombre);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int poss = ListaAccion.SelectedIndex;
            ListaAccion.Items.RemoveAt(ListaAccion.SelectedIndex);
            estudiantes.RemoveAt(poss);
        }
    }
}
