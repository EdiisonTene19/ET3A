using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ET3A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double dato1 = Convert.ToDouble(txtNota1.Text);
            double dato2 = Convert.ToDouble(txtNota2.Text);

            double operacion = dato1 * 0.3;
            double operacionExamen = dato2 * 0.2;

            double notaParcial1 = operacion + operacionExamen;

            txtResultado1.Text = notaParcial1.ToString();

            //parcial 2
            double dato3 = Convert.ToDouble(txtNota3.Text);
            double dato4 = Convert.ToDouble(txtNota4.Text);

            double operacionPacial2 = dato3 * 0.3;
            double operacionExamen2 = dato4 * 0.2;

            double notaParcial2 = operacionPacial2 + operacionExamen2;

            txtResultado2.Text = notaParcial2.ToString();

            //nota final
            double notaFinal = notaParcial1 + notaParcial2;
            txtResultadoFinal.Text = notaFinal.ToString();

            //if para mensajes
            if (notaFinal >= 0 && notaFinal <= 4.9)
            {
                txtEstado.Text = "Perdido el semestre";
            }
            if (notaFinal >= 5 && notaFinal <= 6.9)
            {
                txtEstado.Text = "Complementario";
            }
            if (notaFinal >= 7 && notaFinal <= 10)
            {
                txtEstado.Text = "Aprobado";
            }
        }

        private void txtNota1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNota1.Text);
            try
            {

                if (nota1 > 10)
                {
                    DisplayAlert("Alerta", "EL valor no esta permitido", "Cancelar");
                }
            }
            catch (Exception ex)
            {
                nota1 = 0;
            }
        }

        private void txtNota2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nota2 = Convert.ToDouble(txtNota2.Text);
            try
            {

                if (nota2 > 10)
                {
                    DisplayAlert("Alerta", "EL valor no esta permitido", "Cancelar");
                }
            }
            catch (Exception ex)
            {
                nota2 = 0;
            }
        }

        private void txtNota3_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nota3 = Convert.ToDouble(txtNota3.Text);
            try
            {

                if (nota3 > 10)
                {
                    DisplayAlert("Alerta", "EL valor no esta permitido", "Cancelar");
                }
            }
            catch (Exception ex)
            {
                nota3 = 0;
            }
        }

        private void txtNota4_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nota4 = Convert.ToDouble(txtNota4.Text);
            try
            {

                if (nota4 > 10)
                {
                    DisplayAlert("Alerta", "EL valor no esta permitido", "Cancelar");
                }
            }
            catch (Exception ex)
            {
                nota4 = 0;
            }
        }
    }
}