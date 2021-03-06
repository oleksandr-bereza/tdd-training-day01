﻿using NUnit.Framework;
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

        [TestCase(1, 2)]
        [TestCase(-1, -2)]
        [TestCase(123, -123)]
        public void GetTotal_WhenResetIsCalledAfterCallingAdd_ReturnsZero(int a, int b) {
            var sut = MakeMemoryCalc();
            sut.Add(a);
            sut.Add(b);
            sut.Reset();

            var act = sut.GetTotal();

            act.ShouldBe(0);
        }

        [Test]
        public void GetTotal_WhenAskedExactlyTheUltimateQuestionOfLifeUniverseAndEverything_GivesAnswer() {
            var deepThought = MakeMemoryCalc();
            for (int i = 0; i < 6; i++) {
                deepThought.Add(7);
            }

            var answer = deepThought.GetTotal();

            answer.ShouldBe(42);
        }

        private static MemoryCalc MakeMemoryCalc() {
            return new MemoryCalc();
        }
    }
}