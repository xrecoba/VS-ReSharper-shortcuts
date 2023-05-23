namespace ShortcutsPlayground;

// Ctrl + Shift + R Transform parameters
// Alt + Enter In class name

public class TransformParameters
{
    public class InsuranceRiskService
    {
        public double GetRisk(string creditCardNumber, int amount, DateTime purchaseMoment)
        {
            // Put your algorithm here
            return creditCardNumber.Length +
                   amount + 
                   purchaseMoment.DayOfYear;
        }
    }
}