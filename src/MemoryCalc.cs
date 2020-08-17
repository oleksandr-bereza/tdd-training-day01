namespace TddTrainingDay01 {
    public class MemoryCalc {
        private int _total;

        public int GetTotal() {
            return _total;
        }
        public void Add(int x) {
            _total += x;
        }
        public void Reset() {
            _total = 0;
        }
    }
}
