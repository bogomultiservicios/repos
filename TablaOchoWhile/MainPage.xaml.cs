namespace TablaOchoWhile
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void generarTabla(object? sender, EventArgs e)
        {
            //Limpiar el stackloyout antes de generar la tabla
            presentacionTabla.Children.Clear();

            //Estaremos trabajando el ciclo while
            //el punto de partida debemos de indicarlo atens de iniciar el ciclo
            int contador = 1;

            //En esta ocación no crearemos variable para el limite
            //porque se colocara fijo o manualmente
            //sinembargo ya en la realidad deberiamos de hacer un posible conteo y ese corresponderia al limite
            //Procedemos con ciclo while, unicamente solicita una expresión
            while (contador <=10) 
            {
                //Procedemos a crear label que corresponderia a una fila
                Label fila = new Label();

                //Insertamos el texto a nuestro label
                fila.Text = "8 x " + contador.ToString() + " = " + (8 * contador).ToString();

                //Insertamos esta fila al Stackloyout
                presentacionTabla.Children.Add(fila);

                //Luego de completar el codigo, procedemos a incrementar nuestro contador
                //es severamente importante incrementar el contador, de lo contrario el ciclo se volvera infinito
                contador++;
            }
        }
    }
}
