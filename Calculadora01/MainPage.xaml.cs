using System;
using Microsoft.Maui.Controls;

namespace Calculadora01
{
    public partial class MainPage : ContentPage
    {
        private string operador = string.Empty;
        private double primerNumero = 0;
        private bool nuevoNumero = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Limpiar(object sender, EventArgs e)
        {
            operador = string.Empty;
            primerNumero = 0;
            nuevoNumero = false;
            result.Text = "0";
            lblOperacion.Text = "Operación actual";
        }

        private void Duplicar(object sender, EventArgs e)
        {
            if (double.TryParse(result.Text, out double numero))
            {
                numero *= 2;
                result.Text = numero.ToString();
                lblOperacion.Text = $"{numero / 2} x 2 = {numero}";
            }
        }

        private void NumeroPresionado(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            string numero = boton?.Text ?? "";

            if (result.Text == "0" || nuevoNumero)
            {
                result.Text = numero;
                nuevoNumero = false;
            }
            else
            {
                result.Text += numero;
            }
        }

        private void OperadorPresionado(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            operador = boton?.Text ?? "";

            if (double.TryParse(result.Text, out double numero))
            {
                primerNumero = numero;
                nuevoNumero = true;
                lblOperacion.Text = $"{primerNumero} {operador}";
            }
        }

        private void Calcular(object sender, EventArgs e)
        {
            if (double.TryParse(result.Text, out double segundoNumero))
            {
                double resultado = 0;
                bool error = false;

                switch (operador)
                {
                    case "+":
                        resultado = primerNumero + segundoNumero;
                        break;
                    case "-":
                        resultado = primerNumero - segundoNumero;
                        break;
                    case "*":
                        resultado = primerNumero * segundoNumero;
                        break;
                    case "/":
                        if (segundoNumero == 0)
                        {
                            result.Text = "Error";
                            lblOperacion.Text = "División entre 0 no permitida";
                            error = true;
                        }
                        else
                        {
                            resultado = primerNumero / segundoNumero;
                        }
                        break;
                    default:
                        lblOperacion.Text = "Seleccione un operador válido";
                        error = true;
                        break;
                }

                if (!error)
                {
                    result.Text = resultado.ToString();
                    lblOperacion.Text = $"{primerNumero} {operador} {segundoNumero} = {resultado}";
                }

                nuevoNumero = true;
            }
        }
    }
}
