using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class CalculatorUI: MonoBehaviour
{
    #region Properties

    private string aNumber;
    private string bNumber;

    [SerializeField]
    private Text result;

    [Inject]
    private Calculator calculator;

    //Hidden
    private bool romanOutpout;

    #endregion

    #region Buttons functions

    public void Sum()
    {
        UpdateResultField(calculator.Sum(aNumber, bNumber, romanOutpout));
    }

    public void Substract()
    {
        UpdateResultField(calculator.Substract(aNumber, bNumber, romanOutpout));
    }

    public void ANumber(string aNumber)
    {
        this.aNumber = aNumber;
    }

    public void BNumber(string bNumber)
    {
        this.bNumber = bNumber;
    }

    public void RomanOutpout(bool romanOutpout)
    {
        this.romanOutpout = romanOutpout;
    }

    private void UpdateResultField(string resultValue)
    {
        result.text = resultValue;
    }

    #endregion
}
