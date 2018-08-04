using System;
using System.Diagnostics;
using System.Reflection;
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
            var testa = "~/abc/asd.jpg";
            int startNameIndex = testa.LastIndexOf('/');
            var a=testa.Substring(startNameIndex,testa.Length-startNameIndex);
            Assert.Equal(9,_localvalue);
        }
        public string Test2()
        {
            StackTrace stackTrace = new StackTrace();

            var test = stackTrace.GetFrame(1).GetMethod().Name;
            return test;
        }
        [Fact]
        public void Test3()
        {
           var test= Test2();
            Assert.Equal<string>(test,"Test3");
        }
    }
}
