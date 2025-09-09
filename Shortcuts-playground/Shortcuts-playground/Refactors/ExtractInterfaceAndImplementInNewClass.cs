namespace ShortcutsPlayground;

/* Ctrl+Shift+r on top of the class name + Extract interface - Extract Interface */

// 1. Extract Interface of this class, containing only public methods
// 2. Create new derived type (Alt+Enter on the interface name)
// 3. Implement missing members of the interface (Alt+Enter on the new implementing class)
public class ExtractInterfaceAndImplementInNewClass
{   
    public int AMethod()
    {
        return 0;
    }

    public string AnotherMethod(int aNumber)
    {
        APrivateMethod();
        return aNumber.ToString();
    }

    private void APrivateMethod()
    {

    }
}