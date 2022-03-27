using BreweryProject.Interfaces;

namespace BreweryProject.Models
{
    public class DistanceGetter:IDistanceCalculator
    {
        public double GetDistanceMiles(double lat1, double lon1, double lat2, double lon2)
        {
            //Haversine - Distance
            //https://www.geodatasource.com/developers/c-sharp
            //https://www.vcalc.com/wiki/vCalc/Haversine+-+Distance

            if ((lat1 == lat2) && (lon1 == lon2))
            {
                return 0;
            }
            else
            {
                double theta = lon1 - lon2;
                double dist = Math.Sin(degToRad(lat1)) * Math.Sin(degToRad(lat2)) + Math.Cos(degToRad(lat1)) * Math.Cos(degToRad(lat2)) * Math.Cos(degToRad(theta));
                dist = Math.Acos(dist);
                dist = radToDeg(dist);
                dist = dist * 60 * 1.1515;
                return (Math.Round(dist, 2));
            }

            //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
            //::  This function converts decimal degrees to radians             :::
            //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
            double degToRad(double deg)
            {
                return (deg * Math.PI / 180.0);
            }

            //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
            //::  This function converts radians to decimal degrees             :::
            //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
            double radToDeg(double rad)
            {
                return (rad / Math.PI * 180.0);
            }

        }

    }
}
