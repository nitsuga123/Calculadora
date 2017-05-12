using NUnit.Framework;
using Zenject;

public class CalculatorTest
{
    [Inject]
    private Calculator calculator;

    #region Test functions

    [TestCase("1", "2", false, "3")]
    [TestCase("111", "352", true, "CDLXIII")]
    [TestCase("1312", "DLXXVII", false, "1889")]
    [TestCase("3992", "0", true, "MMMCMXCII")]
    [TestCase("4", "758", false, "762")]
    [TestCase("LIV", "81", true, "CXXXV")]
    [TestCase("32", "324", false, "356")]
    [TestCase("0", "LII", true, "LII")]
    [TestCase("1992", "441", false, "2433")]
    [TestCase("2858", "3003", true, "5861")]
    public void ApplicateSum(string a, string b, bool romanOutpout, string result)
    {
        string outpout = calculator.Sum(a, b, romanOutpout);

        Assert.AreEqual(result, outpout);
    }

    [TestCase("4", "2", false, "2")]
    [TestCase("82", "76", true, "VI")]
    [TestCase("14", "22", false, "-8")]
    [TestCase("1321", "CXX", true, "MCCI")]
    [TestCase("CMIX", "102", false, "807")]
    [TestCase("5004", "327", true, "4677")]
    [TestCase("124", "XXII", false, "102")]
    [TestCase("3224", "XVI", true, "MMMCCVIII")]
    [TestCase("17", "94", false, "-77")]
    [TestCase("385", "III", true, "CCCLXXXII")]
    public void AplicateSubstract(string a, string b, bool romanOutpout, string result)
    {
        string outpout = calculator.Substract(a, b, romanOutpout);

        Assert.AreEqual(result, outpout);
    }

    #endregion
}
