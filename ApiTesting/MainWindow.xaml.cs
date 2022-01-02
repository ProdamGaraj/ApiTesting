using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace ApiTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    class ExchangeRates
    {
        decimal EuroBuyPrice;
        decimal DollarBuyPrice;
        decimal EuroCentralBank;
        decimal DollarCentralBank;
    }

    class ApiClient
    {
        static HttpClient client = new HttpClient();

        static async Task<Uri> GetExchangeRates(){ return new ExchangeRates; }
    };

    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }
    }
}
