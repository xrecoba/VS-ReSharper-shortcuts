namespace ShortcutsPlayground;

class MoveInstanceMethod
{
    //1. Extract a method that receives as parameter the class we wanna move to (Ctrl+r+m),
    
    //  In this example, the calculation when a number is even should be moved to the Envied Class.
    //2.A Move to instance method (Ctrl+r+o) in case the method was not static
    //2.B Make method non-static in case the method was static (automatically moves it to Envied Class)
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