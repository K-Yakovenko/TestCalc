using TestCalc.Framework.Logger;
using TestStack.White.UIItems;
using TestCalc.Framework.Base;

namespace TestCalc.Framework.BaseElements
{
    public class BaseButton: Element
    {
        public static void ButtonClick(string name)
        {
            LogWriter.LogWrite($"Click {name} button");
            SetApp.window.Get<Button>(name).Click();
        }
    }
}
