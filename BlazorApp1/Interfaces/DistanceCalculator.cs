﻿namespace BreweryProject.Interfaces
{
    public interface IDistanceCalculator
    {
        double GetDistance(double lat1, double lon1, double lat2, double lon2);
    }

}
