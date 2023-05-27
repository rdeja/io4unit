using System;
using Xunit;

namespace XTestRect
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Rect.Rect rect = new Rect.Rect(2, 3);

            var res = rect.Area();

            Assert.Equal(6, res);
        }
    }
}
