using NUnit.Framework;
using Shouldly;

namespace TddTrainingDay01.Test {
    [TestFixture]
    public class MyCalcTest {
        private static MyCalc MakeMyCalc() {
            return new MyCalc();
        }

        [TestCase(0, 1, -1)]
        [TestCase(1, 0, -1)]
        public void Add_WhenParameterIsNonPositive_ReturnsMinusOne(int a, int b, int expectedValue) {
            var sut = MakeMyCalc();

            var act = sut.Add(a, b);

            act.ShouldBe(expectedValue);
        }
    }
}
