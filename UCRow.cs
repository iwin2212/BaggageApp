using BaggageApp.Erp;
using BaggageApp.Utils;

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
			set { LblSTD.Text = value; LblSTD.ForeColor = Color.White; }
		}
		public string ETA
		{
			get { return LblETA.Text; }
			set { LblETA.Text = value; LblETA.ForeColor = Color.Gold; }
		}
		public Image Airlines
		{
			get { return PbAirlines.Image; }
			set { PbAirlines.Image = value; }
		}
		public string FlightNo
		{
			get { return LblFlightNo.Text; }
			set { LblFlightNo.Text = value; LblFlightNo.ForeColor = Color.White; }
		}
		public string FlightTo
		{
			get { return LblFlightTo.Text; }
			set { LblFlightTo.Text = value; LblFlightTo.ForeColor = Color.White; }
		}
		public string Status
		{
			get { return LblStatus.Text; }
			set { LblStatus.Text = value; }
		}
		public string Message
		{
			get { return LblMessage.Text; }
			set { LblMessage.Text = value; }
		}
		public string BtnUpdateText
		{
			get { return BtnUpdate.Text; }
			set { BtnUpdate.Text = value; }
		}
		public bool BtnUpdateDisabled
		{
			get { return BtnUpdate.Enabled; }
			set { BtnUpdate.Enabled = value; BtnUpdate.BackColor = value ? Color.DodgerBlue : Color.Silver; }
		}

		public Color tablePanel
		{
			get { return tableLayoutPanel1.BackColor; }
			set { tableLayoutPanel1.BackColor = value; }
		}
		private async void BtnUpdate_Click(object sender, EventArgs e)
		{
			var FlightNo = LblFlightNo.Text;
			var api = new ApiConnection();
			var now = await api?.GetServerTime();
			var s = (sender as Button).Text;

			Logger.Log($"Flight2Belt - BtnUpdate_Click: {FlightNo} {s}");

			if (s == "Bắt đầu")
			{
				var firstBagResult = await api.UpdateLuggageStatus("FirstBag", now?.ToString("HH:mm"),
																							now?.ToString("yyyy-MM-dd"), FlightNo);
				LblMessage.Text = firstBagResult;
				BtnUpdateText = "Kết thúc";
			}
			else
			{
				var lastBagResult = await api.UpdateLuggageStatus("LastBag", now?.ToString("HH:mm"),
																							now?.ToString("yyyy-MM-dd"), FlightNo);
				LblMessage.Text = lastBagResult;
				BtnUpdateDisabled = false;
			}
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
