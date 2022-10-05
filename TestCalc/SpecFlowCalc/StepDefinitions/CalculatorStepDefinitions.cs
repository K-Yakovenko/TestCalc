using FluentAssertions;
using TechTalk.SpecFlow;
using TestCalc.Framework.Base;
using TestCalc.Test.Screens;

namespace SpecFlowCalc.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly SetApp _setapp = new SetApp();
        private readonly CalcWindow _calc = new CalcWindow();

        [Given(@"launch calculator")]
        public void GivenLaunchCalculator()
        {
            _setapp.Init();
            _setapp.Launch();
        }


        [Given(@"enter numbers '([^']*)', '([^']*)' and add them up")]
        public void GivenEnterNumbersAndAddThemUp(string num1, string num2)
        {
            _calc.EnterNumber(num1);
            _calc.ClickButton("Сложение");
            _calc.EnterNumber(num2);
            _calc.ClickButton("Равно");
        }

        [Given(@"remember the result")]
        public void GivenRememberTheResult()
        {
            _calc.ClickButton("Добавление памяти");
        }

        [When(@"enter number '([^']*)'")]
        public void WhenEnterNumber(string num)
        {
            _calc.EnterNumber(num);
        }

        [When(@"add to a number in memory")]
        public void WhenAddToANumberInMemory()
        {
            _calc.ClickButton("Сложение");
            _calc.ClickButton("Вызов из памяти");
            _calc.ClickButton("Равно");
        }

        [Then(@"the result is '([^']*)'")]
        public void ThenTheResultIs(string result)
        {
            _calc.GetResult().Should().Be(result);
        }

        [Then(@"close calculator")]
        public void ThenCloseCalculator()
        {
            _setapp.Cleanup();
        }

    }
}