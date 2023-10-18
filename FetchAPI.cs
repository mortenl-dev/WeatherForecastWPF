using System;
using System.Net.Http;
using Newtonsoft.Json;

public class API {
    public const string forecast = "https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&hourly=temperature_2m";
    public WeatherData CallApi(string URL) {
            HttpClient client = new HttpClient();
            var responseTask = client.GetAsync(URL);
            responseTask.Wait();
            try {
                if (responseTask.IsCompleted) {
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode) {
                    var msg = result.Content.ReadAsStringAsync();
                    msg.Wait();

                    WeatherData root = JsonConvert.DeserializeObject<WeatherData>(msg.Result)!;
                    return root;
                }
                }
            }
            catch (FormatException) {
                
            }
            return null!;
        }
}
