using static ShortcutsPlayground.MoveMethodsInHierarchy;

namespace ShortcutsPlayground;

/* Ctrl+Alt+Right Arrow to extend selection, Left Arrow to shrink */
/* Ctrl+Alt+Shift+Arrow Up/Down to move the methods in the file up or down */
/* Ctrl+Alt+Shift+Arrow Right/Left to move the methods inside the next one or outside the current one */

// Select the methods using "extend selection" and Ctrl+Alt+Shift+Arrow Up/Down to sort them alphabetically

public class MethodsToSort
{
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