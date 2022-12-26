using BaggageApp.Erp;

namespace BaggageApp
{
	public partial class UCRow : UserControl
	{
		public UCRow()
		{
			InitializeComponent();
		}

		public string STD
		{
			get { return LblSTD.Text; }
			set { LblSTD.Text = value; }
		}
		public string ETA
		{
			get { return LblETA.Text; }
			set { LblETA.Text = value; }
		}
		public Image Airlines
		{
			get { return PbAirlines.Image; }
			set { PbAirlines.Image = value; }
		}
		public string FlightNo
		{
			get { return LblFlightNo.Text; }
			set { LblFlightNo.Text = value; }
		}
		public string FlightTo
		{
			get { return LblFlightTo.Text; }
			set { LblFlightTo.Text = value; }
		}
		public string Status
		{
			get { return LblStatus.Text; }
			set { LblStatus.Text = value; }
		}

		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			var FlightNo = LblFlightNo.Text;
			var api = new ApiConnection();
			var status = LblStatus.Text.Split(';');
			var firstBag = status[0].Split('=')[1].Trim();
			var lastBag = status[1].Split('=')[1].Trim();
			if (string.IsNullOrEmpty(firstBag))
			{
				var firstBagResult = api.UpdateLuggageStatus("FirstBag", DateTime.Now.AddDays(-1).ToString("HH:mm"), DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"), FlightNo);
			}
			else if(string.IsNullOrEmpty(lastBag))
			{
				var lastBagResult = api.UpdateLuggageStatus("LastBag", DateTime.Now.AddDays(-1).ToString("HH:mm"), DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"), FlightNo);
			}
		}
	}
}
