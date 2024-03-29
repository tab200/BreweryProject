using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreweryProject;
using BreweryProject.Models;

namespace BreweryProjectTests
{
    [TestClass]
    public class BreweryTests
    {
        [TestMethod]
        public void GetDistance_returns_rounded_number()
        {
            DistanceGetter distance = new();

            double lat1 = 40.8121958;
            double lon1 = -77.8561023;

            double lat2 = 40.7977695;
            double lon2 = -77.8742944;

            //Known Good Math
            Assert.AreEqual(distance.GetDistanceMiles(lat1, lon1, lat2, lon2), 1.38);
        }
    }
}