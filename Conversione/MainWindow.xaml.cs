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

namespace Conversione
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string n = txtBinario.Text;
            if (combobox.SelectedIndex == 0)
            {
                int risultato = Convert.ToInt32(n, 2);
                txtNulla.Text = risultato.ToString();
            }
            else if (combobox.SelectedIndex == 1)
            {
                int a = int.Parse(n);
                string risultato = Convert.ToString(a, 2);
                txtNulla.Text = risultato.ToString();
            }
            
        }
    }
}
