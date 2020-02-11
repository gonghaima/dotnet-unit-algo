using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_Median
    {
        private readonly PrimeService _primeService;

        public PrimeService_Median()
        {
            _primeService = new PrimeService();
        }

        [Fact]
        public void hurdleRace_over_Return2()
        {
            var result = _primeService.runningMedian(4, new int[] { 1, 6, 3, 5, 2 });

            Assert.Equal(result, 100);
        }
    }
}