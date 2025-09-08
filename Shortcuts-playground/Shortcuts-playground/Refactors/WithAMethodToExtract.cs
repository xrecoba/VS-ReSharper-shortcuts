using System.Collections;
using System.Text;

namespace ShortcutsPlayground;

/* Extract method: Ctrl + r + m */  
/* Split the method in 3 functions (header, body, footer) */
public class WithSomeMethodsToExtract
{
    public class TicketPrinter
    {
        public string Print(Ticket ticket)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"From:{ticket.Seller}");
            sb.AppendLine($"To:{ticket.Buyer}");
            sb.AppendLine($"Date:{ticket.EmissionDate}");

            sb.AppendLine("Articles");
            foreach (var line in Ticket.Lines)
            {
                sb.AppendLine($"Quantity + price and line total");
            }
            
            sb.AppendLine($"From:{ticket.Total}");
            sb.AppendLine("Thanks for buying");
            
            return sb.ToString();
        }
        
    }
}

public class Ticket
{
    public string Seller { get; set; }
    public string Buyer { get; set; }
    public string EmissionDate { get; set; }
    public string Total { get; set; }
    public static IEnumerable Lines { get; set; }
}