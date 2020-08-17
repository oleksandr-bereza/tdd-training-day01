using NUnit.Framework;
using Shouldly;

namespace TddTrainingDay01.Test {
    [TestFixture]
    public class MyCalcTest {
        private static MyCalc MakeMyCalc() {
            return new MyCalc();
        }

        [Test]
        public void Add_WhenFirstParameterIsNonPositive_ReturnsMinusOne() {
            var sut = MakeMyCalc();

            var act = sut.Add(0, 1);

            act.ShouldBe(-1);
        }

        [Test]
        public void Add_WhenSecondParameterIsNonPositive_ReturnsMinusOne() {
            var sut = MakeMyCalc();

            var act = sut.Add(1, 0);

            act.ShouldBe(-1);
        }
    }
}
