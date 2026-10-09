namespace Restaurante
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void calcularMotoAPagar(object? sender, EventArgs e)
        {
            int receptorMontoACalcular = Convert.ToInt32(campoMonto.Text);
            double nuevoMonto = 0;
            double descuento = 0;
            double impuesto = 0;
            double pagoMonto = 0;
            if (receptorMontoACalcular <= 100) 
            {
                montoDescuento.Text = "Monto del Descuento: ";
                montoImpuesto.Text = "Impuesto: ";
                montoPagar.Text = "Importe a Pagar: ";
                descuento = receptorMontoACalcular * 0.10;
                nuevoMonto = receptorMontoACalcular - descuento;
                impuesto = nuevoMonto * 0.12;
                pagoMonto = nuevoMonto + impuesto;
                montoDescuento.Text += descuento.ToString();
                montoImpuesto.Text += impuesto.ToString();
                montoPagar.Text+= pagoMonto.ToString();
            }

            if (receptorMontoACalcular > 100)
            {
                montoDescuento.Text = "Monto del Descuento: ";
                montoImpuesto.Text = "Impuesto: ";
                montoPagar.Text = "Importe a Pagar: ";
                descuento = receptorMontoACalcular * 0.20;
                nuevoMonto = receptorMontoACalcular - descuento;
                impuesto = nuevoMonto * 0.12;
                pagoMonto = nuevoMonto + impuesto;
                montoDescuento.Text += descuento.ToString();
                montoImpuesto.Text += impuesto.ToString();
                montoPagar.Text += pagoMonto.ToString();
            }
        }
    }
}
