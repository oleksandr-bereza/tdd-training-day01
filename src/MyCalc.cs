using System;

namespace TddTrainingDay01 {
    public class MyCalc {
        public int Add(int a, int b) { // Entry point
            if (a < 1 || b < 1) {
                return -1; // Exit point
            }

            if (a <= 1000) {
                throw new InvalidOperationException("um, too high!"); // Exit point
            }

            return a + b; // Exit point
        }
    }
}