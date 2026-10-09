namespace EstadoCuenta
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void generarEstado(object? sender, EventArgs e)
        {
            int receptorMeses = Convert.ToInt32(cajaMeses.Text);
            double receptorMonto = Convert.ToDouble(cajaMonto.Text);
            //double subTotal = receptorMonto;
            //double Total = 0;
            double Total = receptorMonto;
            cajaEstado.Children.Clear();
            for (int meses=1; meses <= receptorMeses;meses++) 
            {
                Label mostrarMonto = new Label();
                double division = (receptorMonto / receptorMeses);
                //double operar = receptorMonto / receptorMeses;
                double operar = Math.Round(division, 2);
                //double operar = receptorMonto / receptorMeses;
                // subTotal = (Total - operar);
                Total = Math.Round( (Total - operar),2);
                //Total = Total - operar;
                if (Total < 1) 
                {
                    Total = 0.00;
                }

                mostrarMonto.Text = " Mes " + meses.ToString() + 
                                    ": Cuota " + operar.ToString() + 
                                    "| Saldo restante =" + Total.ToString();
                cajaEstado.Add(mostrarMonto);
            }
           
        }
    }
}
