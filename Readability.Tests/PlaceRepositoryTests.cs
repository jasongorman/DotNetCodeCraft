using NUnit.Framework;

namespace Readability.Tests
{
    [TestFixture]
    public class PlaceRepositoryTests
    {
        [Test]
        public void AllocateFlagsPlaceForUser()
        {
            var placeRepository = new PlaceRepository();
            var user = new User();
            var place = placeRepository.Allocate("A", 1, user);
            Assert.AreSame(user, place.FlaggedFor);
        }
    }
}
