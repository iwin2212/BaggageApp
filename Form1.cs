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
			var api = new ApiConnection();
			var data = await api.Flight2Belt();
			var flight = JObject.Parse(data)["data"].ToObject<Flight[]>();

			foreach (var item in flight)
			{
				var path = Settings.GetImagePath(item.FlightNo.Substring(0, 2));
				var uCRow = new UCRow()
				{
					STD = item.ScheduledTime.Insert(2, ":"),
					ETA = item.EstimatedTime.Insert(2, ":"),
					Airlines = null,
					FlightNo = item.FlightNo,
					FlightTo = item.Route,
				};
				uCRow.Width = FLPRow.Width;
				uCRow.Height = FLPRow.Height / (flight.Length);

				FLPRow.Controls.Add(uCRow);
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