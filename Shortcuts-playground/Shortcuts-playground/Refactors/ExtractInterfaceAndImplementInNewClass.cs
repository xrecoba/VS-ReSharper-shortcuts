namespace ShortcutsPlayground;

// Ctrl+R+I + Extract Interface of this class, only public methods
// Create new derived type (Alt+Enter on the interface name)
// Implement missing members of the interface (Alt+Enter on the new implementing class)
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