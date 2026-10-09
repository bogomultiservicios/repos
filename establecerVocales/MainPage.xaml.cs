namespace establecerVocales
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void evaluadorConsonanteVocal(object? sender, EventArgs e)
        {
            //Capturar dato
            string Letra = campoLetra.Text;
            campoResultado.Text = "CONSONANTE";
            if ((Letra == "a") || (Letra == "e")||(Letra == "i")||
                (Letra == "o")|| (Letra == "u")|| (Letra == "A")||
                (Letra == "E")|| (Letra == "I")|| (Letra == "O")||
                (Letra == "U")) 
            {
                // regresamos la evaluacion ques vocal
                campoResultado.Text = "VOCAL";
            }

            //Evaluamos el valor que sea consonante
           
        }
    }
}
