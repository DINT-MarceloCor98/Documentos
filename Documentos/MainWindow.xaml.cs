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

namespace Documentos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Configuracion c;
        public int anchoVentanas = 0;
        public int altoVentanas = 0;

        public MainWindow()
        {
            InitializeComponent();
            anchoVentanas = 500;
            altoVentanas = 500;
        }
        private void NuevoDocumentoButton_Click(object sender, RoutedEventArgs e)
        {
            Documento d = new Documento();
            d.Owner = this;
            d.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            d.Title = "Documento " + this.OwnedWindows.Count.ToString();
            d.Width = anchoVentanas;
            d.Height = altoVentanas;
            d.Show();
        }

        private void ConfiguracionButton_Click(object sender, RoutedEventArgs e)
        {
            c = new Configuracion();
            c.Owner = this;
            c.AltoTextBox.Text = altoVentanas.ToString();
            c.AnchoTextBox.Text = anchoVentanas.ToString();
            c.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            c.ShowDialog();
            
        }

        
    }
}
