﻿namespace BaggageApp
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
	}
}
