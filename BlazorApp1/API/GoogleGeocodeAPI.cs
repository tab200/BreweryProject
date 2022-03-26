using BreweryProject.Models;
using System.Text.Json;

namespace BreweryProject.API
{
    public class GoogleGeocodeAPI
    {
        public static async Task<StartLocation> GetLocationInformation(string location)
        {
            HttpClient http = new();

            var res = await http.GetStringAsync("https://maps.googleapis.com/maps/api/geocode/json?address="+ location +"&key=AIzaSyAzYRtkwpsloCxCXFnVTxS-roVsd0ecaMA");
            if (res != null)
            {
                StartLocation loc = JsonSerializer.Deserialize<StartLocation>(res)!;
                return loc;
            }
            else
            {
                return new StartLocation();
            }
        }

        public static double GetLat(StartLocation startLocation)
        {
            return startLocation.Results[0].Geometry.Location.Lat;         
        }

        public static double GetLon(StartLocation startLocation)
        {
            return startLocation.Results[0].Geometry.Location.Lng;
        }

    }
}
