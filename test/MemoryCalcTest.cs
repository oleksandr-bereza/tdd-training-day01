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

        private static MemoryCalc MakeMemoryCalc() {
            return new MemoryCalc();
        }
    }
}