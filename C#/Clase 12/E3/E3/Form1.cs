using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace E3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CmbTipo.Items.AddRange("Gerrero","Mago","Arquero");
        }

        public class Personaje
        {
            public int Id { get; set; }
            public string Nombre { get; set; } = "";
            public string Tipo { get; set; } = "";
            public int Nivel { get; set; }

            public override string ToString()
            {
                return $"{Id} | {Nombre} | {Tipo} | {Nivel}";
            }

        }

        public class PersonajeDatos
        {
            private readonly string cadenaConexion =
                @"Server=(localdb)\MSSQLLocalDB;Database=master;Integrated Security=True;TrustServerCertificate=True;";

            public void Guardar(Personaje personaje)
            {
                string sql = @"
            INSERT INTO Personaje (Nombre, Tipo, Nivel)
            VALUES (@Nombre, @Tipo, @Nivel)";

                using (SqlConnection conexion =
                       new SqlConnection(cadenaConexion))
                using (SqlCommand comando =
                       new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@Nombre", personaje.Nombre);

                    comando.Parameters.AddWithValue(
                        "@Tipo", personaje.Tipo);

                    comando.Parameters.AddWithValue(
                        "@Nivel", personaje.Nivel);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }

            public List<Personaje> Listar()
            {
                List<Personaje> personaje = new List<Personaje>();

                string sql = @"
            SELECT Id, Nombre, Tipo, Nivel
            FROM Personaje
            ORDER BY Id";

                using (SqlConnection conexion =
                       new SqlConnection(cadenaConexion))
                using (SqlCommand comando =
                       new SqlCommand(sql, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader lector =
                           comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Personaje p = new Personaje
                            {
                                Id = lector.GetInt32(0),
                                Nombre = lector.GetString(1),
                                Tipo = lector.GetString(2),
                                Nivel = lector.GetInt32(3)
                            };

                            personaje.Add(p);
                        }
                    }
                }

                return personaje;
            }
        }

        private void TxtNombrePersonaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void NumNivel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombrePersonaje.Text))
            {
                MessageBox.Show("Debes Ingresar el nombre del personaje");
                return;
            }

            if (CmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debes elegir un tipo de personaje");
                return;
            }

            try
            {
                PersonajeDatos datos = new PersonajeDatos();

                MessageBox.Show("Personaje ingresado correctamente");

                TxtNombrePersonaje.Clear();
                CmbTipo.SelectedIndex = -1;
                NumNivel.Value = 1;

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo guardar el personaje" + ex.Message);
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            try
            {
                PersonajeDatos datos = new PersonajeDatos();

                LstPersonajes.DataSource = null;
                LstPersonajes.DataSource = datos.Listar();

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudioeron cargar los personajes "+ ex.Message);
            }
        }

        private void LstPersonajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LstPersonajes.SelectedItem is Personaje p)
            {
                LblDetalle.Text = $"Nombre: {p.Nombre} | Tipo : {p.Tipo} | Nivel : {p.Nivel}";
            }
        }

        private void LblDetalle_Click(object sender, EventArgs e)
        {

        }
    }
}
