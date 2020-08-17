using System;

namespace TddTrainingDay01 {
    public class MyCalc {
        public int Add(int a, int b) {
            if (a < 1 || b < 1) {
                return -1;
            }

            if (a > 1000) {
                throw new InvalidOperationException("um, too high!");
            }

            return a + b;
        }
    }
}