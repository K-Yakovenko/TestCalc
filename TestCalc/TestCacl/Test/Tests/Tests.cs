using NUnit.Framework;
using TestCalc.Test.Screens;
using TestCalc.Framework.Base;
using TestCalc.Framework.Utils;
using TestCalc.Framework.App;

namespace TestCalc.Test.Tests
{
    [TestFixture]
    public class Tests: BaseTest
    {
        private readonly CalcWindow calc = new CalcWindow();
        [Test]
        public void TestCase()
        {
            Application.Launch();
            Assert.IsNotNull(Application.app, "Application isn't open");
            calc.EnterNumber(GetData.TestData.GetValue<string>("num12"));
            calc.PlusButtonClick();
            calc.EnterNumber(GetData.TestData.GetValue<string>("num999"));
            calc.EqualButtonClick();
            calc.RememberResultButtonClick();
            calc.EnterNumber(GetData.TestData.GetValue<string>("num19"));
            calc.PlusButtonClick();
            calc.GetRememberedNumberButtonClick();
            calc.EqualButtonClick();
            Assert.AreEqual(GetData.TestData.GetValue<string>("result"), calc.GetResult(), "Results are not the same");
        }
    }
}