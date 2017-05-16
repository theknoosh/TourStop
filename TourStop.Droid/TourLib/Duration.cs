﻿using System;
namespace TourLib
{
    public class Duration
    {
		private int TimePerStop = 45; // minutes
		public double CalculateTourDuration(int numberOfStops, double speedRatio)
		{
			var temp = numberOfStops + 5;
			var duration = (numberOfStops * TimePerStop) * speedRatio;
			return duration;
		}
    }
}
