using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace SummatorTests
{
    public class Tests
    {
        [Test]
        [Category("Sum")]
        public void SumTwoPositiveIntegers()
        {
            int[] arr =  {1, 2};            
            int sum = SummatorSource.Summator.Sum(arr);
            Assert.That(sum, Is.EqualTo(3));                
        }

        [Test]
        [Category("Sum")]
        public void SumIntegersInEmptyArr()
        {
            int[] arr = new int[5];
            int sum = SummatorSource.Summator.Sum(arr);
            Assert.AreEqual(0, sum); 
        }

        [Test]
        [Category("Sum")]
        public void SumPositiveAndNegativeIntegers()
        {
            int[] arr = { 3, 12, -8};
            int sum = SummatorSource.Summator.Sum(arr);

            Assert.GreaterOrEqual(6, sum);
        }

        [Test]
        [Category("Sum")]

        public  void SumPositiveIntegersAndZero()
        {
            int[] arr = { 3, 8, 5, 0 };
            int expectedSum = 16;
            int actualSum = SummatorSource.Summator.Sum(arr);
            Assert.That(expectedSum, Is.EqualTo(actualSum));

        }
    }
}