using System.Text;

namespace OHCE;

public class Ohce
{
    private readonly ILangue _langue;

    public Ohce(ILangue langue)
    {
        _langue = langue;
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
        return _langue.Bonjour;
    }

    public string AuRevoir()
    {
        return _langue.AuRevoir;
    }
}