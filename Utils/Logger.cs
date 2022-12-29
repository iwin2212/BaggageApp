using System.Reflection;

namespace BaggageApp.Utils
{
	public class Logger
	{
		public static void Log(string message)
		{
			var FolderPath = Path.GetDirectoryName(GetLogPath());
			try
			{
				if (!Directory.Exists(FolderPath))
				{
					Directory.CreateDirectory(FolderPath);
				}
				var isPermitted = DirPermission.SetEveryoneAccess(FolderPath);
				if (isPermitted)
				{
					SaveMessage(message);
				}
			}
			catch (Exception e)
			{
				SaveMessage($"Cannot open log_{DateTime.Now:dd/MM/yyyy}.txt for writing");
				SaveMessage(e.Message);
				return;
			}
		}

		public static void SaveMessage(string mes)
		{
			var path = GetLogPath();

			try
			{
				if (!File.Exists(path))
				{
					using var sw = new StreamWriter(path, true);
					sw.WriteLine($"Create file {DateTime.Now:dd_MM_yyyy}.txt");
				}
				Console.WriteLine($"\n{DateTime.Now} - {mes}");
				File.AppendAllText(path, $"\n{DateTime.Now} - {mes}");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				File.AppendAllText(path, e.Message);
			}
		}

		public static string GetLogPath()
		{
			try
			{
				var exePath = Assembly.GetEntryAssembly().Location;
				var folderPath = Path.GetDirectoryName(exePath);
				return Path.Combine(folderPath, $"log_{DateTime.Now:dd_MM_yyyy}.txt");
			}
			catch
			{
				return string.Empty;
			}
		}
	}
}
