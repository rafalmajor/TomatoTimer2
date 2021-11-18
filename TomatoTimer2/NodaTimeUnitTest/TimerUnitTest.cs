using System.Timers;
using Xunit;

namespace NodaTimeUnitTest
{
    public class TimerUnitTest
    {
        [Fact]
        public void TimerTest()
        {
            // given
            var timeElapsed = false;
            var timer = new Timer(100);
            timer.Elapsed += (sender, e) => timeElapsed = true;

            // when 
            timer.Start();
            while (!timeElapsed) {}
            
            // then
            Assert.True(timeElapsed);
            timer.Dispose();
        }

    }
}
