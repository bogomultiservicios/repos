namespace ToDo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        //Creando función o metodo para capturar la tarea
        public void agregarTarea(object? sender,EventArgs e)
        {
            //procedemos a capturar el texto y asignarlo a una variable
            //para crear una variable en c# debemos escribir primero el tipo de dato
            //luego el nombre  y por ultimo la asignación del valor
            string textoCapturado = campoTarea.Text;
            string personaIngresada = personaAsignada.Text;
            //procedemos a crear la casilla
            CheckBox casilla = new CheckBox();
            //procedemos a cresar etiqueta label que presentará el texto que capturamos hace un momento
            Label textoPresentar = new Label();
            //insertando texto al label
            textoPresentar.Text = textoCapturado + " " + personaIngresada;
            //asignando tamaño de letra
            textoPresentar.FontSize = 16;
            //aplicando centrado vertical al texto
            textoPresentar.VerticalOptions = LayoutOptions.Center;
            
            //insertando evento cambio es decri cuando marke casilla
            //en esta ocación el += corresponde a un public void
            casilla.CheckedChanged += (_, _) => 
            textoPresentar.TextDecorations = casilla.IsChecked //validando que este marcada la casilla 
            ? TextDecorations.Strikethrough //estas linea tacha el texto
            : TextDecorations.None;//quita el tachado
            
            //Creando fila para insertar visualmente la casilla y el texto
            HorizontalStackLayout fila = new HorizontalStackLayout();
            //Insertando visualmente la casilla a la fila
            fila.Children.Add(casilla);
            // insertando visualmente el texto
            fila.Children.Add(textoPresentar);
            //Insertando la fila en nuestra caja tareas
            cajaTareas.Children.Add(fila);
            //Limpiando el campo
            campoTarea.Text = "";
            personaAsignada.Text = "";

        }

        private void Casilla_CheckedChanged(object? sender, CheckedChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
