namespace ShortcutsPlayground;

// Ctrl+R+S - Change signature
public class CrappyMethodToReorganize
{
    public bool DoSomething(string country, bool useCache, string region, bool defaultToNull, string city)
    {
        return false;
    }
}

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