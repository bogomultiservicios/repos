namespace SumaPrimerosNumeros
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void CalcularSecuencia(object? sender, EventArgs e)
        {
            int receptorNumero = Convert.ToInt32(cajaNumero.Text);
            int suma = 0;
            cajaTotal.Text = "Total: ";
            for (int cuenta=1; cuenta <= receptorNumero;cuenta++) 
            {
                suma = suma + cuenta;
                
            }
            cajaTotal.Text += suma.ToString();
        }
    }
}
