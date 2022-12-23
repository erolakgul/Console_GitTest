using Console_GitTest.StringHelper;
using NUnit.Framework;
using System.Collections.Generic;

namespace Console_GitTest.Test
{
    [TestFixture]
    public class StringTests
    {
        private TestContext testContextInstance;
        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        //[SetUp]
        //public void Setup()
        //{

        //}


        [Test]
        public void Check_IntToRoman_WhenExecuted()
        {
            Dictionary<string, int> _responseDictionary = new();

            _responseDictionary.Add("III", 3);
            _responseDictionary.Add("LVIII", 58);
            _responseDictionary.Add("MCMXCIV", 1994);

            bool response = false;
            int _falseCount = 0;

            foreach (var item in _responseDictionary)
            {
                #region  Arrange
                string _responseExpected = item.Key;
                string _responseRoman = StringManipulation.IntToRoman(item.Value); //1994
                #endregion

                #region act
                response = (_responseRoman == _responseExpected) ? true : false;
                _falseCount = (response == false) ? _falseCount + 1 : _falseCount;
                #endregion

                TestContext.WriteLine($"Beklenen    : {_responseExpected}\nGelen Cevap : {_responseRoman}");
                string result = (response) ? "Başarılı" : "Başarısız";
                TestContext.WriteLine($"Sonuç       : {result}");
            }
            TestContext.WriteLine("*************************************");
            TestContext.WriteLine($"Hatalı Kayıt Sayısı : {_falseCount}");

            #region assert
            Assert.AreEqual(_falseCount, 0);
            //Assert.AreNotSame(connectionSettings.PortNumber, connectionSettings.MaxCountQueue);
            #endregion
        }

    }
}
