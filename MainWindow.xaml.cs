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
using OxyPlot;
using OxyPlot.Series;


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

        WeatherData? fetched;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string latitude = Latitude.Text;
            string longitude = Longitude.Text;
            fetched = fetch.CallApi($"https://api.open-meteo.com/v1/forecast?latitude={latitude}.52&longitude={longitude}.41&hourly=temperature_2m");
            Longitude.Text = fetched.Timezone;
            CreateGraph();
        }
        private void CreateGraph()
        {
            // Create the PlotModel
            PlotModel plotModel = new PlotModel { Title = "Sample Graph" };

            // Create a LineSeries for the graph
            LineSeries series = new LineSeries
            {
                Title = "Data Series",
                StrokeThickness = 2,
                MarkerType = MarkerType.Circle,
                MarkerSize = 4
            };

            // Add data points (you can replace this with your data)
            for (int x = 0; x < fetched.Hourly.Time.Count; x ++)
            {   
                float y = (float) Convert.ToDouble(fetched.Hourly.Temperature_2m[x]);
                series.Points.Add(new DataPoint(x, y));
            }

            // Add the series to the plot model
            plotModel.Series.Add(series);

            // Set the plot model to the PlotView
            plotView.Model = plotModel;
        }
    }
}
        
    

