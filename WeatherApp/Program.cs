
using Newtonsoft.Json.Linq;
using WeatherApp;

string key = File.ReadAllText("appsettings.json");
string apiKey = JObject.Parse(key).GetValue("DefaultKey").ToString();

Console.WriteLine("Please enter a zipcode");
string zipCode = Console.ReadLine();

Console.WriteLine();

var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={apiKey}&units=imperial";

Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)}°F in your location.\n");