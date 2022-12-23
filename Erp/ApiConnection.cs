using BaggageApp.Extentions;
using BaggageApp.Models;
using Newtonsoft.Json.Linq;

namespace BaggageApp.Erp
{
	public class ApiConnection
	{
		public async Task Signin()
		{
			try
			{
				using var client = new HttpClient();
				var url = "https://ws.noibaiairport.org";
				var user = new User() { Username = "bags.api", Password = "4sRS!K78_Q0w", DeviceID=""};
				var response = await client.PostAsync<string>($"{url}/MobileSignIn", user, "");
				var res = JObject.Parse(response);
				var token = res["data"][0]["token"].ToString();
			}
			catch { }
		}

		public async Task Flight2Belt()
		{
			try
			{
				using var client = new HttpClient();
				var url = "https://ws.noibaiairport.org";
				var flightArrival = new FlightArrival() {
					FromDate = DateTime.Now.AddHours(-5),
					ToDate= DateTime.Now.AddHours(+5),
					Terminal = "",
					ArrDep= "A",
					Belt = "",
				};
				var token = "";
				var response = await client.PostAsync<string>($"{url}/FlightArrival/FlightByBelt", flightArrival, token);
				var res = JObject.Parse(response);
			}
			catch { }
		}

		public async Task UpdateLuggageStatus()
		{
			try
			{
				using var client = new HttpClient();
				var url = "http://api.noibaiairport.org";
				var luggage = new Luggage() {
					FieldName="",
					FieldValue="",
					FlightDate="",
					FlightNo = ""
				};
				var token = "";
				var response = await client.PostAsync<string>($"{url}/api/WSSMIS8011", luggage, token);
				var res = JObject.Parse(response);
			}
			catch { }
		}
	}
}
