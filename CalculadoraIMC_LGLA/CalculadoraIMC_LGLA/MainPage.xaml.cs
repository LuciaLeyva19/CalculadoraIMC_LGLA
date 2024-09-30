using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMC_LGLA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Peso.Text))
            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);

                var imc = peso / (altura * altura);
                IMC.Text = imc.ToString();

                string resultado = "";
                if (imc < 18.5)
                {
                    resultado = "¡Tienes bajo peso!";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    resultado = "Tu peso es normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resultado = "Tienes sobre peso";
                }
                else
                {
                    resultado = "Tienes Obesidad, ¡cuídate!";
                }

                DisplayAlert("Resultado: ", resultado, "Quitar");
            }
            else
            {
                DisplayAlert("Datos erroneos", "Por favor, llena toda la información", "Quitar");
            }
        }
    }
}
