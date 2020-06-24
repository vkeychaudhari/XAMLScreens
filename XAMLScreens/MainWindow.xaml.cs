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
using XAMLScreens.CommonControls;
using XAMLScreens.Usercontrols;

namespace XAMLScreens
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : CustomWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            btnHome.IsChecked = true;
            HomeView home = new HomeView();
            maincontent.Content = home;
        }

        private void BtnLista_Click(object sender, RoutedEventArgs e)
        {
            if (btnLista.IsChecked == true)
            {
                textHeader.Text = "LISTA DE TRABAJO";
                ListaView lista = new ListaView();
                maincontent.Content = lista;
            }
            else
            {
                textHeader.Text = "PEDIDOS";
                Pedidos pedidos = new Pedidos();
                maincontent.Content = pedidos;
            }
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            if (btnHome.IsChecked == true)
            {
                textHeader.Text = "INCIO";
                HomeView home = new HomeView();
                maincontent.Content = home;
            }
        }

        private void BtnConfig_Click(object sender, RoutedEventArgs e)
        {
            textHeader.Text = "CONFIGURACION";
            ConfigView config = new ConfigView();
            maincontent.Content = config;
        }
    }
}
