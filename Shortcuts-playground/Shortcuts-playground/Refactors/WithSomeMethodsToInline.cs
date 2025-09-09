namespace ShortcutsPlayground;

// Ctrl+r+i - Inline method (you can also do it for variables)

// 1. Inline all the private methods in this class to make it more readable
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

    private void Method4() => Console.WriteLine("hard to read");

    private void Method3() => Console.WriteLine("is unnecessarily ");

    private void Method2() => Console.WriteLine("is doing");
}