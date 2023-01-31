using OHCE;
using OHCE.Console;

PeriodeJournee periode = new SystemTimePeriodeJourneeAdapter().PeriodeActuelle;
ILangue langue = new SystemLangueAdapter().Langue;

var ohce = new Ohce(langue, periode);
Console.WriteLine(langue.useLanguage + " : " + langue);
Console.WriteLine(langue.periode + " : " + periode);
Console.WriteLine(langue.enterString);
Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? string.Empty));