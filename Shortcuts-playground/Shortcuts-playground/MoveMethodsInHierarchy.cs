using static ShortcutsPlayground.MoveMethodsInHierarchy;

namespace ShortcutsPlayground;

// Ctrl + R + O on method name 
//      Push member down
//      Pull member up
public class MoveMethodsInHierarchy
{
    public class FirstLevel
    {
        public string AnotherMethod(int aNumber)
        {
            return aNumber.ToString();
        }
    }

    public class SecondLevel :FirstLevel
    {
        public string AMethod(int aNumber)
        {
            return aNumber.ToString();
        }
    }

    public class ThirdLevel: SecondLevel
    {
        public string OuterMethod(int aNumber)
        {
            return aNumber.ToString();
        }
    }
}

// tranform parameters
public class TransformParameters
{
    public class InsuranceRiskService
    {
        public double GetRisk(string creditCardNumber, int amount, DateTime purchaseMoment)
        {
            return 0;
        }
    }
}
