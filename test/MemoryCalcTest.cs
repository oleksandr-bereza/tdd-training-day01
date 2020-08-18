using NUnit.Framework;
using Shouldly;

namespace TddTrainingDay01.Test {
    [TestFixture]
    public class MemoryCalcTest {
        [Test]
        public void GetTotal_WhenClassInstantiated_ReturnsZero() {
            var sut = MakeMemoryCalc();

            var act = sut.GetTotal();

            act.ShouldBe(0);
        }

        [TestCase(1, 2, 3)]
        [TestCase(-1, -2, -3)]
        [TestCase(123, -123, 0)]
        public void GetTotal_WhenAddIsCalledTwice_ReturnsSumOfTwoNumbers(int a, int b, int expectedValue) {
            var sut = MakeMemoryCalc();
            sut.Add(a);
            sut.Add(b);

            var act = sut.GetTotal();

            act.ShouldBe(expectedValue);
        }

        private static MemoryCalc MakeMemoryCalc() {
            return new MemoryCalc();
        }
    }
}