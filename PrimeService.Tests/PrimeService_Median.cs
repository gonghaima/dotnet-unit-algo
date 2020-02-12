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
        public void median_return_correct_result()
        {
            var result = _primeService.runningMedian(new int[] { 12, 4, 5, 3, 8, 7 });

            Assert.Equal(result, new double[] { 12.0, 8.0, 5.0, 4.5, 5.0, 6.0 });
        }
    }
}