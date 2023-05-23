namespace ShortcutsPlayground;

// Ctrl + R + I
// Create a class that implements the interfacte (Alt+Enter on the interface name)
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

    public void APrivateMethod()
    {

    }
}