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
using OxyPlot.Axes;
using OxyPlot.Annotations;
using System.Windows.Media.Animation;
using System.Text.RegularExpressions;


namespace WeatherForecastWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            
            DataContext = this;
            
            
            InitializeComponent();
            
            MainPanel.Children.Add(element.CreateTextElement("Weather Forecast by mortenl-dev"));
            MainPanel.Children.Add(element.CreateTextElement("Created with the help of: https://open-meteo.com"));

            
        }
        API fetch = new API();
        Elements element = new Elements();

        WeatherData? fetched;
        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            CreateFetch();
            
        }

        private void CreateFetch() {
            try {
                int templat = Int16.Parse(Latitude.Text);
                int templong= Int16.Parse(Longitude.Text);
                int tempdays = Int16.Parse(DaysCount.Text);
                string latitude = templat.ToString();
                string longitude = templong.ToString();
                string days = tempdays.ToString();
                fetched = fetch.CallApi($"https://api.open-meteo.com/v1/forecast?latitude={latitude}.52&longitude={longitude}.41&hourly=temperature_2m&forecast_days={days}");
            }
            catch (FormatException) {
                return;
            }
            
            
            CreateGraph();
        }
        private void CreateGraph()
        {
            // Create the PlotModel
            PlotModel plotModel = new PlotModel { Title = "Weather forecast in degrees Celsius" };

            // Create X and Y axes
            var yAxis = new LinearAxis { Position = AxisPosition.Left, Title = "Celsius C" };

            // Add axes to the plot model
            
            plotModel.Axes.Add(yAxis);
            // Create a LineSeries for the graph
            

            var xAxis = new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Time t",
                
                StringFormat = "yyyy-MM-dd HH:mm", // Format for displaying dates
                MajorStep = 1,
            };
            plotModel.Axes.Add(xAxis);
            LineSeries series = new LineSeries
            {
                Title = "Data Series",
                StrokeThickness = 2,
                MarkerSize = 4
            };


            // Add data points (you can replace this with your data)
            for (int x = 0; x < fetched!.Hourly!.Time!.Count; x ++)
            {   
                double time = DateTimeAxis.ToDouble(DateTime.Parse(fetched.Hourly.Time[x]));
                float y = (float) Convert.ToDouble(fetched.Hourly.Temperature_2m![x]);
                series.Points.Add(new DataPoint(time, y));
            }
            // Add the series to the plot model
            plotModel.Series.Add(series);

            // Set the plot model to the PlotView
            plotView.Model = plotModel;
        }
    }

    
}

        
    

