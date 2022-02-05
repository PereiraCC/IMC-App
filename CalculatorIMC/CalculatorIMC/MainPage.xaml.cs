using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHei.Text) && !string.IsNullOrEmpty(txtHei.Text))
            {
                double hei = double.Parse(txtHei.Text);
                double wei = double.Parse(txtWei.Text);

                double imc = wei / (hei * hei);
                txtImc.Text = imc.ToString();

                string resul = "";

                if (imc < 18.5)
                {
                    resul = "You have low weight";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    resul = "Your weight is normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resul = "You have overweight";
                }
                else
                {
                    resul = "You have obesity";
                }

                DisplayAlert("Result", resul, "OK", "Cancel");
            } else
            {
                DisplayAlert("Result", "The data is invalid", "OK");
            }
        }
    }
}
