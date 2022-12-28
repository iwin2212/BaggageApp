using System.IO;
using System.Net.NetworkInformation;
using BaggageApp.Extentions;
using BaggageApp.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BaggageApp.Erp
{
	public static class Settings
	{
		public static string GetWsUrl()
		{
			var myIni = new IniFile();
			return myIni.GetValue("Url", "ws", "");
		}

		public static void Initialize()
		{
			var myIni = new IniFile();
			#region url
			if (string.IsNullOrEmpty(myIni.GetValue("Url", "ws", "")))
			{
				myIni.SetValue("Url", "ws", "https://ws.noibaiairport.org");
			}
			#endregion

			#region user
			if (string.IsNullOrEmpty(myIni.GetValue("User", "usr", "")))
			{
				myIni.SetValue("User", "usr", Encryption.Encrypt("bags.api"));
			}
			if (string.IsNullOrEmpty(myIni.GetValue("User", "pwd", "")))
			{
				myIni.SetValue("User", "pwd", Encryption.Encrypt("4sRS!K78_Q0w"));
			}
			#endregion

			#region FlightArrival
			if (string.IsNullOrEmpty(myIni.GetValue("FlightArrival", "terminal", "")))
			{
				myIni.SetValue("FlightArrival", "terminal", "T2");
			}
			if (string.IsNullOrEmpty(myIni.GetValue("FlightArrival", "belt", "")))
			{
				myIni.SetValue("FlightArrival", "belt", "2");
			}
			#endregion
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
			var myIni = new IniFile();
			myIni.SetValue("User", "token", token);
		}

		public static string GetToken()
		{
			var myIni = new IniFile();
			var token = myIni.GetValue("User", "token", "");
			return token;
		}

		public static string GetBelt()
		{
			var myIni = new IniFile();
			return myIni.GetValue("FlightArrival", "belt", "");
		}

		public static string GetTerminal()
		{
			var myIni = new IniFile();
			return myIni.GetValue("FlightArrival", "terminal", "");
		}

		public static string GetUsername()
		{
			var myIni = new IniFile();
			var username = myIni.GetValue("User", "usr", "");
			return Encryption.Decrypt(username);
		}

		public static string GetPassword()
		{
			var myIni = new IniFile();
			var password = myIni.GetValue("User", "pwd", "");
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
			var imagePath = "Stock\\Airlines";

			var path = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
			var debug = Path.GetDirectoryName(path);
			var bin = Path.GetDirectoryName(debug);
			var defaultPath = Path.GetDirectoryName(bin);

			var sourceDir = Path.Combine(defaultPath, imagePath);
			var targetDir = Path.Combine(path, imagePath);

			if (!Directory.Exists(targetDir))
			{
				Copy(sourceDir, targetDir);
			}

			var files = Directory.GetFiles(targetDir);
			foreach (string file in files)
				if (Path.GetFileName(file).Contains(imageName))
				{
					return file;
				}
			return string.Empty;
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
