namespace ShortcutsPlayground;

// Alt+Del - Safe Delete

// 1. Try to safe delete TheOtherMethod (stop in the warning)
// 2. Safe delete AMethodCallingAnother 
// 3. Try again to delete TheOtherMethod and see what happens
public class SafeDelete
{
    public void AMethodCallingAnother()
    {
        TheOtherMethod();
    }

    public void TheOtherMethod()
    {
    }
}