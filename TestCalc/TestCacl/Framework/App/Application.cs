using TestCalc.Framework.Log;
using TestCalc.Framework.Utils;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace TestCalc.Framework.App
{
    public class Application
    {
        public static TestStack.White.Application app;
        public static Window window;

        public static void Launch()
        {
            app = TestStack.White.Application.Launch(GetData.Config.GetValue<string>("pathToApp"));
            Nlog.log.Info($"Launch application {app}");
            Nlog.log.Info($"Get window of application {app}");
            window = app.GetWindow("Калькулятор");
            window.WaitWhileBusy();
        }
        public static UIItem GetElementByName(string name)
        {
            Nlog.log.Info($"Get element by name= {name}");
            return window.Get<Button>(name);
        }
        public static IUIItem GetElementById(string id)
        {
            Nlog.log.Info($"Get element by id= {id}");
            return window.Get(SearchCriteria.ByAutomationId(id));
        }
    }
}
