using System;
using Xunit;

namespace UniTest
{
    public class UnitTest1
    {
        int _localvalue;
        public UnitTest1()
        {
            _localvalue = 9;
        }
        [Fact]
        public void Test1()
        {
            Assert.Equal(9,_localvalue);
        }
    }
}
