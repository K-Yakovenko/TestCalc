using FluentAssertions;
using TechTalk.SpecFlow;
using TestCalc.Framework.App;
using TestCalc.Framework.Base;
using TestCalc.Test.Screens;

namespace SpecFlowCalc.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly BaseTest _setapp;
        private readonly CalcWindow _calc;
        public CalculatorStepDefinitions(BaseTest setapp, CalcWindow calc)
        {
            _setapp = setapp;
            _calc = calc;
        }

        [Given(@"Calculator was opened")]
        public void GivenCalculatorWasOpened()
        {
            _setapp.Init();
            Application.Launch();
        }

        [Given(@"Numbers '([^']*)', '([^']*)' were entered and added up")]
        public void GivenNumbersWereEnteredAndAddedUp(string num1, string num2)
        {
            _calc.EnterNumber(num1);
            _calc.PlusButtonClick();
            _calc.EnterNumber(num2);
            _calc.EqualButtonClick();
        }

        [Given(@"The result was remembered")]
        public void GivenTheResultWasRemembered()
        {
            _calc.RememberResultButtonClick();
        }

        [When(@"The user enters number '([^']*)'")]
        public void WhenTheUserEntersNumber(string num)
        {
            _calc.EnterNumber(num);
        }

        [When(@"The user adds it to a number in memory")]
        public void WhenTheUserAddsItToANumberInMemory()
        {
            _calc.PlusButtonClick();
            _calc.GetRememberedNumberButtonClick();
            _calc.EqualButtonClick();
        }

        [Then(@"Number '([^']*)' is shown")]
        public void ThenNumberIsShown(string result)
        {
            _calc.GetResult().Should().Be(result);
        }

        [Then(@"The Calculator is closed")]
        public void ThenTheCalculatorIsClosed()
        {
            _setapp.Cleanup();
        }
    }
}