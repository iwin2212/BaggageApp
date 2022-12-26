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
		System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
		public Form1()
		{
			InitializeComponent();
		}

		private void metroSetLabel2_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			GetData2Form();
			Settings.Initialize();

			timer1.Interval = 60000;
			timer1.Tick += new System.EventHandler(timer1_Tick);
			timer1.Start();
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
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
				foreach (var item in flight)
				{
					if (FLPRow.Controls.Count > 5) break;
					//if (string.IsNullOrEmpty(item.FirstBag) || string.IsNullOrEmpty(item.LastBag))
					{
						var path = Settings.GetImagePath(item.FlightNo.Substring(0, 2));
						var uCRow = new UCRow()
						{
							STD = item.ScheduledTime.Insert(2, ":"),
							ETA = item.EstimatedTime.Insert(2, ":"),
							Airlines = string.IsNullOrEmpty(path) ? null : new Bitmap(path),
							FlightNo = item.FlightNo,
							FlightTo = item.Route,
							Status = (!string.IsNullOrEmpty(item.FirstBag) ? $"FirstBag = {item.FirstBag.Insert(2, ":")}" : "") +
										(!string.IsNullOrEmpty(item.LastBag) ? $" ; LastBag = {item.LastBag.Insert(2, ":")}" : ""),
							Message = (!string.IsNullOrEmpty(item.LastBag) ? $"Cập nhật FirstBag chuyến {item.FlightNo} thành công" : (!string.IsNullOrEmpty(item.FirstBag) ? $"Cập nhật LastBag chuyến {item.FlightNo} thành công" : "")),
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