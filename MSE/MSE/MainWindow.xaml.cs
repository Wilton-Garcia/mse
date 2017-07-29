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

namespace MSE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private List<URL> ListaURL = new List<URL>();
        private URL url;

        private void AdicionarUrlNaLista()
        {
            url = new URL();
            url.setEndereco(txb_Url.Text.ToString());
            ListaURL.Add(url);
            lbx_UrlAdicionadas.Items.Add(url.getEndereco());
        }
        public void RemoveURL()
        {
           
        }
        public void ExibeListaDeURL()
        {
           
        }
     


        private void btn_AddURL_Click(object sender, RoutedEventArgs e)
        {
            AdicionarUrlNaLista();
             
        }

        private void btn_RemoverURL_Click(object sender, RoutedEventArgs e)
        {
            RemoveURL();
        }
    }
}
