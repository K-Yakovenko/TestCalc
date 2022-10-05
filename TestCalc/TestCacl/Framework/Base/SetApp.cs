using NUnit.Framework;
using System.Diagnostics;
using TestCalc.Framework.Utils;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace TestCalc.Framework.Base
{
    public class SetApp
    {
        public static Application app;
        public static Window window;

        [SetUp]
        public void Init()
        {
            Process[] processes = Process.GetProcessesByName("calc1");
            if (processes.Length != 0)
            {
                app = Application.Attach("calc1");
                app.Close();
            }
        }

        public void Launch()
        {
            app = Application.Launch(GetData.Config.GetValue<string>("pathToApp"));
            window = app.GetWindow("Калькулятор");
            window.WaitWhileBusy();
        }

        [TearDown]
        public void Cleanup()
        {
            app.Close();
        }
    }
}
