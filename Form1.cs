using System.Data;
using BaggageApp.Entities;
using BaggageApp.Erp;
using BaggageApp.Models;
using MetroSet_UI.Forms;
using Newtonsoft.Json.Linq;

namespace BaggageApp
{
	public partial class Form1 : MetroSetForm
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void metroSetLabel2_Click(object sender, EventArgs e)
		{

		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			Settings.Initialize();
			while (true)
			{
				await GetData2Form();
				Task.Delay(TimeSpan.FromSeconds(30)).Wait();
			}
		}
		private async Task GetData2Form()
		{
			try
			{
				var api = new ApiConnection();
				var data = await api.Flight2Belt();
				var flight = JObject.Parse(data)["data"].ToObject<Flight[]>();
				if (flight == null) return;
				foreach (var item in flight)
				{
					if (string.IsNullOrEmpty(item.FirstBag) || string.IsNullOrEmpty(item.LastBag))
					{
						var path = Settings.GetImagePath(item.FlightNo.Substring(0, 2));
						var uCRow = new UCRow()
						{
							STD = item.ScheduledTime.Insert(2, ":"),
							ETA = item.EstimatedTime.Insert(2, ":"),
							Airlines = string.IsNullOrEmpty(path) ? null : new Bitmap(path),
							FlightNo = item.FlightNo,
							FlightTo = item.Route,
							Status = (!string.IsNullOrEmpty(item.FirstBag) ? $"FirstBag = {item.FirstBag}" : "") +
										(!string.IsNullOrEmpty(item.FirstBag) ? $"LastBag = {item.LastBag}" : "")
						};
						uCRow.Width = FLPRow.Width;
						uCRow.Height = FLPRow.Height / (flight.Length);

						FLPRow.Controls.Add(uCRow);
					}
				}
			}
			catch (Exception ex)
			{

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
	}
}