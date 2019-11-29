using System;
using System.Collections.Generic;
using System.IO;
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

namespace Documentos
{
    /// <summary>
    /// Lógica de interacción para Documento.xaml
    /// </summary>
    public partial class Documento : Window
    {
        public Documento()
        {
            InitializeComponent();
        }

        private void Documento_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(MessageBox.Show("¿Seguro que quieres cerrar?","Cerrar",MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dialogo = new Microsoft.Win32.SaveFileDialog();
            dialogo.Filter = "Archivos de texto|*.txt";
            dialogo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if(dialogo.ShowDialog() == true)
            {
                File.WriteAllText(dialogo.FileName,DocumentoTextBox.Text);
            }
        }
    }
}
