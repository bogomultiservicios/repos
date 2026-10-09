namespace SecuenciaNumeros
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void generarSecuencia(object sender, EventArgs e) 
        {
            //iniciando ciclo for, recordar que necesita 3 valores
            // el punto de partida, la condicionante o limite, el incremento o decremento
            //para el punto de partida, declaramos una nueva variable, usualmente inicia en 0 o 1
            //en el tercer parametro el doble signo más significa que le sumará un 1 al contador
            for (int contador=1;contador < 11;contador++) 
            {
                //creando label para presentar número 
                Label textoNumero = new Label();
                //insertando el texto que mostrará al label
                textoNumero.Text = contador.ToString();
                //añadiendo el label a la caja numeros
                cajaNumeros.Add(textoNumero);
            }
        }

        public void generarSecuenciaOcho(object sender, EventArgs e)
        {
            //iniciando ciclo for, recordar que necesita 3 valores
            // el punto de partida, la condicionante o limite, el incremento o decremento
            //para el punto de partida, declaramos una nueva variable, usualmente inicia en 0 o 1
            //en el tercer parametro el doble signo más significa que le sumará un 1 al contador
            for (int contador = 1; contador <= 10; contador++)
            {
                //creando label para presentar número 
                Label textoNumero = new Label();
                int TablaOcho = 8 * contador;
                //insertando el texto que mostrará al label
                textoNumero.Text = "8 x " + contador.ToString() + "= " + TablaOcho.ToString();
                //añadiendo el label a la caja numeros
                cajaNumeros.Add(textoNumero);
            }
        }
    }
}
