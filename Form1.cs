using BaggageApp.Entities;
using BaggageApp.Erp;
using BaggageApp.Utils;
using MetroSet_UI.Forms;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;

namespace BaggageApp
{
	public partial class Form1 : MetroSetForm
	{
		System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
		private static readonly string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
		private static readonly string StartupValue = "Luggage";
		public Form1()
		{
			InitializeComponent();
		}
		private void metroSetLabel2_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			SetStartup();
			Settings.Initialize();
			GetData2Form();
			GetTime();

			LblBelt.Text = Settings.GetBelt();

			timer1.Interval = 60000;
			timer1.Tick += new System.EventHandler(timer1_Tick);
			timer1.Start();
		}

		private async Task GetTime()
		{
			var api = new ApiConnection();
			var serverTime = await api.GetServerTime();
			LblServerTime.Text = serverTime?.ToString("dd/MM/yyyy HH:mm");
		}

		private static void SetStartup()
		{
			var key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
			key.SetValue(StartupValue, Application.ExecutablePath.ToString());
			Logger.Log("Set the application to run at startup");
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			GetTime();
			GetData2Form();
		}

		private async Task GetData2Form()
		{
			try
			{
				var api = new ApiConnection();
				var data = await api.Flight2Belt();
				var flight = JObject.Parse(data)["data"].ToObject<Flight[]>();
				if (flight == null) return;
				FLPRow.Controls.Clear();
				var cnt = 0;
				foreach (var item in flight)
				{
					if (FLPRow.Controls.Count > 5) return;
					if (string.IsNullOrEmpty(item.FirstBag) || string.IsNullOrEmpty(item.LastBag))
					{
						var path = Settings.GetImagePath(item.FlightNo.Substring(0, 2));
						var isFirstBag = !string.IsNullOrEmpty(item.FirstBag);
						var isLastBag = !string.IsNullOrEmpty(item.LastBag);
						var uCRow = new UCRow()
						{
							STD = item.ScheduledTime.Insert(2, ":"),
							ETA = item.EstimatedTime.Insert(2, ":"),
							Airlines = string.IsNullOrEmpty(path) ? null : new Bitmap(path),
							FlightNo = item.FlightNo,
							FlightTo = item.Route,
							Status = (isFirstBag ? $"FirstBag = {item.FirstBag.Insert(2, ":")}" : "") +
										(isLastBag ? $" ; LastBag = {item.LastBag.Insert(2, ":")}" : ""),
							Message = (isLastBag ? $"FirstBag chuyến {item.FlightNo} đã cập nhật" : (isFirstBag ? $"LastBag chuyến {item.FlightNo} đã cập nhật" : "")),
							BtnUpdateText = isFirstBag ? "Kết thúc" : "Bắt đầu",
							BtnUpdateDisabled = isLastBag ? false : true,
						};
						uCRow.Width = FLPRow.Width;
						uCRow.Height = FLPRow.Height / (flight.Length);
						if (cnt % 2 == 0) uCRow.tablePanel = Color.FromArgb(67, 63, 63);
						FLPRow.Controls.Add(uCRow);
					}
					cnt++;
				}
			}
			catch (Exception ex)
			{
				Logger.Log($"GetData2Form: {ex.StackTrace}");
				Logger.Log($"GetData2Form: {ex.Message}");
			}
		}

		private void PnlRow_Paint(object sender, PaintEventArgs e)
		{

		}

		private void ETA_Click(object sender, EventArgs e)
		{

		}

		private void metroSetLabel4_Click(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void metroSetLabel1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}