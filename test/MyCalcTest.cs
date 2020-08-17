using System;
using NUnit.Framework;
using Shouldly;

namespace TddTrainingDay01.Test {
    [TestFixture]
    public class MyCalcTest {

        private const int DefaultValue = -1;
        private const int LargestNonPositiveNumber = 0;

        private static MyCalc MakeMyCalc() {
            return new MyCalc();
        }

        [TestCase(LargestNonPositiveNumber, 1, DefaultValue)]
        [TestCase(1, LargestNonPositiveNumber, DefaultValue)]
        public void Add_WhenParameterIsNonPositive_ReturnsDefaultValue(int a, int b, int expectedValue) {
            var sut = MakeMyCalc();

            var act = sut.Add(a, b);

            act.ShouldBe(expectedValue);
        }

        [Test]
        public void Add_WhenFirstParameterIsAboveThreshold_ThrowsException() {
            var sut = MakeMyCalc();

            Should.Throw<InvalidOperationException>(() => sut.Add(1001, 1))
                .Message.ShouldContain("um, too high!");
        }
    }
}
