namespace BaggageApp.Entities
{
	public class Flight
	{
		public DateTime STD { get; set; }
		public DateTime ETA { get; set; }
		public Image Airlines { get; set; }
		public string FlightNum { get; set; }
		public string FlightTo { get; set; }
	}
}
