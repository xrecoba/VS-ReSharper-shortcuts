namespace ShortcutsPlayground;

// Extract method: Ctrl + R + I
public class WithSomeMethodsToInline
{
    public void TheMethod()
    {
        Method1();
        Method2();
        Method3();
        Method4();
    }
    
    private void Method1() => Console.WriteLine("What this code");

    private void Method4() => Console.WriteLine("and hard to read");

    private void Method3() => Console.WriteLine("was scattered");

    private void Method2() => Console.WriteLine("is doing");
}