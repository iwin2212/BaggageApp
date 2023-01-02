using System.Globalization;
using System.Net;
using BaggageApp.Extentions;
using BaggageApp.Models;
using BaggageApp.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BaggageApp.Erp
{
	public class ApiConnection
	{
		public async Task<string> Signin()
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
				return string.Empty;
			}
			catch (Exception ex)
			{
				Logger.Log($"Signin: {ex.Message}");
				return ex.Message;
			}
		}

		public async Task<string> RenewToken()
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
				return string.Empty;
			}
			catch (Exception ex)
			{
				Logger.Log($"RenewToken: {ex.Message}");
				return ex.Message;
			}
		}

		public async Task<string> Flight2Belt()
		{
			try
			{
				var now = await GetServerTime();
				using var client = new HttpClient();
				var flightArrival = new FlightArrival()
				{
					FromDate = (DateTime) (now?.AddHours(-36)),
					ToDate = (DateTime) (now?.AddHours(-24)),
					Terminal = Settings.GetTerminal(),
					ArrDep = "A",
					Belt = Settings.GetBelt(),
				};
				Logger.Log($"Flight2Belt - flightArrival: {JsonConvert.SerializeObject(flightArrival)}");
				var token = Settings.GetToken();
				if (string.IsNullOrEmpty(token))
				{
					await Signin();
				}
				var response = await client.PostAsync<string>(Settings.GetFlight2BeltURl(), flightArrival, Settings.GetToken());
				if (response == HttpStatusCode.Unauthorized.ToString())
				{
					RenewToken();
					response = await client.PostAsync<string>(Settings.GetFlight2BeltURl(), flightArrival, Settings.GetToken());
				}
				return response;
			}
			catch (Exception ex)
			{
				Logger.Log($"Flight2Belt: {ex.Message}");
				return ex.Message;
			}
		}

		public async Task<string> UpdateLuggageStatus(string FieldName, string FieldValue, string FlightDate, string FlightNo)
		{
			try
			{
				using var client = new HttpClient();
				var luggage = new Luggage()
				{
					FieldName = FieldName,
					FieldValue = FieldValue,
					FlightDate = FlightDate,
					FlightNo = FlightNo
				};
				var response = await client.PostAsync<string>(Settings.GetUpdateLuggageStatusURL(), luggage, Settings.GetToken());
				Logger.Log($"UpdateLuggageStatus - request: {JsonConvert.SerializeObject(response)} - response: {JsonConvert.SerializeObject(response)}");
				var res = JObject.Parse(response);
				return res["message"].ToString();
			}
			catch (Exception ex)
			{
				Logger.Log($"UpdateLuggageStatus: {ex.Message}");
				return ex.Message;
			}
		}

		public async Task<DateTime?> GetServerTime()
		{
			try
			{
				using var client = new HttpClient();
				var response = await client.GetAsync<string>(Settings.GetServerTimeURL(), Settings.GetToken());
				var res = JObject.Parse(response);
				var stringTime = res["serverTime"].ToString();
				var serverTime = DateTimeOffset.Parse(stringTime, CultureInfo.InvariantCulture);
				Logger.Log($"GetServerTime - serverTime: {serverTime.UtcDateTime.AddHours(+7)}");
				return serverTime.UtcDateTime.AddHours(+7);
			}
			catch (Exception ex)
			{
				Logger.Log($"GetServerTime: {ex.Message}");
				return null;
			}
		}
	}
}
