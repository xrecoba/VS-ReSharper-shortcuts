using static ShortcutsPlayground.MoveMethodsInHierarchy;

namespace ShortcutsPlayground;

/* Ctrl + R + O on method name (on Visual Studio), Ctrl+Shift+r and then push or pull members up on Rider*/
// Move OuterMethod to FirstLevel and AMethod to the ThirdLevel

public class MoveMethodsInHierarchy
{
    public class FirstLevel
    {
        public string AnotherMethod(int aNumber)
        {
            return aNumber.ToString();
        }
    }

    public class SecondLevel :FirstLevel
    {
        public string AMethod(int aNumber)
        {
            return aNumber.ToString();
        }
    }

    public class ThirdLevel: SecondLevel
    {
        public string OuterMethod(int aNumber)
        {
            return aNumber.ToString();
        }
    }
}