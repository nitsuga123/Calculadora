using System;
using System.Collections.Generic;

public class NumberParser 
{
    #region Class functions

    public string ArabicToRoman(int arabicNumber)
    {
        if (arabicNumber < 1 || arabicNumber > 3999) throw new Exception("Number is too big");

        String romanNumber = "";

        while (arabicNumber >= 1000)
        {
            romanNumber += "M";
            arabicNumber -= 1000;
        }

        while (arabicNumber >= 900)
        {
            romanNumber += "CM";
            arabicNumber -= 900;
        }

        while (arabicNumber >= 500)
        {
            romanNumber += "D";
            arabicNumber -= 500;
        }

        while (arabicNumber >= 400)
        {
            romanNumber += "CD";
            arabicNumber -= 400;
        }

        while (arabicNumber >= 100)
        {
            romanNumber += "C";
            arabicNumber -= 100;
        }

        while (arabicNumber >= 90)
        {
            romanNumber += "XC";
            arabicNumber -= 90;
        }

        while (arabicNumber >= 50)
        {
            romanNumber += "L";
            arabicNumber -= 50;
        }

        while (arabicNumber >= 40)
        {
            romanNumber += "XL";
            arabicNumber -= 40;
        }

        while (arabicNumber >= 10)
        {
            romanNumber += "X";
            arabicNumber -= 10;
        }

        while (arabicNumber >= 9)
        {
            romanNumber += "IX";
            arabicNumber -= 9;
        }

        while (arabicNumber >= 5)
        {
            romanNumber += "V";
            arabicNumber -= 5;
        }

        while (arabicNumber >= 4)
        {
            romanNumber += "IV";
            arabicNumber -= 4;
        }

        while (arabicNumber >= 1)
        {
            romanNumber += "I";
            arabicNumber -= 1;
        }

        return romanNumber;
    }

    public int RomanToArabic(string romanNumber)
    {
        int arabicNumber = 0;

        Dictionary<char, int> romanNumbers = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        for (int i = 0; i < romanNumber.Length; i++)
        {
            if (i + 1 < romanNumber.Length && romanNumbers[romanNumber[i]] < romanNumbers[romanNumber[i + 1]])
            {
                arabicNumber -= romanNumbers[romanNumber[i]];
            }
            else
            {
                arabicNumber += romanNumbers[romanNumber[i]];
            }
        }

        return arabicNumber;
    }

    #endregion
}
