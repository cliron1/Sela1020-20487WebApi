using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using BlueYonder.Flights.Models;

namespace BlueYonder.Flights.Controllers {
	[ApiController]
	[Route("flights")]
	public class FlightsController : ControllerBase {
		private readonly FlightsContext _context;

		public FlightsController(FlightsContext context) {
			_context = context;
		}

		[HttpGet]
		public IEnumerable<Flight> Get() {
			return _context.Flights.ToList();
		}

		[HttpPost]
		//[ApiExplorerSettings(IgnoreApi = true)]
		public IActionResult Post([FromBody] Flight flight) {
			_context.Flights.Add(flight);
			_context.SaveChanges();
			return CreatedAtAction(nameof(Get), flight.Id);
		}
	}
}
