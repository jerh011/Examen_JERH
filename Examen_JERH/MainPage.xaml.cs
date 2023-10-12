using System;
using System.Reflection;
using Xamarin.Forms;

namespace Examen_JERH
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int _latidos;
        int Frencuencia_1;
        private void Button_Clicked(object sender, EventArgs e)
        {
             _latidos = Convert.ToInt32(Latidos.Text);
            Calcular_precuencia();

        }
        public void Calcular_precuencia()
        {
           int  Frecuencia_1 = _latidos * 4;

            Frecuencia.Text = Convert.ToString(_latidos * 4);
            Mensage(Frecuencia_1);
        }


        public void Mensage(int Frecuencia_1) {
            string mensaje = "";
            string mensaje1 = "";
            if (Frecuencia_1 > 100)
            {
                mensaje1 = "Estas mejora tu alimento";
                mensaje = "Fc alta";
            }
            else if (Frecuencia_1 >= 60) {
                mensaje1 = "estas bien";
                mensaje = "Fc Normal"; }
            else if (Frecuencia_1 < 60) {
                mensaje1 = "Come mas";
                mensaje = "Fc baja";
        }
            Alerta(mensaje, mensaje1);
        }
        public void Alerta(string MENSAGE, string MENSAG1) {
            DisplayAlert(MENSAG1, MENSAGE, "Okey");
        }

    }
}
