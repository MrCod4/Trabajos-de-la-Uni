namespace E4
{
    public class Mediodepago
    {
        public virtual double CalcularTotal(double monto)
        {
            return monto;
        }
    }

    public class PagoEnEfectivo : Mediodepago
    {
        public override double CalcularTotal(double monto)
        {
            return monto * 0.90;
        }
    }

    public class PagoConTarjeta : Mediodepago
    {
        public override double CalcularTotal(double monto)
        {
            return monto * 1.05;
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CmbMedioDePago.Items.Add("Efectivo");
            CmbMedioDePago.Items.Add("Tarjeta");
            CmbMedioDePago.SelectedIndex = 0;
        }

        private void CmbMedioDePago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double Monto = double.Parse(txtMonto.Text);
            string MedioDePago = CmbMedioDePago.Text;

            if (Monto <= 0)
            {
                MessageBox.Show("Ingrese un valor mayor a cero");
                return;
            }

            Mediodepago pago;

            if (MedioDePago == "Efectivo")
            {
                pago = new PagoEnEfectivo();
            }
            else
            {
                pago = new PagoConTarjeta();
            }

            double total = pago.CalcularTotal(Monto);
            double totalsobrante = total - Monto;

            ListaDetalles.Items.Clear();

            ListaDetalles.Items.AddRange("Detalle del cobro",
                "-----------------------",
                $"Medio de pago : {MedioDePago}",
                $"Monto original : {Monto}",
                $"Dinero de descuento/recargo : {totalsobrante}",
                $"Total a pagar : {total}"
                );

        }

        private void ListaDetalles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
