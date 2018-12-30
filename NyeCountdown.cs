using System;

namespace HelloWorld
{
    public class NyeCountdown
    {
        public TimeSpan GetTimeUntilNye()
        {
            var newYear = new DateTime(2019, 1, 1);
            var untilNewYear = newYear - DateTime.Now;
            return untilNewYear;
        }
    }
}
