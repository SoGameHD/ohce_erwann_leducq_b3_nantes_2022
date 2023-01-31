using System.Text;

namespace OHCE;

public class Ohce
{
    private readonly ILangue _langue;
    private readonly PeriodeJournee _periode;

    public Ohce(ILangue langue, PeriodeJournee periode)
    {
        _langue = langue;
        _periode = periode;
    }

    public string Palindrome(string input)
    {
        var bonjour = new string(Bonjour());
        var auRevoir = new string(AuRevoir());
        var fullString = new StringBuilder(bonjour + '\n');
        var reversed = new string(input.Reverse().ToArray());

        if (reversed.Equals(input))
        {
            fullString.Append("Palindrome : " + reversed + "\n" + _langue.BienDit + "\n");
        }
        else
        {
            fullString.Append(_langue.reverseWord + " : " + reversed + "\n");
        }

        fullString.Append(auRevoir);
        return fullString.ToString();
    }

    public string Bonjour()
    {
        return _langue.Bonjour(_periode);
    }

    public string AuRevoir()
    {
        return _langue.AuRevoir(_periode);
    }
}