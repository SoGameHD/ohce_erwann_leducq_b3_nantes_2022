namespace OHCE.Langues
{
    public class LangueFrançaise : ILangue
    {
        public string BienDit => Expressions.Français.BienDit;
        public string Bonjour(PeriodeJournee periode)
        {
            return periode == PeriodeJournee.Soir || periode == PeriodeJournee.Nuit ? Expressions.Français.Bonsoir : Expressions.Français.Bonjour;
        }
        public string AuRevoir(PeriodeJournee periode)
        {
            return periode == PeriodeJournee.Soir || periode == PeriodeJournee.Nuit ? Expressions.Français.auRevoirSoir : Expressions.Français.AuRevoir;
        }
        public string useLanguage => Expressions.Français.useLanguage;
        public string enterString => Expressions.Français.enterString;
        public string reverseWord => Expressions.Français.reverseWord;
        public string periode => Expressions.Français.periode;
    }
}