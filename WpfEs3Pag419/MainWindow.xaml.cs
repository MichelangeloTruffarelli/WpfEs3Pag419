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

namespace WpfEs3Pag419
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
            double importo = double.Parse(TxtImponibile.Text);
            double sconto = double.Parse(TxtSconto.Text);
            double impSconto;
            if (sconto == 0)
            {
                impSconto = sconto;
            }
            else
            {
                impSconto = importo / 100 * sconto;
            }
            TxtScontato.Text = impSconto.ToString();
            double IVA = double.Parse(TxtIVA.Text);
            double impIVA;
            if (IVA == 0)
            {
                impIVA = sconto;
            }
            else
            {
                impIVA = importo / 100 * IVA;
            }
            TxtIVA2.Text = impIVA.ToString();
            double lordo = importo - impSconto + impIVA;
            TxtLordo.Text = lordo.ToString();
        }
    }
}
