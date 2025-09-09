namespace ShortcutsPlayground;

/* Ctrl+r+s - Change signature to reorder */
/* Ctrl+Shift+r when on top of the method + Transform Parameters --> Transform parameters */

// 1. Re-order the parameters of this method in a way that makes more sense
// 2. Afterward, group parameters in two single parameters (one param for geography and the other for settings)
public class ChangeSignatureAndTransformParameter
{
    public bool DoSomething(string country, bool useCache, string region, bool defaultToNull, string city)
    {
        return false;
    }
}