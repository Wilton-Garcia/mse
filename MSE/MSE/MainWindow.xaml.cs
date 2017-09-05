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


        public void AtualizaLista()
        {
            ListaURL.Clear();
            foreach( URL u in ListaURL){
                lbx_UrlAdicionadas.Items.Add(u.getEndereco());
            }
        }


        private void AdicionarUrlNaLista()
        {
            url = new URL();
            url.setEndereco(txb_Url.Text.ToString());
            ListaURL.Add(url);
            AtualizaLista();
        }
        public void RemoveURL()
        {
            String strUrl = lbx_UrlAdicionadas.SelectedItem.ToString();
            foreach (URL u in ListaURL){
                if(u.getEndereco() == strUrl)
                {
                    this.ListaURL = null;
                }
                AtualizaLista();
            }
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
