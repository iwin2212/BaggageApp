﻿using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Cryptography.Xml;
using BaggageApp.Entities;
using BaggageApp.Extentions;
using BaggageApp.Models;
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
				return ex.Message;
			}
		}

		public async Task<string> Flight2Belt()
		{
			try
			{
				using var client = new HttpClient();
				var flightArrival = new FlightArrival()
				{
					FromDate = DateTime.Now.AddDays(-1).AddHours(-5),
					ToDate = DateTime.Now.AddDays(-1).AddHours(+5),
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
				if (response == HttpStatusCode.Unauthorized.ToString())
				{
					RenewToken();
					response = await client.PostAsync<string>(Settings.GetFlight2BeltURl(), flightArrival, Settings.GetToken());
				}
				return response;
			}
			catch (Exception ex) { return ex.Message; }
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
				var res = JObject.Parse(response);
				if (res["success"].ToString() == "false")
				{
					return res["message"].ToString();
				}
				else
				{
					return string.Empty;
				}
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
