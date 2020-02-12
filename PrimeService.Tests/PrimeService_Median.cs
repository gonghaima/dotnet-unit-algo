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
        public void median_return_correct_result_case_1()
        {
            var result = _primeService.runningMedian(new int[] { 12, 4, 5, 3, 8, 7 });

            Assert.Equal(result, new double[] { 12.0, 8.0, 5.0, 4.5, 5.0, 6.0 });
        }

        [Fact]
        public void median_return_correct_result_case_2()
        {
            var result = _primeService.runningMedian(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            Assert.Equal(new double[] { 1.0, 1.5, 2.0, 2.5, 3.0, 3.5, 4.0, 4.5, 5.0, 5.5 }, result);
        }
    }
}