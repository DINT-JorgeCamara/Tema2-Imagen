﻿using System;
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

namespace Tema2_Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpacidadAlta_Checked(object sender, RoutedEventArgs e)
        {
            Imagen.Opacity = 1 ;
        }

        private void OpacidadMedia_Checked(object sender, RoutedEventArgs e)
        {
            Imagen.Opacity = 0.6;
        }

        private void OpacidadBaja_Checked(object sender, RoutedEventArgs e)
        {
            Imagen.Opacity = 0.3;
        }

        private void AJRelleno_Checked(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.Fill;
        }

        private void AJUniforme_Checked(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.Uniform;
        }
        private void AJRellenoUniforme_Checked(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.UniformToFill;
        }

        private void NoAjuste_Checked(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.None;
        }
    }
}
