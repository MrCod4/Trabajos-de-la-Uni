namespace E3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TipoSeleccionado.Items.AddRange(new string[] { "Gerrero", "Mago", "Arquero" });
        }

        public class Personaje
        {
            public string Nombre { get; set; }
            public int PtsVida { get; set; }

            public Personaje(string nombre, int ptsvida)
            {
                Nombre = nombre;
                PtsVida = ptsvida;
            }

            public virtual string Atacar()
            {
                return $"Ataque basico de {Nombre}";
            }
        }

        public class Gerrero : Personaje
        {
            public Gerrero(string nombre) : base(nombre, 120) { }

            public override string Atacar()
            {
                return $"{Nombre} asesta espadado";
            }
        }

        public class Mago : Personaje
        {
            public Mago(string nombre) : base(nombre, 80) { }
            public override string Atacar()
            {
                return $"{Nombre} lanza una bola de fuego";
            }
        }

        public class Arquero : Personaje
        {
            public Arquero(string nombre) : base(nombre, 95) { }
            public override string Atacar()
            {
                return $"{Nombre} dispara una flecha";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TipoSeleccionado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAtacar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string tiposeleccionado = TipoSeleccionado.Text;

            Personaje mipersonaje;

            if (tiposeleccionado == "Gerrero")
            {
                mipersonaje = new Gerrero(nombre);
            }
            else if (tiposeleccionado == "Mago")
            {
                mipersonaje = new Mago(nombre);
            }
            else
            {
                mipersonaje = new Arquero(nombre);
            }

            LblResultado.Text = mipersonaje.Atacar();
        }

        private void LblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
