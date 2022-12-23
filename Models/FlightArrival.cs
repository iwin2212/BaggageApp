using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaggageApp.Models
{
	public class FlightArrival
	{
		public DateTime FromDate { get; set; }
		public DateTime ToDate { get; set; }
		public string Terminal { get; set; }
		public string ArrDep { get; set; }
		public string Belt { get; set; }
	}
}
