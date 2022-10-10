using TestCalc.Framework.App;

namespace TestCalc.Test.Screens
{
    public class CalcWindow
    {
        private string plusButtonId = "93";
        private string equalButtonId = "121";
        private string remebmerResultButtonId = "125";
        private string getRememberedNumberButtonId = "123";

        public void EnterNumber(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                Application.GetElementByName(num[i].ToString()).Click();
            }
        }
        public void PlusButtonClick() => Application.GetElementById(plusButtonId).Click();
        public void EqualButtonClick() => Application.GetElementById(equalButtonId).Click();
        public void RememberResultButtonClick() => Application.GetElementById(remebmerResultButtonId).Click();
        public void GetRememberedNumberButtonClick() => Application.GetElementById(getRememberedNumberButtonId).Click();

        public string GetResult() => Application.GetElementById("150").Name.ToString();
    }
}
