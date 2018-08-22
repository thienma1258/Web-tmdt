using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Net;
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
            var a = testa.Substring(startNameIndex, testa.Length - startNameIndex);
            Assert.Equal(9, _localvalue);
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
            var test = Test2();
            Assert.Equal<string>(test, "Test3");
        }
        [Fact]
        public void TestCurrencyFormat()
        {
            var test = Test2();
            decimal money = 9.2m;
            CultureInfo USDCulture = new CultureInfo("en-US");
             string stringMoney=money.ToString("N", USDCulture);
            Assert.Equal(money.ToString(), stringMoney);
        }
        [Fact]
        public void TextSMS()
        {
            using (WebClient client = new WebClient())
            {
                byte[] response = client.UploadValues("http://textbelt.com/text", new NameValueCollection() {
                { "phone", "+84937019527" },
                { "message", "Hello world" },
                { "key", "a2a11b6cd5d73d357bbe6b2cd0b38c1b4b924ee0w7NMOIlMg0We5VQykr5NIg8rI" },
                    });

                string result = System.Text.Encoding.UTF8.GetString(response);
                var test = "";
            }
        }
    }
}
