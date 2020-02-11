using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [Fact]
        public void hurdleRace_over_Return2()
        {
            var result = _primeService.hurdleRace(4, new int[] { 1, 6, 3, 5, 2 });

            Assert.Equal(result, 2);
        }

        [Fact]
        public void hurdleRace_below_Return0()
        {
            var result = _primeService.hurdleRace(7, new int[] { 2, 5, 4, 5, 2 });

            Assert.Equal(result, 0);
        }
    }
}