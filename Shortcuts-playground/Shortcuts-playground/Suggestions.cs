public class Suggestions
{
    /* Alt+Enter - Show context actions and quick-fixes. Can be identified when a 💡 appears at the start of the line */
    public class SampleClass
    {
        public int fixTheCasingOfThisProperty { get; private set; }
        public int RemoveThisUnusedOne { get; private set; }

        public SampleClass()
        {
            
        }

        public int Sum(IEnumerable<int> numbers)
        {
            var total = 0;
            foreach (var number in numbers)
            {
                total = total + number;
            }

            return total;
        }
    }
}