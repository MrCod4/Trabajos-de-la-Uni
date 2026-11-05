using System.Data;
using Microsoft.Data.SqlClient;

namespace E1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string conexion =
                @"Server=(localdb)\MSSQLLocalDB;Database=CursoPOO;Integrated Security=True;TrustServerCertificate=True;";
        
            string consulta = @"​
                SELECT E.Id, E.Nombre, E.Correo, C.Nombre AS Carrera​
                FROM Estudiantes E​
                INNER JOIN Carreras C ON E.CarreraId = C.Id";
            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
        
                    using (SqlCommand cmd = new SqlCommand(consulta, cn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        LblInfo.Text = "";
        
                        while (reader.Read())
                        {
                            LblInfo.Text +=
                                $"ID: {reader["Id"]}\n" +
                                $"Nombre: {reader["Nombre"]}\n" +
                                $"Correo: {reader["Correo"]}\n" +
                                $"Carrera: {reader["Carrera"]}\n\n";
                        }
        
                        if (LblInfo.Text == "")
                            LblInfo.Text = "No hay estudiantes registrados.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
            }
        }

        private void LblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
