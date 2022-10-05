using NUnit.Framework;
using TestCalc.Test.Screens;
using TestCalc.Framework.Base;
using TestCalc.Framework.Utils;

namespace TestCalc.Test.Tests
{
    [TestFixture]
    public class Tests : SetApp
    {
        private readonly CalcWindow calc = new CalcWindow();
        [Test]
        public void TestCase()
        {
            Launch();
            Assert.IsNotNull(app, "Application isn't open");
            calc.EnterNumber(GetData.TestData.GetValue<string>("num12"));
            calc.ClickButton("Сложение");
            calc.EnterNumber(GetData.TestData.GetValue<string>("num999"));
            calc.ClickButton("Равно");
            calc.ClickButton("Добавление памяти");
            calc.EnterNumber(GetData.TestData.GetValue<string>("num19"));
            calc.ClickButton("Сложение");
            calc.ClickButton("Вызов из памяти");
            calc.ClickButton("Равно");
            Assert.AreEqual(GetData.TestData.GetValue<string>("result"), calc.GetResult(), "Results are not the same");
        }
    }
}