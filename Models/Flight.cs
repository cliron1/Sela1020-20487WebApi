using System;
using System.ComponentModel.DataAnnotations;

namespace BlueYonder.Flights.Models {
	public class Flight {
		public int Id { get; set; }

		[Required]
		public string Origin { get; set; }

		[Required]
		public string Destination { get; set; }

		public string FlightNumber { get; set; }

		public DateTime DepartureTime { get; set; }
	}
}