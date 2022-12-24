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
				var user = new User()
				{
					Username = Settings.GetUsername(),
					Password = Settings.GetPassword(),
					DeviceID = Settings.GetMacAddress()
				};
				var response = await client.PostAsync<string>(Settings.GetSignInURL(), user, "");
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
				var flightArrival = new FlightArrival()
				{
					FromDate = DateTime.Now.AddHours(-5),
					ToDate = DateTime.Now.AddHours(+5),
					Terminal = "",
					ArrDep = "A",
					Belt = "",
				};
				var token = "";
				var response = await client.PostAsync<string>(Settings.GetFlight2BeltURl(), flightArrival, token);
				var res = JObject.Parse(response);
			}
			catch { }
		}

		public async Task UpdateLuggageStatus()
		{
			try
			{
				using var client = new HttpClient();
				var luggage = new Luggage()
				{
					FieldName = "",
					FieldValue = "",
					FlightDate = "",
					FlightNo = ""
				};
				var token = "";
				var response = await client.PostAsync<string>(Settings.GetUpdateLuggageStatusURL(), luggage, token);
				var res = JObject.Parse(response);
			}
			catch { }
		}
	}
}
