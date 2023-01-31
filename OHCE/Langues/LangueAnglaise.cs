namespace OHCE.Langues
{
    public class LangueAnglaise : ILangue
    {
        public string BienDit => Expressions.English.BienDit;
        public string Bonjour => Expressions.English.Bonjour;
        public string AuRevoir => Expressions.English.AuRevoir;
        public string useLanguage => Expressions.English.useLanguage;
        public string enterString => Expressions.English.enterString;
        public string reverseWord => Expressions.English.reverseWord;
    }
}