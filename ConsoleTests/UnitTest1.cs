using System;
using Xunit;

namespace ConsoleTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            Assert.True(false);
        }
    }
}
