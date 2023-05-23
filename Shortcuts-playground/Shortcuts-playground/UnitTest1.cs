namespace ShortcutsPlayground
{
    public class UnitTest1
    {
        public int AnInteger { get; private set; }

        [Fact]
        public void Test1()
        {

        }
    }

    public class EnviedClass
    {
        public int ANumber { get; set; }
        public EnviedClass(int aNumber)
        {
            ANumber = aNumber;
        }
    }

    public class EnviyingClass
    {
        public bool Check(int aNumber)
        {
            var sut = new EnviedClass(4);
            var isEven = IsEven(sut);
            return isEven;
        }

        private bool IsEven(EnviedClass sut, string gola)
        {
            return sut.ANumber % 2 == 0;
        }
    }
}