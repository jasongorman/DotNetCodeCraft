using NUnit.Framework;

namespace Readability.Tests
{
    [TestFixture]
    public class PlaceRepositoryTests
    {
        [Test]
        public void AllocateFlagsPlaceForUser()
        {
            var placeRepository = new Flight();
            var user = new Passenger();
            var place = placeRepository.Allocate("A", 1, user);
            Assert.AreSame(user, place.FlaggedFor);
        }
    }
}
