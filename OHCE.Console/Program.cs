using OHCE;
using OHCE.Langues;

ILangue langue = new LangueAnglaise(); // Il faudrat l'automatiser par la suite

var ohce = new Ohce(langue);
Console.WriteLine(langue.enterString);
Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? string.Empty));