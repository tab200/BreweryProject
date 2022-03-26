using System.Text.Json.Serialization;
using BreweryProject.Interfaces;

namespace BreweryProject
{
    public class Brewery:IDistanceCalculator 
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("brewery_type")]
        public string? BreweryType { get; set; }

        [JsonPropertyName("street")]
        public string? Street { get; set; }

        [JsonPropertyName("address_2")]
        public string? Address2 { get; set; }

        [JsonPropertyName("address_3")]
        public string? Addreess3 { get; set; }

        [JsonPropertyName("city")]
        public string? City { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }

        [JsonPropertyName("county_province")]
        public string? CountyProvince { get; set; }

        [JsonPropertyName("postal_code")]
        public string? PostalCode { get; set; }

        [JsonPropertyName("country")]
        public string? Country { get; set; }

        [JsonPropertyName("longitude")]
        public string? Longitude { get; set; }

        [JsonPropertyName("latitude")]
        public string? Latitude { get; set; }

        [JsonPropertyName("phone")]
        public string? Phone { get; set; }

        [JsonPropertyName("website_url")]
        public string? WebsiteUrl { get; set; }

        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }


        public double GetDistance(double lat1, double lon1, double lat2, double lon2)
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
