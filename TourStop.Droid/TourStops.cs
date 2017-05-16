using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TourLib {
	public class TourSource {
		private static List<TourStop> _tourStops;
		 static TourSource() {
			// stops for our Food and Fun park tour
			_tourStops = new List<TourStop>();
			_tourStops.Add(new TourStop
			{
				StopNumber = 1,
				Name = "Coffee at Paddington's Pastries",
				Latitude = "41.875893",
				Longitude = "-87.624567",
				Phone = "555-8239",
				Description = "Start the morning with a jolt of coffee goodness from this trendy shop. Don't miss the Caramel Crater pastry, guaranteed to amp up your morning carb count."

			});

			_tourStops.Add(new TourStop
			{
				StopNumber = 2,
				Name = "Buckingham Fountain",
				Latitude = "41.876054",
				Longitude = "-87.618835",
				Phone="555-3214",
				Description = "Buckingham Fountain is a Chicago landmark and one of the largest in the world. While in operation, the Fountain produces a major water display for 20 minutes every hour.   During the major display, a center jet shoots water to a height of 150 feet into the air. "

			});

			_tourStops.Add(new TourStop
			{
				StopNumber = 3,
				Name = "Art Institute of Chicago",
				Latitude = "41.867345",
				Longitude = "-87.628414",
				Phone = "555-9115",
				Description = "The Art Institute of Chicago is an art museum located in Chicago's Grant Park. It features a collection of Impressionist and Post-Impressionist art in its permanent collection."

			});

			_tourStops.Add(new TourStop
			{
				StopNumber = 4,
				Name = "Lunch at Zekki's",
				Latitude = "41.880606",
				Longitude = "-87.625324",
				Phone = "555-2661",
				Description = "On a good day, Chef Mandro Zekki spins a fantastic lunch scene in her signature café. On a great day you'll swoon over the impeccable lunch entries. Try the Sea Dragon Salad or the Scarlet Blossom Penne"

			});

			_tourStops.Add(new TourStop
			{
				StopNumber = 5,
				Name = "Cloud Gate Sculpture",
				Latitude = "41.882557",
				Longitude = "-87.623383",
				Phone = "555-1144",
				Description = "The iconic Cloud Gate sculpture is a delight for kids and adults alike. Its design was inspired by liquid mercury and the sculpture's surface reflects and distorts the city's skyline. Visitors are able to walk around and under Cloud Gate's high arch."

			});

			_tourStops.Add(new TourStop
			{
				StopNumber = 6,
				Name = "Lurie Garden",
				Latitude = "41.881436",
				Longitude = "-87.621796",
				Phone = "555-4990",
				Description = "Lurie Garden is a 2.5-acre (10,000 m2) garden containing a combination of perennials, bulbs, grasses, shrubs and trees. It is the featured nature component of the world's largest green roof."

			});

			_tourStops.Add(new TourStop
			{
				StopNumber = 7,
				Name = "Pretzels at The Braid Line",
				Latitude = "41.884249",
				Longitude = "-87.624182",
				Phone = "555-0098",
				Description = "Sidle up to this open air pretzel bakery and marvel at the creative knots on display. Served with nearly 100 distinct mustard dipping sauces, you've never seen or tasted pretzels like these."

			});

			_tourStops.Add(new TourStop
			{
				StopNumber = 8,
				Name = "Crown Fountain",
				Latitude = "41.876054",
				Longitude = "-87.618835",
				Phone = "555-5325",
				Description = "Crown Fountain is an interactive video sculpture/monument featuring a playful water stream."

			});
		}
		public static List<TourStop> GetTourStops(int count) {
			var result = _tourStops.Take(count).ToList<TourStop>();
			return result;
		}
			public static List<TourStop> TourStops { get {
				return _tourStops;
			} } 
	}

	
	public class TourStop {
		public int StopNumber { get; set; }
		public string Name { get; set; }
		public string Latitude { get; set; }
		public string Longitude { get; set; }
		public string Description { get; set; }
		public string Phone { get; set; }
	}
}