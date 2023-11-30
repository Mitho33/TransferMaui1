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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TransferMaui1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void BtnHandelspreise(object sender, RoutedEventArgs e)
        {
            GuiHandelspreise1 guiHandelspreise1 = new GuiHandelspreise1();
            guiHandelspreise1.Show();
        }

        private void BtnEndverbraucherpreise(object sender, RoutedEventArgs e)
        {
            GuiVerbraucher1 guiVerbraucher1 = new GuiVerbraucher1();
            guiVerbraucher1.Show();
        }
    }
}
