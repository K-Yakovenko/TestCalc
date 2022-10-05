using TestCalc.Framework.BaseElements;

namespace TestCalc.Test.Screens
{
    public class CalcWindow
    {
        public void EnterNumber(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                BaseButton.ButtonClick(num[i].ToString());
            }
        }
        public void ClickButton(string name) => BaseButton.ButtonClick(name);
        public string GetResult() => Element.GetElementById("150").Name.ToString();
    }
}
