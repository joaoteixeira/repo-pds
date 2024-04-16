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
using System.Windows.Shapes;

namespace DeckEdu.Telas
{
    /// <summary>
    /// Lógica interna para InicialWindow.xaml
    /// </summary>
    public partial class InicialWindow : Window
    {
        public InicialWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Sair(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
