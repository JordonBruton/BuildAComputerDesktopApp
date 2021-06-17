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
using MahApps.Metro.Controls;
using BuildAComputerDesktopApp.Views;

namespace BuildAComputerDesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BuildYourOwnPCWind(object sender, RoutedEventArgs e)
        {
            BuildYourOwnComputerWindow BuildWind = new BuildYourOwnComputerWindow();

            BuildWind.ShowDialog();
        }

        private void GenerateComputerWind(object sender, RoutedEventArgs e)
        {
            GenerateAComputerWindow GenWind = new GenerateAComputerWindow();

            GenWind.ShowDialog();
        }
    }
}
