using System.Net.NetworkInformation;
using System.Reflection;
using BaggageApp.Extentions;
using BaggageApp.Models;
using BaggageApp.Utils;
using Newtonsoft.Json.Linq;

namespace BaggageApp.Erp
{
	public static class Settings
	{
		private static string ws = "https://ws.noibaiairport.org";
		private static string usr = "bags.api";
		private static string pwd = "4sRS!K78_Q0w";
		private static string terminal = "T2";
		private static string belt = "1";

		public static string GetWsUrl()
		{
			var myIni = new IniFile(GetSettingPath());;
			return myIni.GetValue("Url", "ws", ws);
		}

		public static void Initialize()
		{
			try
			{
				var myIni = new IniFile(GetSettingPath());
				#region url
				if (string.IsNullOrEmpty(myIni.GetValue("Url", "ws", "")))
				{
					myIni.SetValue("Url", "ws", ws);
				}
				#endregion

				#region user
				if (string.IsNullOrEmpty(myIni.GetValue("User", "usr", "")))
				{
					myIni.SetValue("User", "usr", Encryption.Encrypt(usr));
				}
				if (string.IsNullOrEmpty(myIni.GetValue("User", "pwd", "")))
				{
					myIni.SetValue("User", "pwd", Encryption.Encrypt(pwd));
				}
				#endregion

				#region FlightArrival
				if (string.IsNullOrEmpty(myIni.GetValue("FlightArrival", "terminal", "")))
				{
					myIni.SetValue("FlightArrival", "terminal", terminal);
				}
				if (string.IsNullOrEmpty(myIni.GetValue("FlightArrival", "belt", "")))
				{
					myIni.SetValue("FlightArrival", "belt", belt);
				}
				#endregion
			}
			catch (Exception ex)
			{
				Logger.Log($"Initialize: {ex.Message}");
			}
		}
		public static string GetSettingPath()
		{
			try
			{
				var folderPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
				var exe = Assembly.GetExecutingAssembly().GetName().Name + ".ini";
				var path = Path.Combine(folderPath, exe);
				return path;
			}
			catch
			{
				return string.Empty;
			}
		}

		public static string GetMacAddress()
		{
			foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
			{
				if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
					nic.OperationalStatus == OperationalStatus.Up)
				{
					return nic.GetPhysicalAddress().ToString();
				}
			}
			return string.Empty;
		}

		public static void SaveToken(string token)
		{
			var myIni = new IniFile(GetSettingPath());;
			myIni.SetValue("User", "token", token);
		}

		public static string GetToken()
		{
			var myIni = new IniFile(GetSettingPath());;
			var token = myIni.GetValue("User", "token", "");
			return token;
		}

		public static string GetBelt()
		{
			var myIni = new IniFile(GetSettingPath());;
			return myIni.GetValue("FlightArrival", "belt", belt);
		}

		public static string GetTerminal()
		{
			var myIni = new IniFile(GetSettingPath());;
			return myIni.GetValue("FlightArrival", "terminal", terminal);
		}

		public static string GetUsername()
		{
			var myIni = new IniFile(GetSettingPath());;
			var username = myIni.GetValue("User", "usr", Encryption.Encrypt(usr));
			return Encryption.Decrypt(username);
		}

		public static string GetPassword()
		{
			var myIni = new IniFile(GetSettingPath());;
			var password = myIni.GetValue("User", "pwd", Encryption.Encrypt(pwd));
			return Encryption.Decrypt(password);
		}

		public static string GetSignInURL()
		{
			return $"{GetWsUrl()}/MobileSignIn";
		}

		public static string GetRenewTokenURL()
		{
			return $"{GetWsUrl()}/RenewToken";
		}
		public static string GetFlight2BeltURl()
		{
			return $"{GetWsUrl()}/FlightArrival/FlightByBelt";
		}
		public static string GetUpdateLuggageStatusURL()
		{
			return $"{GetWsUrl()}/WSSMIS8011";
		}
		public static string GetServerTimeURL()
		{
			return $"{GetWsUrl()}/ServerTime";
		}

		public static string GetImagePath(string imageName)
		{
			try
			{
				var imagePath = "Stock\\Airlines";

				var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

				var files = Directory.GetFiles(Path.Combine(path, imagePath));
				foreach (string file in files)
					if (Path.GetFileName(file).Contains(imageName))
					{
						return file;
					}
				return string.Empty;
			}
			catch (Exception ex)
			{
				Logger.Log($"GetImagePath: {ex.Message}");
				return string.Empty;
			}
		}
		private static void Copy(string sourceDir, string targetDir)
		{
			if (!Directory.Exists(targetDir))
			{
				Directory.CreateDirectory(targetDir);
			}
			foreach (var file in Directory.GetFiles(sourceDir))
				File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)));

			foreach (var directory in Directory.GetDirectories(sourceDir))
				Copy(directory, Path.Combine(targetDir, Path.GetFileName(directory)));
		}
	}
}
