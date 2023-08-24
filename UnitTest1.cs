

namespace TechOneTest;

public class Tests
{

    [SetUp]
    public void Setup()
    {

    }

    
        [Test]
        [TestCase("123.45", "ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS")]
        [TestCase("0.01", "ZERO DOLLAR AND ONE CENT")]
        [TestCase("1000", "ONE THOUSAND DOLLARS")]
        public void TestReturnV(string input, string expected)
        {
            string result = NTW.ReturnV(input);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("123", new string[] { "123" })]
        [TestCase("1234", new string[] { "1", "234" })]
        [TestCase("12345", new string[] { "12", "345" })]
        [TestCase("123456", new string[] { "123", "456" })]

        public void TestSplitInput(string input, string[] expected)
        {
            List<string> result = NTW.SplitInput(input);
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void TestNumberWithLeadingZeros()
        {
            string input = "00123.45";
            string expected = "ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS";
            string result = NTW.ReturnV(input);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("123", "ONE HUNDRED AND TWENTY-THREE")]
        [TestCase("001", "ONE")]
        [TestCase("010", "TEN")]
        [TestCase("100", "ONE HUNDRED")]
        [TestCase("12", "TWELVE")]
        [TestCase("21", "TWENTY-ONE")]
        [TestCase("2", "TWO")]


    public void MainFunction(string input, string expected)
        {
            string result = NTW.MainFunction(input);
            Assert.AreEqual(expected, result);
        }
}

