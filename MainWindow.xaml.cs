using PrimerParcial.BLL;
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

namespace PrimerParcial
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
        private void Limpiar()
        {
            ProductoIdTex.Text = String.Empty;
            DescripcionTex.Text = String.Empty;
           CostoTex.Text = String.Empty;
            ValorInventarioTex.Text = String.Empty;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            int Id;
            var E = new Entidades();
            int.TryParse(ProductoIdTex.Text, out Id);
            Limpiar();

            E = EntidadesBLL.Buscar(Id);

            if (E != null)
            {
                MessageBox.Show("Se Eliminó ");
            }
            else
            {
                MessageBox.Show("No se Eliminó");
            }
        }

        private void ProductoIdTex_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DescripcionTex_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CostoTex_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ValorInventarioTex_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NuevoBotton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GuargarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BuscarBotton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
