using System;
using System.Net.Http;
using Newtonsoft.Json;

public class API {
    const string forecast = "https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&hourly=temperature_2m";
    public void CallApi(string URL) {
            HttpClient client = new HttpClient();
            var responseTask = client.GetAsync(URL);
            responseTask.Wait();
            try {
                if (responseTask.IsCompleted) {
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode) {
                    var msg = result.Content.ReadAsStringAsync();
                    msg.Wait();

                    var root = JsonConvert.DeserializeObject<dynamic>(msg.Result)!;
                    Console.WriteLine(root);
                    
                }
                }
            }
            catch (FormatException) {
            }
        }
}
