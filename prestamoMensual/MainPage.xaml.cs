namespace prestamoMensual
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void iniciarPrestamos(object? sender, EventArgs e)
        {
            double receptorMonto = Convert.ToDouble(cajaMonto.Text);
            int receptorMes = Convert.ToInt32(cajaMeses.Text);
            double saldo = receptorMonto;
            //double SaldoDivision = receptorMonto / receptorMes;
            //double nuevoSaldo = SaldoDivision;
            int cuenta = 1;
            double pagoMensual = receptorMonto / receptorMes;
            cajaEstado.Children.Clear();
            while (cuenta <= receptorMes) 
            {
                Label fila = new Label();
                //double SaldoDivision = Math.Round((receptorMonto / receptorMes),2);                        

               
                //Interes Monetario
                //double interes =Math.Round( (nuevoSaldo * 0.015),2);
                double interes = Math.Round((saldo * 0.015), 2);

                double deuda = Math.Round((pagoMensual + interes),2);
                //double deuda = Math.Round((SaldoDivision + interes),2);
                saldo = Math.Round((saldo - pagoMensual),2);
                //if (saldo < 1) 
                //{
                //    saldo = 0;
                //}

                fila.Text = "Mes " + cuenta.ToString() +
                            " Cuota = " + deuda.ToString() +
                            " (Int: " + interes.ToString() +") " +
                            " | Saldo = " + saldo.ToString();
                
                cajaEstado.Children.Add(fila);
                cuenta++;
            }
        }
    }
}
