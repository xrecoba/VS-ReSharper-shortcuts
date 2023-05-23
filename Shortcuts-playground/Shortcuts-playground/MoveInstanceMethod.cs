namespace ShortcutsPlayground;

class MoveInstanceMethod
{
    //1. Extract a method that receives the class we wanna move to (Ctrl+Shift+m)
    //2. Move to instance class (Ctrl+Shift+o)
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
            var isEven = sut.ANumber % 2 == 0;
            return isEven;
        }
    }
}