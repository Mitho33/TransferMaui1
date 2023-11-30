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

namespace TransferMaui1
{
    /// <summary>
    /// Interaktionslogik für GuiHandelspreise1.xaml
    /// </summary>
    public partial class GuiHandelspreise1 : Window
    {
        public GuiHandelspreise1()
        {
            InitializeComponent();
            liste1.ItemsSource = gl.Preisliste;
        }

        ViewModel1 gl = new ViewModel1();

        private void BtnClose(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
