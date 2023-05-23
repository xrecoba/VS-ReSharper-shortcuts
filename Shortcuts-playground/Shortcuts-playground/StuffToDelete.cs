namespace ShortcutsPlayground;

// Alt+Del - Safe Delete
public class StuffToDelete
{
    public void AMethodCallingAnother()
    {
        TheOtherMethod();
    }

    public void TheOtherMethod()
    {
    }
}

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
