using System.Text.Json.Serialization;
using BreweryProject.Interfaces;

namespace BreweryProject
{
    public class Brewery 
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
    }
}
