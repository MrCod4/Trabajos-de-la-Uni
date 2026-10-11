namespace E3
{
    public partial class Form1 : Form
    {
        List<string> productos = new List<string>() { "Arroz","Harina","Aceite","Fideos","Leche" };
        public Form1()
        {
            InitializeComponent();
            ListaProductos.Items.AddRange(productos.ToArray());
            /*Al buscar formas de como resolver este ejercicio encontre una forma mas facil de añadir todos los datos de la lista de manera mas rapida
             con el AddRange(productos.ToArray())*/
        }

        private void LblBuscar_Click(object sender, EventArgs e)
        {

        }

        private void rxrBuscar_TextChanged(object sender, EventArgs e)
        {
            string Busqueda = rxrBuscar.Text;
            ListaProductos.Items.Clear();

            foreach(string productos in productos)
            {
                if (productos.ToLower().Contains(Busqueda))
                {
                    ListaProductos.Items.Add(productos);
                }
            }
        }

        private void ListaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
