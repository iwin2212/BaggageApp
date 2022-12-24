using System.Net.NetworkInformation;
using BaggageApp.Extentions;
using BaggageApp.Utils;

namespace BaggageApp.Erp
{
	public static class Settings
	{
		public static string GetWsUrl()
		{
			var myIni = new IniFile();
			return myIni.Read("ws", "Url");
		}
		public static string GetApiUrl()
		{
			var myIni = new IniFile();
			return myIni.Read("api", "Url");
		}

		public static void Initialize()
		{
			var myIni = new IniFile();
			#region url
			myIni.Write("ws", "https://ws.noibaiairport.org", "Url");
			myIni.Write("api", "http://api.noibaiairport.org", "Url");
			#endregion

			#region user
			myIni.Write("usr", Encryption.Encrypt("bags.api"), "User");
			myIni.Write("pwd", Encryption.Encrypt("4sRS!K78_Q0w"), "User");
			#endregion

			#region FlightArrival
			myIni.Write("belt", "1", "FlightArrival");
			#endregion
		}

		public static string GetMacAddress()
		{
			foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
			{
				// Only consider Ethernet network interfaces
				if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
					nic.OperationalStatus == OperationalStatus.Up)
				{
					return nic.GetPhysicalAddress().ToString();
				}
			}
			return string.Empty;
		}

		public static string GetUsername()
		{
			var myIni = new IniFile();
			var username = myIni.Read("usr", "User");
			return Encryption.Decrypt(username);
		}

		public static string GetPassword()
		{
			var myIni = new IniFile();
			var password = myIni.Read("pwd", "User");
			return Encryption.Decrypt(password);
		}

		public static string GetSignInURL()
		{
			return $"{GetWsUrl()}/MobileSignIn";
		}
		public static string GetFlight2BeltURl()
		{
			return $"{GetWsUrl()}/FlightArrival/FlightByBelt";
		}
		public static string GetUpdateLuggageStatusURL()
		{
			return $"{GetApiUrl()}/FlightArrival/FlightByBelt";
		}
	}
}
