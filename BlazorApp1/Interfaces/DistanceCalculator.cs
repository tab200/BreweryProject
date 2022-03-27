namespace BreweryProject.Interfaces
{
    public interface IDistanceCalculator
    {
        double GetDistanceMiles(double lat1, double lon1, double lat2, double lon2);
    }

}
