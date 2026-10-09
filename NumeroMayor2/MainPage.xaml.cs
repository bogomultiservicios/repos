namespace NumeroMayor2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        //creando metodo para determinar el número mayor
        public void detectarNumeroMayor(object? sender, EventArgs e)
        {
            //capturamos los numeros que el usuario ingreso
            int primerNumeroRecibido = Convert.ToInt32(campoPrimerNumero.Text);
            int segundoNumeroRecibido = Convert.ToInt32(campoSegundoNumero.Text);
           

            //Colocaremos condicinal if para evaluar ambos numeros ingresados y determinar el mayor
            if (primerNumeroRecibido>segundoNumeroRecibido)
                //dentro de un conjuto de llaves puede ir la lineas de codigo que necesite
            {
                textoPresentarMayor.Text = "Resultado: ";
                textoPresentarMayor.Text += primerNumeroRecibido.ToString();
            }
            
            if (primerNumeroRecibido < segundoNumeroRecibido)
            {
                textoPresentarMayor.Text = "Resultado: ";
                textoPresentarMayor.Text += segundoNumeroRecibido.ToString();
            }
        }
    }
}
