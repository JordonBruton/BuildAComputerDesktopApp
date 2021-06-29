using System.Windows;
using MahApps.Metro.Controls;
using BuildAComputerDesktopApp.Views;
using System;
using BuildAComputerDesktopApp.Classes;
using BuildAComputerDesktopApp.Database;

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
