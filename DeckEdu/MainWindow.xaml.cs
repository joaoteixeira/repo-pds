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
using DeckEdu.Telas;

namespace DeckEdu
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Sair(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Entrar(object sender, RoutedEventArgs e)
        {
            new InicialWindow().Show();
            this.Close();
        }
    }
}
