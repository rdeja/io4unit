using System;
using Xunit;
using Rect;

namespace XTestRect
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Rect rect = new Rect(2, 3);

            var res = rect.Area();

            Assert.Equal(5, res);
        }
    }
}
