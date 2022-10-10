using NUnit.Framework;
using System.Diagnostics;
using TestCalc.Framework.Log;
using Application = TestCalc.Framework.App.Application;

namespace TestCalc.Framework.Base
{
    public class BaseTest
    {
        [SetUp]
        public void Init()
        {
            Process[] processes = Process.GetProcessesByName("calc1");
            if (processes.Length != 0)
            {
                Application.app = TestStack.White.Application.Attach("calc1");
                Nlog.log.Info($"Close application {Application.app}");
                Application.app.Close();
            }
        }

        [TearDown]
        public void Cleanup()
        {
            Nlog.log.Info($"Close application {Application.app}");
            Application.app.Close();
        }
    }
}
