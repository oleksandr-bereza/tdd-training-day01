using NUnit.Framework;
using Shouldly;

namespace TddTrainingDay01.Test {
    [TestFixture]
    public class MyCalcTest {

        private const int DefaultValue = -1;

        private static MyCalc MakeMyCalc() {
            return new MyCalc();
        }

        [TestCase(0, 1, DefaultValue)]
        [TestCase(1, 0, DefaultValue)]
        public void Add_WhenParameterIsNonPositive_ReturnsDefaultValue(int a, int b, int expectedValue) {
            var sut = MakeMyCalc();

            var act = sut.Add(a, b);

            act.ShouldBe(expectedValue);
        }
    }
}
