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
        public void detectarNumeroMayorTres(object? sender, EventArgs e)
        {
            //capturamos los numeros que el usuario ingreso
            int primerNumeroRecibido = Convert.ToInt32(campoPrimerNumero.Text);
            int segundoNumeroRecibido = Convert.ToInt32(campoSegundoNumero.Text);
            int tercerNumeroRecibido = Convert.ToInt32(campoTercerNumero.Text);

            //Colocaremos condicinal if para evaluar ambos numeros ingresados y determinar el mayor
            if ((primerNumeroRecibido > segundoNumeroRecibido) && 
                (primerNumeroRecibido > tercerNumeroRecibido))
            {
                textoPresentarMayor.Text = "El número mayor es: ";
                textoPresentarMayor.Text += primerNumeroRecibido.ToString();
            }

            else if ((primerNumeroRecibido < segundoNumeroRecibido) && 
                     (tercerNumeroRecibido < segundoNumeroRecibido))
            {
                textoPresentarMayor.Text = "El número mayor es: ";
                textoPresentarMayor.Text += segundoNumeroRecibido.ToString();
            }
            else if ((tercerNumeroRecibido > primerNumeroRecibido) && 
                     (tercerNumeroRecibido > segundoNumeroRecibido))
            {
                textoPresentarMayor.Text = "El número mayor es: ";
                textoPresentarMayor.Text += tercerNumeroRecibido.ToString();
            }
            else 
            {
                textoPresentarMayor.Text = "Resultado: error numerico o todo es de Igual valor";
            }
        }


    }
}
