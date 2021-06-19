using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTareaOperaciones
{
    public partial class MainPage : ContentPage
    {
        clases.DatosOperaciones datosOperaciones;
        private double numero1;
        private double numero2; 


        public MainPage()
        {
            InitializeComponent();
           
           
        }
 
      void datos()
        {

            numero1 = (num1.Text == null || num1.Text=="") ? 0.0 : double.Parse(num1.Text);
            numero2 = (num2.Text==null || num2.Text == "") ? 0.0 : double.Parse(num2.Text);
           
            datosOperaciones = new clases.DatosOperaciones(numero1,numero2);
            //datosOperaciones.setNumero1(numero1);
            //datosOperaciones.setNumero2(numero2);
        }
        async void suma(object sender, System.EventArgs e)
        {
            datos();
            double resultado = datosOperaciones.getNumero1() + datosOperaciones.getNumero2();
            respuesta.Text = resultado.ToString();
            await Navigation.PushAsync(new Page2(resultado));
         }
        async void resta(object sender, System.EventArgs e)
        {
            datos();
            double resultado = datosOperaciones.getNumero1() - datosOperaciones.getNumero2();
            respuesta.Text = resultado.ToString();
            await Navigation.PushAsync(new Page2(resultado));
        }

       async void multiplicacion(object sender, System.EventArgs e)
        {
            datos();
            double resultado = datosOperaciones.getNumero1() * datosOperaciones.getNumero2();
            respuesta.Text = resultado.ToString();
            await Navigation.PushAsync(new Page2(resultado));
        }
        async void division(object sender, System.EventArgs e)
        {
            datos();
           
            double resultado = datosOperaciones.getNumero1() / datosOperaciones.getNumero2();

            respuesta.Text = resultado.ToString();
            await Navigation.PushAsync(new Page2(resultado));

        }
    }
}
