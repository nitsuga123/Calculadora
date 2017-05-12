using Zenject;

public class Calculator
{
    [Inject]
    private NumberParser parser;

    #region Class functions

    public string Sum(string a, string b, bool romanOutpout)
    {
        int aNumber;
        int bNumber;

        if(!int.TryParse(a, out aNumber))
        {
            aNumber = parser.RomanToArabic(a);
        }

        if(!int.TryParse(b, out bNumber))
        {
            bNumber = parser.RomanToArabic(b);
        }

        int result = Sum(aNumber, bNumber);

        switch (romanOutpout)
        {
            case true:
                if (result > 0 && result < 4000)
                {
                    return parser.ArabicToRoman(result);
                }
                else
                {
                    return result.ToString();
                }

            default:
                return result.ToString();
        }
    }

    public string Substract(string a, string b, bool romanOutpout)
    {
        int aNumber;
        int bNumber;

        if (!int.TryParse(a, out aNumber))
        {
            aNumber = parser.RomanToArabic(a);
        }

        if (!int.TryParse(b, out bNumber))
        {
            bNumber = parser.RomanToArabic(b);
        }

        int result = Substract(aNumber, bNumber);

        switch (romanOutpout)
        {
            case true:
                if (result > 0 && result < 4000)
                {
                    return parser.ArabicToRoman(result);
                }
                else
                {
                    return result.ToString();
                }

            default:
                return result.ToString();
        }
    }

    #endregion

    #region Operation functions

    private int Sum(int a, int b)
    {
        return a + b;
    }

    private int Substract(int a, int b)
    {
        return a - b;
    }

    #endregion
}
