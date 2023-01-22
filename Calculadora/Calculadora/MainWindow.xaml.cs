using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double numeroAnterior, resultado;
        OperacionSeleccionada operacionSeleccionada;
        public enum OperacionSeleccionada
        {
            Suma,
            Resta,
            Multiplicacion,
            Division
        }


        public class Calcular
        {
            public static double Suma(double n1, double n2)
            {
                return n1 + n2;
            }
            public static double Resta(double n1, double n2)
            {
                return n1 - n2;
            }
            public static double Multiplicacion(double n1, double n2)
            {
                return n1 * n2;
            }
            public static double Division(double n1, double n2)
            {
                if(n2 == 0)
                {
                    MessageBox.Show(
                        "La división por 0 no está definida", 
                        "Operacion Incorrecta", 
                        MessageBoxButton.OK, 
                        MessageBoxImage.Error);
                    return 0;
                }
                return n1 / n2;
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            acBoton.Click += AcBoton_Click;
            negativoBoton.Click += NegativoBoton_Click;
            porcentajeBoton.Click += PorcentajeBoton_Click;
            igualBoton.Click += IgualBoton_Click;
            puntoBoton.Click += PuntoBoton_Click;
        }

        private void PuntoBoton_Click(object sender, RoutedEventArgs e)
        {

            //if (resultadoLabel.Content.ToString().Contains(","))
            //{

            //}
            //else
            //{
            //    resultadoLabel.Content = $"{resultadoLabel.Content}";
            //}

            resultadoLabel.Content = resultadoLabel.Content.ToString().Contains(",") ? resultadoLabel.Content : $"{resultadoLabel.Content}";
        }

        private void IgualBoton_Click(object sender, RoutedEventArgs e)
        {
            
            if (double.TryParse(resultadoLabel.Content.ToString(), out double numeroNuevo))
            {
                switch (operacionSeleccionada)
                {
                    case OperacionSeleccionada.Suma:
                        resultado = Calcular.Suma(numeroAnterior, numeroNuevo);
                        break;
                    case OperacionSeleccionada.Resta:
                        resultado = Calcular.Resta(numeroAnterior, numeroNuevo);
                        break;
                    case OperacionSeleccionada.Multiplicacion:
                        resultado = Calcular.Multiplicacion(numeroAnterior, numeroNuevo);
                        break;
                    case OperacionSeleccionada.Division:
                        resultado = Calcular.Division(numeroAnterior, numeroNuevo);
                        break;
                }
            }
            resultadoLabel.Content = $"{resultado}";

        }

        private void OperacionBoton_Click(object sender, RoutedEventArgs e)
        {

            //Con esto vuelvo al valor mostrado y guardo el anterior valor
            if (double.TryParse(resultadoLabel.Content.ToString(), out  numeroAnterior))
            {
                resultadoLabel.Content = "0";
            }
            //Con esto selecciono la operacion que realizare cuando le de al igual

            operacionSeleccionada = sender == MultiplicarBoton ? OperacionSeleccionada.Multiplicacion : operacionSeleccionada;
            operacionSeleccionada = sender == divisionBoton ? OperacionSeleccionada.Division : operacionSeleccionada;
            operacionSeleccionada = sender == sumarBoton ? OperacionSeleccionada.Suma : operacionSeleccionada;
            operacionSeleccionada = sender == restarBoton ? OperacionSeleccionada.Resta: operacionSeleccionada;
        }

        private void NumeroBoton_Click(object sender, RoutedEventArgs e)
        {
            int valorSeleccionado = int.Parse((sender as Button).Content.ToString());
            
            //if(resultadoLabel.Content.ToString() == "0")
            //{
            //    resultadoLabel.Content = $"{valorSeleccionado}";
            //}
            //else
            //{
            //    resultadoLabel.Content = $"{resultadoLabel.Content}{valorSeleccionado}";
            //}

            resultadoLabel.Content = (resultadoLabel.Content.ToString() == "0") ? $"{valorSeleccionado}" : $"{resultadoLabel.Content}{valorSeleccionado}";
        }

        private void PorcentajeBoton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultadoLabel.Content.ToString(), out double numeroAnterior))
            {
                numeroAnterior = numeroAnterior / 100;
                resultadoLabel.Content = $"{numeroAnterior}";
            }
        }

        private void NegativoBoton_Click(object sender, RoutedEventArgs e)
        {
            //volver negativo el resultado que se muestra en pantalla
            if(double.TryParse(resultadoLabel.Content.ToString(), out double numeroAnterior))
            {
                numeroAnterior = numeroAnterior * -1;
                resultadoLabel.Content = $"{numeroAnterior}";
            }
        }

        private void AcBoton_Click(object sender, RoutedEventArgs e)
        {
            //Borrar el resultado que se muestra en la pantalla
            resultadoLabel.Content = "0";
        }

        
    }
}
