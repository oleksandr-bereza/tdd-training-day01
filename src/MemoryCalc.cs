namespace TddTrainingDay01 {
    public class MemoryCalc {
        private int _total;

        public int GetTotal() {
            return _total; // Exit point
        }
        public void Add(int x) { // Entry point
            _total += x;
        }
        public void Reset() { // Entry point
            _total = 1;
        }
    }
}
