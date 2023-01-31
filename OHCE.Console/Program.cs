using OHCE;
using OHCE.Langues;

ILangue langue = new LangueFrançaise(); // Ici on instancie une langue à la main vu que ce n'est pas encore automatique
PeriodeJournee periode = PeriodeJournee.Matin; // Ici pareil, la période n'est pas encore automatique on l'instancie donc à la main

var ohce = new Ohce(langue, periode);
Console.WriteLine(langue.useLanguage + " : " + langue);
Console.WriteLine(langue.periode + " : " + periode);
Console.WriteLine(langue.enterString);
Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? string.Empty));