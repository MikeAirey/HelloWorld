using NUnit.Framework;

namespace HelloWorld.Test
{
    [TestFixture]
    public class NyeCountdownTests
    {
        [Test]
        public void TimeUntilNyeShouldNotBeNegative()
        {
            var sut = new NyeCountdown();
            var result = sut.GetTimeUntilNye();
            Assert.That(result.TotalSeconds, Is.GreaterThanOrEqualTo(0), nameof(result.TotalSeconds));
        }
    }
}
