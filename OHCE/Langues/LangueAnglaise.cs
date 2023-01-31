namespace OHCE.Langues
{
    public class LangueAnglaise : ILangue
    {
        public string BienDit => Expressions.English.BienDit;
        public string Bonjour(PeriodeJournee periode)
        {
            return periode == PeriodeJournee.Soir || periode == PeriodeJournee.Nuit ? Expressions.English.Bonsoir : Expressions.English.Bonjour;
        }
        public string AuRevoir(PeriodeJournee periode)
        {
            return periode == PeriodeJournee.Soir || periode == PeriodeJournee.Nuit ? Expressions.English.auRevoirSoir : Expressions.English.AuRevoir;
        }
        public string useLanguage => Expressions.English.useLanguage;
        public string enterString => Expressions.English.enterString;
        public string reverseWord => Expressions.English.reverseWord;
        public string Periode => Expressions.English.periode;
    }
}