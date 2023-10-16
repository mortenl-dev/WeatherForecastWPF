using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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


namespace WeatherForecastWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        StackPanel OutputBox;
        public MainWindow()
        {
            
            DataContext = this;
            
            
            InitializeComponent();
            
            OutputBox = element.CreateTextElement("Output");
            MainPanel.Children.Add(OutputBox);
        }
        API fetch = new API();
        Elements element = new Elements();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string latitude = Latitude.Text;
            string longitude = Longitude.Text;
            WeatherData fetched = fetch.CallApi($"https://api.open-meteo.com/v1/forecast?latitude={latitude}.52&longitude={longitude}.41&hourly=temperature_2m");
            Longitude.Text = fetched.Timezone;
        }

        
    }
}
