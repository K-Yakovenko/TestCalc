using TestCalc.Framework.Logger;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestCalc.Framework.Base;

namespace TestCalc.Framework.BaseElements
{
    public class Element
    {
        public static IUIItem GetElementById(string id)
        {
            LogWriter.LogWrite($"Get element by id {id}");
            var element = SetApp.window.Get(SearchCriteria.ByAutomationId(id));
            return element;
        }
    }
}
