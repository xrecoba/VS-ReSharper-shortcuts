namespace ShortcutsPlayground;

// Ctrl+R+I
// Create derived type (Alt+Enter on the interface name)
// Implement missing members of the interface (Alt+Enter on the new implementing class)
public class ExtractInterface
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