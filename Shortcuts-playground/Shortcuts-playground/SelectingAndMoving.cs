using static ShortcutsPlayground.MoveMethodsInHierarchy;

namespace ShortcutsPlayground;

/* Ctrl+Alt+Shift+Arrow Up/Down --> Move line up or down */
/* Sort these lines */

public class ClassWithLinesToSort
{
    public void Whatever()
    {
        ///3
        ///2
        ///1
    }
}

/* Ctrl+Alt+Right Arrow to extend selection, Left Arrow to shrink */
/* Ctrl+Alt+Shift+Arrow Right/Left to move the methods inside the next one or outside the current one */
// 1. Select the methods using "extend selection" and Ctrl+Alt+Shift+Arrow Up/Down to sort them alphabetically
// 2. Move the class ThisShouldBeMovedOutside outside class MethodsToSort using Ctrl+Alt+Shift+Arrow 

public class MethodsToSort
{
    public class ThisShouldBeMovedOutside
    {
        
    }

    public string DMethod(int aNumber)
    {
        return aNumber.ToString();
    }

    public string CMethod(int aNumber)
    {
        return aNumber.ToString();
    }

    public string AnotherMethod(int aNumber)
    {
        return aNumber.ToString();
    }

    public string BMethod(int aNumber)
    {
        return aNumber.ToString();
    }
}