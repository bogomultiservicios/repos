namespace NumerosPositivosNegativos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void detectarNumeroPositivoNegativo(object? sender, EventArgs e)
        {
            //Recibir/capturar lo que el usuario escribio
            //luego de recibir el numero lo convertimos a numero
            //y lo asignaremos a una variable
            int numeroRecibido = Convert.ToInt32(campoNumero.Text);
            textoResultado.Text = "Resultado:";
            //procedemos a analizar el numero recibido con un if
            if (numeroRecibido > 0)
            {
                //este primer if presentara en el label numero positivo
                textoResultado.Text += " El numero es positivo";
            }
            
            //colocaremos otro if para evaluar numeros negativos
            if(numeroRecibido < 0) 
            {
                //este segundo if presentara en el label numero negativo
                textoResultado.Text +=  " El numero es negativo";
            }

            //Colocaremos otro if para evaluar el numero 0
            if (numeroRecibido == 0) 
            {
                textoResultado.Text += " El numero es cero";
            }

        }

        //aplicando función con if else

        public void detectarNumeroIfElse(object? sender, EventArgs e)
        {
                //Recibir/capturar lo que el usuario escribio
                //luego de recibir el numero lo convertimos a numero
                //y lo asignaremos a una variable
                int numeroRecibido = Convert.ToInt32(campoNumero.Text);
                textoResultado.Text = "Resultado:";
                //procedemos a analizar el numero recibido con un if
                if (numeroRecibido > 0)
                {
                    //este primer if presentara en el label numero positivo
                    textoResultado.Text += " El numero es positivo";
                }
                else
                {
                    // esta parte del codigo se activo cuando la condicionante o expresión del if
                    // no sea valida o no se cumpla, justamente en este else, estableceremos un mensaje negativo
                    textoResultado.Text = "El numero es negativo";
                }
          }

        }
    }
