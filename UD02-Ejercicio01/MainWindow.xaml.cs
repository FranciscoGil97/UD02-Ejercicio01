using System;
using System.Windows;

namespace UD02_Ejercicio01
{
    public partial class MainWindow : Window
    {
        private int numeroGenerado;
        public MainWindow()
        {
            InitializeComponent();
        }

        private int GenerarNumero() { return new Random().Next(0, 101); }

        private void ComprobarBoton_Click(object sender, RoutedEventArgs e)
        {
            int numeroUsuario = int.Parse(numeroUsuarioTextBox.Text);

            if (numeroUsuario == numeroGenerado)
                mensajeTextBlock.Text = "¡¡¡Has acertado!!!";
            else
                mensajeTextBlock.Text = (numeroUsuario < numeroGenerado ? "Te has quedado corto" : "Te has pasado");
        }

        private void ReiniciarBoton_Click(object sender, RoutedEventArgs e)
        {
            numeroGenerado = GenerarNumero();
            mensajeTextBlock.Text = "";
            numeroUsuarioTextBox.Text = "";
        }
    }
}
