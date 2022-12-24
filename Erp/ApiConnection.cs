using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Cryptography.Xml;
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
				Settings.SaveToken(token);
			}
			catch (Exception ex)
			{

			}
		}

		public async Task RenewToken()
		{
			try
			{
				using var client = new HttpClient();
				var oldToken = Settings.GetToken();
				var payload = new
				{
					oldToken = oldToken,
					deviceID = Settings.GetMacAddress()
				};
				var response = await client.PostAsync<string>(Settings.GetRenewTokenURL(), payload, Settings.GetToken());
				var res = JObject.Parse(response);
			}
			catch { }
		}

		public async Task<string> Flight2Belt()
		{
			try
			{
				using var client = new HttpClient();
				var flightArrival = new FlightArrival()
				{
					FromDate = DateTime.Now.AddHours(-5),
					ToDate = DateTime.Now.AddHours(+5),
					Terminal = Settings.GetTerminal(),
					ArrDep = "A",
					Belt = Settings.GetBelt(),
				};
				var token = Settings.GetToken();
				if (string.IsNullOrEmpty(token))
				{
					await Signin();
				}
				var response = await client.PostAsync<string>(Settings.GetFlight2BeltURl(), flightArrival, Settings.GetToken());
				if (response == HttpStatusCode.Unauthorized.ToString()) {
					RenewToken();
					response = await client.PostAsync<string>(Settings.GetFlight2BeltURl(), flightArrival, Settings.GetToken());
				}
				return response;
			}
			catch (Exception ex) { return ex.Message; }
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
