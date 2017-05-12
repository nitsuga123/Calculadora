using NUnit.Framework;
using Zenject;

public class NumberParserTest 
{
    [Inject]
    private NumberParser parser;

    #region Test functions

    [TestCase(10, "X")]
    [TestCase(100, "C")]
    [TestCase(9, "IX")]
    [TestCase(1969, "MCMLXIX")]
    [TestCase(512, "DXII")]
    public void ParsesArabicNumber(int input, string result)
    {
        string outpout = parser.ArabicToRoman(input);

        Assert.AreEqual(result, outpout);
    }

    [TestCase("IV", 4)]
    [TestCase("MCMXIII", 1913)]
    [TestCase("MXXIV", 1024)]
    [TestCase("LII", 52)]
    [TestCase("CCCXCV", 395)]
    public void ParsesRomanNumber(string input, int result)
    {
        int outpout = parser.RomanToArabic(input);

        Assert.AreEqual(result, outpout);
    }

    #endregion
}
