namespace cuentaAhorro
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void generarEstadoAhorro(object? sender, EventArgs e)
        {
            int receptorMonto = Convert.ToInt32(cajaAhorro.Text);
            int receptorMes = Convert.ToInt32(cajaMeses.Text);
            double SaldoAhorro = 0;
            int contador = 1;
            cajaEstado.Children.Clear();
            while (contador <= receptorMes)
            { 
                Label fila = new Label();
                SaldoAhorro = SaldoAhorro + receptorMonto;

                fila.Text = "Mes " + contador.ToString() + ":"+
                            " Depósito = " + receptorMonto.ToString() +
                            " | Acumulado = " + SaldoAhorro.ToString();
                cajaEstado.Children.Add(fila);
                contador++;
            }
        }
    }
}
