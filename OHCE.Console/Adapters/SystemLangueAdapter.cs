using System.Globalization;
using OHCE.Langues;

namespace OHCE.Console;

public class SystemLangueAdapter
{
    public ILangue Langue;
    public SystemLangueAdapter()
    {
        var systemLang = CultureInfo.InstalledUICulture.TwoLetterISOLanguageName;
        if (systemLang == "fr")
        {
            Langue = new LangueFrançaise();
        }
        else
        {
            Langue = new LangueAnglaise();
        }
    }
}