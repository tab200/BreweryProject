using System.Text.Json;

namespace BreweryProject.API
{
    public class BreweryAPI
    {
        public static async Task<List<Brewery>> GetBreweryList(double lat, double lon)
        {
            HttpClient http = new();

            var res = await http.GetStringAsync("https://api.openbrewerydb.org/breweries?by_dist="+ lat + ","+ lon +"");
            if (res != null)
            {
                List<Brewery> jsonResponse = JsonSerializer.Deserialize<List<Brewery>>(res)!;
                jsonResponse.RemoveRange(3, jsonResponse.Count - 3);
                return jsonResponse;
            }
            else
            {
                return new List<Brewery>();
            }
        }
    }
}
